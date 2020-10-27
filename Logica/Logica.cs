using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using DAL;
using System.Security.Cryptography;

namespace Logica
{
    public class Inloggen
    {
        //Singleton
        private Inloggen() { }
        private static Inloggen instance;         
        public static Inloggen Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Inloggen();
                }
                return instance;
            }
        }


        public Werknemer ValideerInloggen(string inlogcode)
        {
            Werknemer werknemer = null;

            // encrypt en check de encrypte code met de db 
            try
            {
                werknemer = LoginDaO.Instance.CheckLoginCode(MaakInlogcodeHash(inlogcode));
            }

            catch (Exceptions.DatabaseErrorException)
            {
                throw new Exceptions.DatabaseErrorException();
            }
            catch (Exceptions.NetworkProblemException)
            {
                throw new Exceptions.NetworkProblemException();
            }
                    
            return werknemer;
        }

        private string MaakInlogcodeHash(string inlogcode)
        {
            //encrypt data via sha256 protocol
            SHA256 sha256 = SHA256Managed.Create();
            byte[] inlogcodeHashData = sha256.ComputeHash(Encoding.UTF8.GetBytes(inlogcode));

            //zet de encrypte data om naar een string
            StringBuilder stringBuilder = new StringBuilder();

            for (int i = 0; i < inlogcodeHashData.Length; i++)
            {
                stringBuilder.Append(inlogcodeHashData[i].ToString("x2")); // x2 zorgt voor hexadecimale output
            }

            return stringBuilder.ToString();

        }

        // extra beveiliging: netwerk beveiligen zodat db alleen via het netwerk van chapoo te 
        // benaderen is. 

    }

    public class TafelOverzicht
    {
        //Singleton
        private TafelOverzicht() { }
        private static TafelOverzicht instance;
        public static TafelOverzicht Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new TafelOverzicht();
                }
                return instance;
            }
        }

        public List<Tafel> HaalTafelInformatie()
        {
            List<Tafel> tafelLijst = new List<Tafel>();

            try
            {
                tafelLijst = TafelOverzichtDaO.Instance.GetTafels();
            }

            catch (Exceptions.DatabaseErrorException)
            {
                throw new Exceptions.DatabaseErrorException();
            }
            catch (Exceptions.NetworkProblemException)
            {
                throw new Exceptions.NetworkProblemException();
            }

            return tafelLijst;
        }

        public List<TeBezorgenBestelling> HaalTeBezorgenBestellingen(Werknemer werknemer)
        {

            List<TeBezorgenBestelling> teBezorgenBestellingenLijst = null;

            try
            {
                teBezorgenBestellingenLijst = TafelOverzichtDaO.Instance.GetTeBezorgenBestellingen(werknemer);
            }

            catch (Exceptions.DatabaseErrorException)
            {
                throw new Exceptions.DatabaseErrorException();
            }
            catch (Exceptions.NetworkProblemException)
            {
                throw new Exceptions.NetworkProblemException();
            }        

            return teBezorgenBestellingenLijst;
        }

        public void MeldStatusKlaar(TeBezorgenBestelling teBezorgenBestelling)
        {

            try
            {
                TafelOverzichtDaO.Instance.ZetItemAlsKlaar(teBezorgenBestelling, 3);
            }

            catch (Exceptions.NetworkProblemException)
            {
                throw new Exceptions.NetworkProblemException();
            }

        }

        public void MeldStatusOnKlaar(TeBezorgenBestelling teBezorgenBestelling)
        {

            try
            {
                TafelOverzichtDaO.Instance.ZetItemAlsKlaar(teBezorgenBestelling, 2);
            }

            catch (Exceptions.NetworkProblemException)
            {
                throw new Exceptions.NetworkProblemException();
            }

        }

        public void VeranderTafelStatus(Tafel tafel, int status)
        {

            try
            {
                TafelOverzichtDaO.Instance.VeranderTafelStatus(tafel, status);
            }

            catch (Exceptions.NetworkProblemException)
            {
                throw new Exceptions.NetworkProblemException();
            }
        
        }

        public void MaakGroepKlantenEnRekeningAan(Tafel tafel, Werknemer werknemer, int aantalPersonen)
        {
            //maak een rekening aan
            DAL.TafelOverzichtDaO.Instance.MaakRekeningAan();

            int hoogsteRekeningsId = DAL.TafelOverzichtDaO.Instance.VindHoogsteRekeningsId();
            // zet groepsid op hoogste rekeningsid
            // zet rekeningsid goed
            //check werknemerId
            //check tafelId
            //insert groep klanten sql
            DAL.TafelOverzichtDaO.Instance.MaakGroepKlantenAan(werknemer, tafel, aantalPersonen, hoogsteRekeningsId);

        }


    }

    //          ==========================
    //                  Barman
    //          ==========================

    public class Barman_Logica
    {
        //Singleton
        private Barman_Logica() { }
        private static Barman_Logica instance;
        public static Barman_Logica Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Barman_Logica();
                }
                return instance;
            }
        }

        public void meldGereed(BestellingItem bestellingItem)
        {
            try
            {
                Barman_DAL.Instance.meldBestellingKlaar(bestellingItem);
            }

            catch (Exceptions.NetworkProblemException)
            {
                throw new Exceptions.NetworkProblemException();
            }
        }

        public void meldOnGereed(BestellingItem bestellingItem)
        {
            try
            {
                Barman_DAL.Instance.meldBestellingOnKlaar(bestellingItem);
            }

            catch (Exceptions.NetworkProblemException)
            {
                throw new Exceptions.NetworkProblemException();
            }
        }
    }

    //          ==========================
    //                  keuken
    //          ==========================

    public class Keuken_Logica
    {
        //Singleton
        private Keuken_Logica() { }
        private static Keuken_Logica instance;
        public static Keuken_Logica Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Keuken_Logica();
                }
                return instance;
            }
        }

        public void meldGereed(BestellingItem bestellingItem)
        {
            try
            {
                Keuken_DAL.Instance.meldBestellingKlaar(bestellingItem);
            }

            catch (Exceptions.NetworkProblemException)
            {
                throw new Exceptions.NetworkProblemException();
            }
        }

        public void meldOnGereed(BestellingItem bestellingItem)
        {
            try
            {
                Keuken_DAL.Instance.meldBestellingOnKlaar(bestellingItem);
            }

            catch (Exceptions.NetworkProblemException)
            {
                throw new Exceptions.NetworkProblemException();
            }
        }
    }


    public class Bestelling
    {
        DAL.Bestelling_DAL data = new DAL.Bestelling_DAL();
        public void Check_gegevens(int tafel, int item, int aantal)
        {


            if (data.Check_data(tafel, item))
            {
                data.Update(tafel, item, aantal);
            }
            else
            {
                data.Insert(tafel, item, aantal);
            }
        }

        public void Verwijder_gegevens(int tafel)
        {

            data.Delete(tafel);


        }
        public void Maak_BestelLijst(int tafel, int item, int aantal)
        {

        }
        public void Open_BestelLijst()
        {

        }

    }
    public class MenuItem
    {

        DAL.MenuItem_Dal data = new DAL.MenuItem_Dal();

        public List<Model.MenuItem> NummerGerecht(int Categorie)
        {
            List<Model.MenuItem> MenuLijst = data.DB_GetMenuItems(Categorie);


            return MenuLijst;
        }
    }

    public class ConsumptieLogica
    {

        private BesteldeConsumpties_DAL consumpties = new BesteldeConsumpties_DAL();
        public List<BesteldeConsumpties> ConsumptieLijst(int tafelNummer)
        {
            RekeningLogica RekeningLogica = new RekeningLogica();
            List<BesteldeConsumpties> lijst = consumpties.DB_getRekeningen(RekeningLogica.haalRekeningId(tafelNummer));
            return lijst;
        }
    }

    public class RekeningLogica
    {

        private Rekening_DAL rekeningDb = new Rekening_DAL();

        //globaal int om ander te laten gebruiken
        public int tafelId = 0;

        //methode om van rekeningId op te halen van tafel Id
        public int haalRekeningId(int tafel)
        {
            //probeerde hier de waarde van de tafel om te zetten naar de parameter die binnen kwam.
            tafelId = tafel;
            int rekeningId = rekeningDb.Get_rekeningId(tafel);
            return rekeningId;
        }


        protected ConsumptieLogica logic = new ConsumptieLogica();
        public decimal btwHoog(List<BesteldeConsumpties> lijst)
        {
            decimal btw = 0;

            for (int i = 0; i < lijst.Count; i++)
            {
                if (lijst[i].CategorieId == Enums.MenuItemCategorieId.Alcoholische_Dranken)
                {
                    btw += (lijst[i].Prijs * lijst[i].Aantal) * lijst[i].Btw;
                }
                else
                {
                    btw += 0;
                }
            }
            return btw;
        }

        public decimal btwLaag(List<BesteldeConsumpties> lijst)
        {
            decimal btw = 0;
            for (int i = 0; i < lijst.Count; i++)
            {
                if (lijst[i].CategorieId != Enums.MenuItemCategorieId.Alcoholische_Dranken)
                {
                    btw += (lijst[i].Prijs * lijst[i].Aantal) * lijst[i].Btw;
                }
                else
                {
                    btw += 0;
                }
            }
            return btw;
        }

        protected decimal brutoPrijs(List<BesteldeConsumpties> lijst)
        {
            decimal brutoPrijs = 0;
            for (int i = 0; i < lijst.Count; i++)
            {
                brutoPrijs += lijst[i].Aantal * lijst[i].Prijs;
            }
            return brutoPrijs;
        }

        public decimal totaalPrijs(List<BesteldeConsumpties> lijst)
        {
            RekeningLogica rekeningLogica = new RekeningLogica();
            decimal nettoPrijs = 0;
            nettoPrijs += rekeningLogica.brutoPrijs(lijst) + rekeningLogica.btwHoog(lijst) + rekeningLogica.btwLaag(lijst);
            return nettoPrijs;
        }

        public void rekeningOpslaan(int betaalwijze, List<BesteldeConsumpties> lijst)
        {
            Rekening_DAL rekeningOpslaanDb = new Rekening_DAL();
            RekeningLogica logic = new RekeningLogica();
            ConsumptieLogica consumptieLogica = new ConsumptieLogica();
            rekeningOpslaanDb.InsertRekening(haalRekeningId(tafelId), betaalwijze, logic.totaalPrijs(lijst));
        }
        public void rekeningFooi(decimal fooi)
        {
            Rekening_DAL fooiDb = new Rekening_DAL();
            ConsumptieLogica consumptieLogica = new ConsumptieLogica();
            fooiDb.InsertFooi(haalRekeningId(tafelId), fooi);
        }
    }
}
