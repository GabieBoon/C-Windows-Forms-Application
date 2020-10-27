using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using System.Data.SqlClient;


namespace DAL
{
    public static class SQLConnection
    {
        public static SqlConnection OpenConnectieDB()
        {
            try
            {
                SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder
                {
                    DataSource = "194.171.20.101",
                    UserID = "RBS_1718_grp07",
                    Password = "Cbh9uRPgtY",
                    InitialCatalog = "RBS_1718_DB07"
                };

                SqlConnection connection = new SqlConnection(builder.ConnectionString);

                connection.Open();

                return connection;
            }
            catch
            {
                throw new Exceptions.NetworkProblemException();
            }
          
        }

        //public static void SluitConnectieDB(SqlConnection connection)
        //{
        //    connection.Close();
        //}
    }

    public class LoginDaO
    {
        //Singleton
        private LoginDaO() { }
        private static LoginDaO instance;
        public static LoginDaO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new LoginDaO();
                }
                return instance;
            }
        }

        public Werknemer CheckLoginCode(string inlogCodeHash)
        {
            Werknemer werknemer = null;

            SqlConnection verbinding = null;
            SqlDataReader reader = null;

            //als er in deze fase een error optreed heeft dit altijd met de internetverbinding te maken
            try
            {
                verbinding = SQLConnection.OpenConnectieDB();

                StringBuilder sb = new StringBuilder();
                sb.Append("SELECT werknemerId, voornaam, achternaam, functieId ");
                sb.Append("FROM [dbo].[Werknemer] ");
                sb.Append("WHERE passwordHash LiKE @passwordHash");

                SqlCommand command = new SqlCommand
                {
                    Connection = verbinding,
                    CommandText = sb.ToString()
                };

                SqlParameter passwordHashParam = new SqlParameter("@passwordHash", System.Data.SqlDbType.Char, 64);
                command.Parameters.Add(passwordHashParam);
                passwordHashParam.Value = inlogCodeHash;
                command.Prepare();

                reader = command.ExecuteReader();
            }
            catch
            {
                throw new Exceptions.NetworkProblemException();
            }


            try
            {
                //geen werknemer gevonden? doorgaan na de catch
                if (reader.Read())
                {
                    werknemer = new Werknemer
                    {
                        WerknemersId = Convert.ToInt32(reader["werknemerId"]),
                        Voornaam = Convert.ToString(reader["voornaam"]),
                        Achternaam = Convert.ToString(reader["achternaam"]),
                        WerknemersType = (Enums.WerknemersType)Convert.ToInt32(reader["functieId"])
                    };
                }
            }
            //indien er wel een match gevonden is maar de conversie een error oplevert
            catch
            {
                werknemer = null;
                throw new Exceptions.DatabaseErrorException();
            }

            verbinding.Close();

            //return de ingelogde gebruiker indien ww correct, return null indien ww niet correct
            return werknemer;
        }

    }

    public class TafelOverzichtDaO
    {
        //Singleton
        private TafelOverzichtDaO() { }
        private static TafelOverzichtDaO instance;
        public static TafelOverzichtDaO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new TafelOverzichtDaO();
                }
                return instance;
            }
        }

        public List<Tafel> GetTafels()
        {
            List<Tafel> tafelLijst = new List<Tafel>();

            SqlConnection verbinding = null;
            SqlDataReader reader = null;

            //als er in deze fase een error optreed heeft dit altijd met de internetverbinding te maken
            try
            {
                verbinding = SQLConnection.OpenConnectieDB();

                StringBuilder sb = new StringBuilder();
                sb.Append("SELECT tafelNummer, maxPersonen, bezet ");
                sb.Append("FROM [dbo].[Tafel] ");              

                SqlCommand command = new SqlCommand
                {
                    Connection = verbinding,
                    CommandText = sb.ToString()
                };
                
                command.Prepare();

                reader = command.ExecuteReader();
            }
            catch
            {
                throw new Exceptions.NetworkProblemException();
            }

            try
            {
                while (reader.Read())
                {
                    Tafel tafel = new Tafel
                    {
                        TafelNummer = Convert.ToInt32(reader["tafelNummer"]),
                        MaxKlanten = Convert.ToInt32(reader["maxPersonen"]),
                        TafelStatus = Convert.ToInt32(reader["bezet"])
                    };

                    tafelLijst.Add(tafel);
                }
            }
            catch
            {
                throw new Exceptions.DatabaseErrorException();
            }

            return tafelLijst;
        }

        public List<TeBezorgenBestelling> GetTeBezorgenBestellingen(Werknemer werknemer)
        {
            List<TeBezorgenBestelling> teBezorgenBestellingenLijst = new List<TeBezorgenBestelling>();

            SqlConnection verbinding = null;
            SqlDataReader reader = null;

            //als er in deze fase een error optreed heeft dit altijd met de internetverbinding te maken
            try
            {
                verbinding = SQLConnection.OpenConnectieDB();

                StringBuilder sb = new StringBuilder();
                sb.Append("SELECT gk.tafelId AS tafelnummer, mi.naam AS item, mi.categorieId AS ophaalplaats, ");
                sb.Append("bi.rekeningId AS rekeningId, bi.aantal as aantal, bi.itemId as itemId ");
                sb.Append("FROM BestellingItem as bi ");
                sb.Append("JOIN MenuItem as mi on mi.itemId = bi.itemId ");
                sb.Append("JOIN Groepklanten as gk on bi.rekeningId = gk.rekeningId ");
                sb.Append("WHERE bi.status = 2 AND gk.werknemerId = @werknemerId ");
                sb.Append("ORDER BY bi.besteltijd ");

                SqlCommand command = new SqlCommand
                {
                    Connection = verbinding,
                    CommandText = sb.ToString()
                };

                SqlParameter werknemerIdParm = new SqlParameter("@werknemerId", System.Data.SqlDbType.Int);
                command.Parameters.Add(werknemerIdParm);
                werknemerIdParm.Value = werknemer.WerknemersId;

                command.Prepare();

                reader = command.ExecuteReader();
            }
            catch
            {
                throw new Exceptions.NetworkProblemException();
            }

            try
            {
                while (reader.Read())
                {
                    TeBezorgenBestelling teBezorgenBestelling = new TeBezorgenBestelling
                    {
                        TafelNummer = Convert.ToInt32(reader["tafelnummer"]),
                        Item = Convert.ToString(reader["item"]),
                        Ophaalplaats = Convert.ToString(reader["ophaalplaats"]),
                        Aantal = Convert.ToInt32(reader["aantal"]),
                        RekeningId = Convert.ToInt32(reader["rekeningId"]),
                        ItemId = Convert.ToInt32(reader["itemId"])
                    };

                    teBezorgenBestellingenLijst.Add(teBezorgenBestelling);
                }
            }
            catch
            {
                throw new Exceptions.DatabaseErrorException();
            }

            return teBezorgenBestellingenLijst;
        }

        public void ZetItemAlsKlaar(TeBezorgenBestelling teBezorgenBestelling, int veranderStatusNaar)
        {

            SqlConnection verbinding = null;
            SqlDataReader reader = null;

            //als er in deze fase een error optreed heeft dit altijd met de internetverbinding te maken
            try
            {
                verbinding = SQLConnection.OpenConnectieDB();

                StringBuilder sb = new StringBuilder();
                sb.Append("UPDATE BestellingItem ");
                sb.Append("SET status = @veranderStatusNaar ");           
                sb.Append("WHERE rekeningId = @rekeningId AND itemId = @itemId ");

                SqlCommand command = new SqlCommand
                {
                    Connection = verbinding,
                    CommandText = sb.ToString()
                };

                SqlParameter rekeningIdParam = new SqlParameter("@rekeningId", System.Data.SqlDbType.Int);
                command.Parameters.Add(rekeningIdParam);
                rekeningIdParam.Value = teBezorgenBestelling.RekeningId;

                SqlParameter ItemIdParam = new SqlParameter("@itemId", System.Data.SqlDbType.Int);
                command.Parameters.Add(ItemIdParam);
                ItemIdParam.Value = teBezorgenBestelling.ItemId;

                SqlParameter StatusIdParam = new SqlParameter("@veranderStatusNaar", System.Data.SqlDbType.Int);
                command.Parameters.Add(StatusIdParam);
                StatusIdParam.Value = veranderStatusNaar;

                command.Prepare();

                reader = command.ExecuteReader();
            }
            catch
            {
                throw new Exceptions.NetworkProblemException();
            }

            verbinding.Close();    
        }

        public void MaakGroepKlantenAan(Werknemer werknemer, Tafel tafel, int aantalPersonen, int rekeningId) 
        {           

            SqlConnection verbinding = null;
            SqlDataReader reader = null;

            //als er in deze fase een error optreed heeft dit altijd met de internetverbinding te maken
            try
            {
                verbinding = SQLConnection.OpenConnectieDB();

                StringBuilder sb = new StringBuilder();
                sb.Append("INSERT INTO [dbo].[GroepKlanten] ([groepId], [aantalPersonen], ");
                sb.Append("[werknemerId], [rekeningId], [tafelId]) ");
                sb.Append("VALUES(@rekeningId, @aantalPersonen, @werknemerId, @rekeningId, @tafelId) ");            

                SqlCommand command = new SqlCommand
                {
                    Connection = verbinding,
                    CommandText = sb.ToString()
                };

                SqlParameter rekeningIdParam = new SqlParameter("@rekeningId", System.Data.SqlDbType.Int);
                command.Parameters.Add(rekeningIdParam);
                rekeningIdParam.Value = rekeningId;

                SqlParameter AantalPersonenIdParam = new SqlParameter("@aantalPersonen", System.Data.SqlDbType.Int);
                command.Parameters.Add(AantalPersonenIdParam);
                AantalPersonenIdParam.Value = aantalPersonen;

                SqlParameter werknemerIdParam = new SqlParameter("@werknemerId", System.Data.SqlDbType.Int);
                command.Parameters.Add(werknemerIdParam);
                werknemerIdParam.Value = werknemer.WerknemersId;

                SqlParameter tafelIdParam = new SqlParameter("@tafelId", System.Data.SqlDbType.Int);
                command.Parameters.Add(tafelIdParam);
                tafelIdParam.Value = tafel.TafelNummer;

                command.Prepare();

                reader = command.ExecuteReader();
            }
            catch
            {
                throw new Exceptions.NetworkProblemException();
            }

        }

        public void MaakRekeningAan() //fix fix fix
        {

            SqlConnection verbinding = null;
            SqlDataReader reader = null;

            //als er in deze fase een error optreed heeft dit altijd met de internetverbinding te maken
            try
            {
                verbinding = SQLConnection.OpenConnectieDB();

                StringBuilder sb = new StringBuilder();
                sb.Append("INSERT INTO [dbo].[Rekening] ([prijs]) ");
                sb.Append("VALUES(0) ");

                SqlCommand command = new SqlCommand
                {
                    Connection = verbinding,
                    CommandText = sb.ToString()
                };

                command.Prepare();

                reader = command.ExecuteReader();
            }
            catch
            {
                throw new Exceptions.NetworkProblemException();
            }

        }

        public int VindHoogsteRekeningsId()
        {
            int hoogsteRekeningId = -1;

            SqlConnection verbinding = null;
            SqlDataReader reader = null;

            //als er in deze fase een error optreed heeft dit altijd met de internetverbinding te maken
            try
            {
                verbinding = SQLConnection.OpenConnectieDB();

                StringBuilder sb = new StringBuilder();
                sb.Append("SELECT TOP(1) rekeningId ");
                sb.Append("FROM [dbo].[Rekening] ");
                sb.Append("ORDER BY rekeningId DESC");

                SqlCommand command = new SqlCommand
                {
                    Connection = verbinding,
                    CommandText = sb.ToString()
                };
              
                reader = command.ExecuteReader();
            }
            catch
            {
                throw new Exceptions.NetworkProblemException();
            }


            try
            {
                //geen werknemer gevonden? doorgaan na de catch
                if (reader.Read())
                {
                    hoogsteRekeningId = Convert.ToInt32(reader["rekeningId"]);
                }
            }
            //indien er wel een match gevonden is maar de conversie een error oplevert
            catch
            {
                hoogsteRekeningId = -1;
                throw new Exceptions.DatabaseErrorException();
            }

            verbinding.Close();

            //return de ingelogde gebruiker indien ww correct, return null indien ww niet correct
            return hoogsteRekeningId;
        }

        public void VeranderTafelStatus(Tafel tafel, int status)
        {
            SqlConnection verbinding = null;
            SqlDataReader reader = null;

            //als er in deze fase een error optreed heeft dit altijd met de internetverbinding te maken

            try
            { 
                verbinding = SQLConnection.OpenConnectieDB();

                StringBuilder sb = new StringBuilder();
                sb.Append("UPDATE Tafel ");
                sb.Append("SET bezet = @status ");
                sb.Append("WHERE tafelNummer = @tafelId ");

                SqlCommand command = new SqlCommand
                {
                    Connection = verbinding,
                    CommandText = sb.ToString()
                };

                SqlParameter tafelIdParam = new SqlParameter("@tafelId", System.Data.SqlDbType.Int);
                command.Parameters.Add(tafelIdParam);
                tafelIdParam.Value = tafel.TafelNummer;

                SqlParameter statusParam = new SqlParameter("@status", System.Data.SqlDbType.Int);
                command.Parameters.Add(statusParam);                
                statusParam.Value = status;

                command.Prepare();

                reader = command.ExecuteReader();
            }
            catch
            {
                throw new Exceptions.NetworkProblemException();
            }

            verbinding.Close();
        }
    }

    public class Barman_DAL
    {
        //Singleton
        public Barman_DAL() { }
        private static Barman_DAL instance;
        public static Barman_DAL Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Barman_DAL();
                }
                return instance;
            }
        }

        public List<Model.BestellingItem> BestellingToDoOphalen()
        {
            Barman_DAL bestellingen = null;

            SqlConnection verbinding = null;
            SqlDataReader reader = null;

            //als er in deze fase een error optreed heeft dit altijd met de internetverbinding te maken
            try
            {
                verbinding = SQLConnection.OpenConnectieDB();

                StringBuilder sb = new StringBuilder();

                sb.Append("SELECT BI.aantal, MI.naam, BI.besteltijd, GK.tafelId, W.voornaam, BI.status, BI.itemId ");
                sb.Append("FROM dbo.BestellingItem AS BI ");
                sb.Append("JOIN  MenuItem AS MI ON BI.itemId = MI.itemId ");
                sb.Append("JOIN GroepKlanten AS GK ON BI.rekeningId = GK.rekeningId ");
                sb.Append("JOIN Werknemer AS W ON GK.werknemerId = W.werknemerId ");
                sb.Append("WHERE (BI.status = 1) AND (MI.categorieId = 3 OR MI.categorieId = 4) ");
                sb.Append("ORDER BY BI.besteltijd ");

                SqlCommand command = new SqlCommand
                {
                    Connection = verbinding,
                    CommandText = sb.ToString()
                };

                reader = command.ExecuteReader();
            }

            catch
            {
                throw new Exceptions.NetworkProblemException();
            }

            List<Model.BestellingItem> bestellingen_lijst = new List<Model.BestellingItem>();

            try
            {
                //geen werknemer gevonden? doorgaan na de catch


                while (reader.Read())
                {
                    BestellingItem bestellingenitem = new BestellingItem();
                    bestellingenitem.itemId = Convert.ToInt32(reader["itemId"]);
                    bestellingenitem.SetAantal(Convert.ToInt32(reader["aantal"]));
                    bestellingenitem.SetNaam(Convert.ToString(reader["naam"]));
                    bestellingenitem.SetBesteltijd(Convert.ToDateTime(reader["besteltijd"]));
                    bestellingenitem.SetTafelId(Convert.ToInt32(reader["tafelid"]));
                    bestellingenitem.SetWerknemerId(Convert.ToString(reader["voornaam"]));
                    bestellingenitem.SetStatus(Convert.ToInt32(reader["status"]));

                    bestellingen_lijst.Add(bestellingenitem);
                }
            }
            //indien er wel een match gevonden is maar de conversie een error oplevert
            catch
            {
                bestellingen = null;
                throw new Exceptions.DatabaseErrorException();
            }

            verbinding.Close();

            //return de bestelling lijst
            return bestellingen_lijst;
        }

        public void meldBestellingKlaar(BestellingItem bestellingItem)
        {
            SqlConnection verbinding = null;
            SqlDataReader reader = null;

            verbinding = SQLConnection.OpenConnectieDB();

            StringBuilder sb = new StringBuilder();
            sb.Append("UPDATE dbo.BestellingItem ");
            sb.Append("SET status = 2 ");
            sb.Append("WHERE rekeningId = @rekeningId AND itemId = @itemId AND status = 1 ");

            SqlCommand command = new SqlCommand
            {
                Connection = verbinding,
                CommandText = sb.ToString()
            };

            SqlParameter rekeningIdParam = new SqlParameter("@rekeningId", System.Data.SqlDbType.Int);
            command.Parameters.Add(rekeningIdParam);
            //rekeningIdParam.Value = bestellingItem.groepId;
            DAL.Bestelling_DAL dal = new Bestelling_DAL();
            rekeningIdParam.Value = dal.Get_rekeningId(bestellingItem.tafelId);


            SqlParameter ItemIdParam = new SqlParameter("@itemId", System.Data.SqlDbType.Int);
            command.Parameters.Add(ItemIdParam);
            ItemIdParam.Value = bestellingItem.itemId;

            command.Prepare();

            reader = command.ExecuteReader();

            verbinding.Close();
        }

        public List<Model.BestellingItem> BestellingDoneOphalen()
        {
            Barman_DAL bestellingen = null;

            SqlConnection verbinding = null;
            SqlDataReader reader = null;

            //als er in deze fase een error optreed heeft dit altijd met de internetverbinding te maken
            try
            {
                verbinding = SQLConnection.OpenConnectieDB();

                StringBuilder sb = new StringBuilder();

                sb.Append("SELECT BI.aantal, MI.naam, BI.besteltijd, GK.tafelId, W.voornaam, BI.status, BI.itemId ");
                sb.Append("FROM dbo.BestellingItem AS BI ");
                sb.Append("JOIN  MenuItem AS MI ON BI.itemId = MI.itemId ");
                sb.Append("JOIN GroepKlanten AS GK ON BI.rekeningId = GK.rekeningId ");
                sb.Append("JOIN Werknemer AS W ON GK.werknemerId = W.werknemerId ");
                sb.Append("WHERE (BI.status = 2) AND (MI.categorieId = 3 OR MI.categorieId = 4) ");
                sb.Append("ORDER BY BI.besteltijd ");

                SqlCommand command = new SqlCommand
                {
                    Connection = verbinding,
                    CommandText = sb.ToString()
                };

                reader = command.ExecuteReader();
            }

            catch
            {
                throw new Exceptions.NetworkProblemException();
            }

            List<Model.BestellingItem> bestellingen_lijst = new List<Model.BestellingItem>();

            try
            {
                //geen werknemer gevonden? doorgaan na de catch


                while (reader.Read())
                {
                    BestellingItem bestellingenitem = new BestellingItem();
                    bestellingenitem.itemId = Convert.ToInt32(reader["itemId"]);
                    bestellingenitem.SetAantal(Convert.ToInt32(reader["aantal"]));
                    bestellingenitem.SetNaam(Convert.ToString(reader["naam"]));
                    bestellingenitem.SetBesteltijd(Convert.ToDateTime(reader["besteltijd"]));
                    bestellingenitem.SetTafelId(Convert.ToInt32(reader["tafelid"]));
                    bestellingenitem.SetWerknemerId(Convert.ToString(reader["voornaam"]));
                    bestellingenitem.SetStatus(Convert.ToInt32(reader["status"]));

                    bestellingen_lijst.Add(bestellingenitem);
                }
            }
            //indien er wel een match gevonden is maar de conversie een error oplevert
            catch
            {
                bestellingen = null;
                throw new Exceptions.DatabaseErrorException();
            }

            verbinding.Close();

            //return de bestelling lijst
            return bestellingen_lijst;
        }

        public void meldBestellingOnKlaar(BestellingItem bestellingItem)
        {
            SqlConnection verbinding = null;
            SqlDataReader reader = null;

            verbinding = SQLConnection.OpenConnectieDB();

            StringBuilder sb = new StringBuilder();
            sb.Append("UPDATE dbo.BestellingItem ");
            sb.Append("SET status = 1 ");
            sb.Append("WHERE rekeningId = @rekeningId AND itemId = @itemId AND status = 2 ");

            SqlCommand command = new SqlCommand
            {
                Connection = verbinding,
                CommandText = sb.ToString()
            };

            SqlParameter rekeningIdParam = new SqlParameter("@rekeningId", System.Data.SqlDbType.Int);
            command.Parameters.Add(rekeningIdParam);
            //rekeningIdParam.Value = bestellingItem.groepId;

            DAL.Bestelling_DAL dal = new Bestelling_DAL();
            rekeningIdParam.Value = dal.Get_rekeningId(bestellingItem.tafelId);

            SqlParameter ItemIdParam = new SqlParameter("@itemId", System.Data.SqlDbType.Int);
            command.Parameters.Add(ItemIdParam);
            ItemIdParam.Value = bestellingItem.itemId;

            command.Prepare();

            reader = command.ExecuteReader();

            verbinding.Close();
        }

    }

    //          ==========================
    //                  keuken
    //          ==========================








    public class Keuken_DAL
    {
        //Singleton
        public Keuken_DAL() { }
        private static Keuken_DAL instance;
        public static Keuken_DAL Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Keuken_DAL();
                }
                return instance;
            }
        }

        public List<Model.BestellingItem> BestellingToDoOphalen()
        {
            Barman_DAL bestellingen = null;

            SqlConnection verbinding = null;
            SqlDataReader reader = null;

            //als er in deze fase een error optreed heeft dit altijd met de internetverbinding te maken
            try
            {
                verbinding = SQLConnection.OpenConnectieDB();

                StringBuilder sb = new StringBuilder();

                sb.Append("SELECT BI.aantal, MI.naam, BI.besteltijd, GK.tafelId, W.voornaam, BI.status, BI.itemId ");
                sb.Append("FROM dbo.BestellingItem AS BI ");
                sb.Append("JOIN  MenuItem AS MI ON BI.itemId = MI.itemId ");
                sb.Append("JOIN GroepKlanten AS GK ON BI.rekeningId = GK.rekeningId ");
                sb.Append("JOIN Werknemer AS W ON GK.werknemerId = W.werknemerId ");
                sb.Append("WHERE (BI.status = 1) AND (MI.categorieId = 1 OR MI.categorieId = 2) ");
                sb.Append("ORDER BY BI.besteltijd ");

                SqlCommand command = new SqlCommand
                {
                    Connection = verbinding,
                    CommandText = sb.ToString()
                };

                reader = command.ExecuteReader();
            }

            catch
            {
                throw new Exceptions.NetworkProblemException();
            }

            List<Model.BestellingItem> bestellingen_lijst = new List<Model.BestellingItem>();

            try
            {
                //geen werknemer gevonden? doorgaan na de catch


                while (reader.Read())
                {
                    BestellingItem bestellingenitem = new BestellingItem();
                    bestellingenitem.itemId = Convert.ToInt32(reader["itemId"]);
                    bestellingenitem.SetAantal(Convert.ToInt32(reader["aantal"]));
                    bestellingenitem.SetNaam(Convert.ToString(reader["naam"]));
                    bestellingenitem.SetBesteltijd(Convert.ToDateTime(reader["besteltijd"]));
                    bestellingenitem.SetTafelId(Convert.ToInt32(reader["tafelid"]));
                    bestellingenitem.SetWerknemerId(Convert.ToString(reader["voornaam"]));
                    bestellingenitem.SetStatus(Convert.ToInt32(reader["status"]));

                    bestellingen_lijst.Add(bestellingenitem);
                }
            }
            //indien er wel een match gevonden is maar de conversie een error oplevert
            catch
            {
                bestellingen = null;
                throw new Exceptions.DatabaseErrorException();
            }

            verbinding.Close();

            //return de bestelling lijst
            return bestellingen_lijst;
        }

        public void meldBestellingKlaar(BestellingItem bestellingItem)
        {
            SqlConnection verbinding = null;
            SqlDataReader reader = null;

            verbinding = SQLConnection.OpenConnectieDB();

            StringBuilder sb = new StringBuilder();
            sb.Append("UPDATE dbo.BestellingItem ");
            sb.Append("SET status = 2 ");
            sb.Append("WHERE rekeningId = @rekeningId AND itemId = @itemId AND status = 1 ");

            SqlCommand command = new SqlCommand
            {
                Connection = verbinding,
                CommandText = sb.ToString()
            };

            SqlParameter rekeningIdParam = new SqlParameter("@rekeningId", System.Data.SqlDbType.Int);
            command.Parameters.Add(rekeningIdParam);
            //rekeningIdParam.Value = bestellingItem.groepId;
            DAL.Bestelling_DAL dal = new Bestelling_DAL();
            rekeningIdParam.Value = dal.Get_rekeningId(bestellingItem.tafelId);


            SqlParameter ItemIdParam = new SqlParameter("@itemId", System.Data.SqlDbType.Int);
            command.Parameters.Add(ItemIdParam);
            ItemIdParam.Value = bestellingItem.itemId;

            command.Prepare();

            reader = command.ExecuteReader();

            verbinding.Close();
        }

        public List<Model.BestellingItem> BestellingDoneOphalen()
        {
            Barman_DAL bestellingen = null;

            SqlConnection verbinding = null;
            SqlDataReader reader = null;

            //als er in deze fase een error optreed heeft dit altijd met de internetverbinding te maken
            try
            {
                verbinding = SQLConnection.OpenConnectieDB();

                StringBuilder sb = new StringBuilder();

                sb.Append("SELECT BI.aantal, MI.naam, BI.besteltijd, GK.tafelId, W.voornaam, BI.status, BI.itemId ");
                sb.Append("FROM dbo.BestellingItem AS BI ");
                sb.Append("JOIN  MenuItem AS MI ON BI.itemId = MI.itemId ");
                sb.Append("JOIN GroepKlanten AS GK ON BI.rekeningId = GK.rekeningId ");
                sb.Append("JOIN Werknemer AS W ON GK.werknemerId = W.werknemerId ");
                sb.Append("WHERE (BI.status = 2) AND (MI.categorieId = 1 OR MI.categorieId = 2) ");
                sb.Append("ORDER BY BI.besteltijd ");

                SqlCommand command = new SqlCommand
                {
                    Connection = verbinding,
                    CommandText = sb.ToString()
                };

                reader = command.ExecuteReader();
            }

            catch
            {
                throw new Exceptions.NetworkProblemException();
            }

            List<Model.BestellingItem> bestellingen_lijst = new List<Model.BestellingItem>();

            try
            {
                //geen werknemer gevonden? doorgaan na de catch


                while (reader.Read())
                {
                    BestellingItem bestellingenitem = new BestellingItem();
                    bestellingenitem.itemId = Convert.ToInt32(reader["itemId"]);
                    bestellingenitem.SetAantal(Convert.ToInt32(reader["aantal"]));
                    bestellingenitem.SetNaam(Convert.ToString(reader["naam"]));
                    bestellingenitem.SetBesteltijd(Convert.ToDateTime(reader["besteltijd"]));
                    bestellingenitem.SetTafelId(Convert.ToInt32(reader["tafelid"]));
                    bestellingenitem.SetWerknemerId(Convert.ToString(reader["voornaam"]));
                    bestellingenitem.SetStatus(Convert.ToInt32(reader["status"]));

                    bestellingen_lijst.Add(bestellingenitem);
                }
            }
            //indien er wel een match gevonden is maar de conversie een error oplevert
            catch
            {
                bestellingen = null;
                throw new Exceptions.DatabaseErrorException();
            }

            verbinding.Close();

            //return de bestelling lijst
            return bestellingen_lijst;
        }

        public void meldBestellingOnKlaar(BestellingItem bestellingItem)
        {
            SqlConnection verbinding = null;
            SqlDataReader reader = null;

            verbinding = SQLConnection.OpenConnectieDB();

            StringBuilder sb = new StringBuilder();
            sb.Append("UPDATE dbo.BestellingItem ");
            sb.Append("SET status = 1 ");
            sb.Append("WHERE rekeningId = @rekeningId AND itemId = @itemId AND status = 2 ");

            SqlCommand command = new SqlCommand
            {
                Connection = verbinding,
                CommandText = sb.ToString()
            };

            SqlParameter rekeningIdParam = new SqlParameter("@rekeningId", System.Data.SqlDbType.Int);
            command.Parameters.Add(rekeningIdParam);
            //rekeningIdParam.Value = bestellingItem.groepId;

            DAL.Bestelling_DAL dal = new Bestelling_DAL();
            rekeningIdParam.Value = dal.Get_rekeningId(bestellingItem.tafelId);

            SqlParameter ItemIdParam = new SqlParameter("@itemId", System.Data.SqlDbType.Int);
            command.Parameters.Add(ItemIdParam);
            ItemIdParam.Value = bestellingItem.itemId;

            command.Prepare();

            reader = command.ExecuteReader();

            verbinding.Close();
        }

    }

    public class Bestelling_DAL
    {

        public bool Check_data(int tafel, int itemId)
        {
            bool check = false;
            string sql = "SELECT *  FROM dbo.bestellingItem WHERE rekeningId = " + Get_rekeningId(tafel) + " AND itemId = " + itemId;
            SqlConnection verbinding = null;
            SqlDataReader reader = null;
            {
                verbinding = SQLConnection.OpenConnectieDB();
                using (SqlCommand cmd = new SqlCommand(sql, verbinding))
                {

                    reader = cmd.ExecuteReader();

                    if (reader.HasRows)
                    {
                        check = true;
                    }
                    else
                    {
                        check = false;//data not exist
                    }
                }

            }
            verbinding.Close();
            return check;
        }
        public int Get_rekeningId(int tafelId)
        {

            int rekeningId = 0;
            string sql = "SELECT MAX(rekeningId) as rekeningId FROM dbo.GroepKlanten WHERE tafelId = " + tafelId;
            SqlConnection verbinding = null;
            SqlDataReader reader = null;

            {
                verbinding = SQLConnection.OpenConnectieDB();
                using (SqlCommand cmd = new SqlCommand(sql, verbinding))
                {

                    reader = cmd.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            rekeningId = reader.GetInt32(0);
                            // data exist
                        }
                    }

                }
                verbinding.Close();
                return rekeningId;
            }

        }

        public void Insert(int tafelId, int Itemid, int Aantal)
        {
            SqlConnection verbinding = null;
            SqlDataReader reader = null;
            try
            {
                verbinding = SQLConnection.OpenConnectieDB();

                StringBuilder sb = new StringBuilder();
                sb.Append("INSERT INTO dbo.BestellingItem(rekeningId, itemId, aantal, status, besteltijd)  VALUES(" + Get_rekeningId(tafelId) + ", " + Itemid + ", " + Aantal + ", 1, GETDATE())  UPDATE dbo.MenuItem SET voorraad = (voorraad - " + Aantal + ") WHERE itemId = " + Itemid);
                SqlCommand command = new SqlCommand
                {
                    Connection = verbinding,
                    CommandText = sb.ToString()
                };

                command.Prepare();

                reader = command.ExecuteReader();
            }
            catch (Exception ex)
            {
                //System.Windows.Forms.MessageBox.Show(ex.Message);
            }
            verbinding.Close();
        }
        public void Update(int tafelId, int Itemid, int Aantal)
        {
            SqlConnection verbinding = null;
            SqlDataReader reader = null;

            try
            {
                verbinding = SQLConnection.OpenConnectieDB();

                StringBuilder up = new StringBuilder();
                up.Append("UPDATE dbo.BestellingItem SET itemId =  " + Itemid + ", aantal = " + Aantal + " WHERE rekeningId =  " + Get_rekeningId(tafelId) + "AND itemId = " + Itemid + " UPDATE dbo.MenuItem SET voorraad = (voorraad -" + Aantal + ") WHERE itemId =  " + Itemid + "");
                SqlCommand command_up = new SqlCommand
                {
                    Connection = verbinding,
                    CommandText = up.ToString()

                };
                command_up.Prepare();

                reader = command_up.ExecuteReader();
            }
            catch (Exception a)
            {
                //System.Windows.Forms.MessageBox.Show(a.Message);
            }
            verbinding.Close();
        }

        public void Delete(int tafelId)
        {
            SqlConnection verbinding = null;
            SqlDataReader reader = null;
            try
            {
                verbinding = SQLConnection.OpenConnectieDB();

                StringBuilder sb = new StringBuilder();
                sb.Append("DELETE FROM dbo.BestellingItem WHERE rekeningId = " + Get_rekeningId(tafelId));
                SqlCommand command = new SqlCommand
                {
                    Connection = verbinding,
                    CommandText = sb.ToString()
                };

                command.Prepare();

                reader = command.ExecuteReader();
            }
            catch (Exception ex)
            {
                //System.Windows.Forms.MessageBox.Show(ex.Message);
            }
            verbinding.Close();
        }



    }

    public class BesteldeConsumpties_DAL
    {
        public List<BesteldeConsumpties> DB_getRekeningen(int rekeningId)
        {

            SqlConnection verbinding = SQLConnection.OpenConnectieDB();
            StringBuilder sb = new StringBuilder();
            sb.Append("SELECT MenuItem.naam, BestellingItem.aantal ,MenuItem.prijs,MenuItem.categorieId,Categorie.btw ");
            sb.Append("FROM MenuItem ");
            sb.Append("INNER JOIN BestellingItem on BestellingItem.itemId = MenuItem.itemId ");
            sb.Append("INNER JOIN GroepKlanten on GroepKlanten.rekeningId = BestellingItem.rekeningId ");
            sb.Append("INNER JOIN Categorie on Categorie.categorieId = MenuItem.categorieId ");
            sb.Append("WHERE GroepKlanten.rekeningId=@rekeningId");
            String sql = sb.ToString();
            SqlCommand command = new SqlCommand(sql, verbinding);

            SqlParameter rekeningParam = new SqlParameter("@rekeningId", rekeningId);
            command.Parameters.Add(rekeningParam);

            SqlDataReader reader = command.ExecuteReader();

            List<BesteldeConsumpties> rekeningen_lijst = new List<BesteldeConsumpties>();
            while (reader.Read())
            {
                BesteldeConsumpties besteldeConsumptie = new BesteldeConsumpties();
                besteldeConsumptie.Consumptie = ((string)reader["naam"]);
                besteldeConsumptie.Aantal = ((int)reader["aantal"]);
                besteldeConsumptie.Prijs = ((decimal)reader["prijs"]);
                besteldeConsumptie.CategorieId = ((Enums.MenuItemCategorieId)reader["categorieId"]);
                besteldeConsumptie.Btw = ((decimal)reader["btw"]);
                rekeningen_lijst.Add(besteldeConsumptie);
            }
            verbinding.Close();
            return rekeningen_lijst;
        }
    }

    public class Rekening_DAL
    {
        public void InsertRekening(int rekeningId, int betaalWijze, decimal totaalprijs)
        {
            SqlConnection verbinding = SQLConnection.OpenConnectieDB();

            StringBuilder sb = new StringBuilder();
            sb.Append("UPDATE Rekening ");
            sb.Append("SET prijs=@prijs, tijdDatum=@tijd, betaalWijze=@betaalWijze ");
            sb.Append("WHERE rekeningId=@rekeningId ");
            String sql = sb.ToString();

            SqlCommand command = new SqlCommand(sql, verbinding);

            SqlParameter rekeningIdParam = new SqlParameter("@rekeningId", rekeningId);
            SqlParameter prijsParam = new SqlParameter("@prijs", totaalprijs);
            SqlParameter tijdParam = new SqlParameter("@tijd", DateTime.Now);
            SqlParameter betaalWijzeParam = new SqlParameter("@betaalWijze", betaalWijze);

            command.Parameters.Add(rekeningIdParam);
            command.Parameters.Add(prijsParam);
            command.Parameters.Add(tijdParam);
            command.Parameters.Add(betaalWijzeParam);

            SqlDataReader reader = command.ExecuteReader();
            verbinding.Close();
        }

        public void InsertFooi(int rekeningId, decimal fooi)
        {
            SqlConnection verbinding = SQLConnection.OpenConnectieDB();
            StringBuilder sb = new StringBuilder();
            sb.Append("INSERT INTO Fooi (rekeningId,fooi)");
            sb.Append("VALUES ((SELECT rekeningId FROM GroepKlanten WHERE rekeningId = @rekeningId),@fooi)");
            String sql = sb.ToString();
            SqlCommand command = new SqlCommand(sql, verbinding);

            SqlParameter rekeningIdParam = new SqlParameter("@rekeningId", rekeningId);
            SqlParameter fooiParam = new SqlParameter("@fooi", fooi);
            command.Parameters.Add(rekeningIdParam);
            command.Parameters.Add(fooiParam);

            SqlDataReader reader = command.ExecuteReader();
            verbinding.Close();
        }
        public int Get_rekeningId(int tafelId)
        {
            int rekeningId = 0;
            string sql = "SELECT MAX(rekeningId) as rekeningId FROM dbo.GroepKlanten WHERE tafelId = " + tafelId;
            SqlConnection verbinding = null;
            SqlDataReader reader = null;
            {
                verbinding = SQLConnection.OpenConnectieDB();
                using (SqlCommand cmd = new SqlCommand(sql, verbinding))
                {

                    reader = cmd.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            rekeningId = reader.GetInt32(0);
                        }
                    }

                }
                verbinding.Close();
                return rekeningId;
            }
        }
    }

    public class MenuItem_Dal
    {
        public List<Model.MenuItem> DB_GetMenuItems(int Categorie)
        {

            List<Model.MenuItem> MenuLijst = new List<Model.MenuItem>();
            SqlConnection verbinding = null;
            SqlDataReader reader = null;
            StringBuilder sb = new StringBuilder();


            //sb.Append(" FROM dbo.MenuItem ");
            //sb.Append(" WHERE categorieId = "+Categorie+" ");

            string query = sb.ToString();


            try
            {
                verbinding = SQLConnection.OpenConnectieDB();
                sb.Append("SELECT itemId ,naam, voorraad, TypeGerecht FROM dbo.MenuItem WHERE categorieId = " + Categorie + "  ORDER BY TypeGerecht");
                SqlCommand command = new SqlCommand
                {
                    Connection = verbinding,
                    CommandText = sb.ToString()
                };
                command.Prepare();
                reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        Model.MenuItem Id = new Model.MenuItem
                            (
                            (int)reader["itemId"],
                            (string)reader["naam"],
                            (int)reader["voorraad"],
                            0,
                            (int)reader["TypeGerecht"]
                            );

                        MenuLijst.Add(Id);
                    }
                }
                else
                {
                    //Console.WriteLine("SQL Data Reader is leeg.");
                    MenuLijst = null;
                }

                verbinding.Close();
            }
            catch (Exception e)
            {
                //Console.WriteLine(e.ToString());

                MenuLijst = null;
            }

            return MenuLijst;

        }
    }
}
