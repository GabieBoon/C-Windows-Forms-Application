using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Exceptions
    {       
        public class DatabaseErrorException : Exception
        {
            public DatabaseErrorException()
            { }
        }

        public class NetworkProblemException : Exception
        {
            public NetworkProblemException()
            { }           
        }
    }

    public class Werknemer
    {
        public int WerknemersId { get; set; }
        public string Passwordhash { get; set; }
        public Enums.WerknemersType WerknemersType { get; set; }
        public string Voornaam { get; set; }
        public string Achternaam { get; set; }
    }

    public class Tafel
    {
        public int TafelNummer { get; set; }
        public int MaxKlanten { get; set; }
        public int TafelStatus { get; set; }
    }

    public class TeBezorgenBestelling
    {
        public int TafelNummer { get; set; }
        public string Item { get; set; }
        public string ophaalplaats;
        public string Ophaalplaats {
            get
            { return ophaalplaats; }
                 set{

                    switch (value)
                    {                        
                        case "1":
                        ophaalplaats = "Keuken";
                            break;
                    case "2":
                        ophaalplaats = "Keuken"; 
                        break;
                    case "3":
                        ophaalplaats = "Bar";
                        break;
                    case "4":
                        ophaalplaats = "Bar"; 
                        break;

                }

            }
        } 
        public int Aantal { get; set; }
        public int RekeningId { get; set; }
        public int ItemId { get; set; }

        public override bool Equals(object obj)
        {
            var other = obj as TeBezorgenBestelling;

            if (other == null)
            {
                return false;
            }

            if (other.Aantal != Aantal || other.Item != Item || other.ItemId != ItemId || 
                other.Ophaalplaats != Ophaalplaats || other.RekeningId != RekeningId || other.TafelNummer != TafelNummer)
            {
                return false;
            }

            return true;
        }
    }

    public class BestellingItem
    {
        public int groepId { get; set; }
        public int itemId { get; set; }
        public DateTime besteltijd;
        public int aantal;
        public string naam;
        public int tafelId;
        public int status;
        public string werknemerId;

        public void SetAantal(int dit)
        {
            aantal = dit;
        }

        public void SetNaam(string dat)
        {
            naam = dat;
        }

        public void SetBesteltijd(DateTime wat)
        {
            besteltijd = wat;
        }

        public void SetTafelId(int tafel)
        {
            tafelId = tafel;
        }

        public void SetWerknemerId(string werknemer)
        {
            werknemerId = werknemer;
        }

        public void SetStatus(int gereed)
        {
            status = gereed;
        }

        public int GetAantal()
        {
            return aantal;
        }

        public string GetNaam()
        {
            return naam;
        }

        public DateTime GetBestelTijd()
        {
            return besteltijd;
        }

        public int GetTafelId()
        {
            return tafelId;
        }

        public string GetWerknemerId()
        {
            return werknemerId;
        }

        public int GetStatus()
        {
            return status;
        }

        public override bool Equals(object obj)
        {
            var other = obj as BestellingItem;

            if (other == null)
            {
                return false;
            }

            if (other.aantal != aantal || other.besteltijd != besteltijd || other.groepId != groepId || 
                other.itemId != itemId || other.naam != naam || other.status != status || 
                other.tafelId != tafelId || other.werknemerId != werknemerId)
            {
                return false;
            }

            return true;
        }
    }

    public class Bestelling
    {
        public Bestelling(int id, string item, int aantal, int tafel)
        {
            this.rekeningId = id + 1;
            this.BestellingNaam = item;
            this.Aantal_Bestellingen = aantal;
            this.Tafel_Nummer = tafel;
        }
        public Bestelling(int id, string item)
        {
            this.BestellingId = id;
            this.BestellingNaam = item;
        }
        public int rekeningId { get; set; }
        public string BestellingNaam { get; set; }
        public int BestellingId { get; set; }
        public int Aantal_Bestellingen { get; set; }
        public int Tafel_Nummer { get; set; }

    }

    public class Rekening
    {
        public string Maaltijd;
        public int Aantal;
        public decimal Prijs;




        public void setMaaltijd(string eten)
        {
            Maaltijd = eten;
        }

        public string getMaaltijd()
        {
            return Maaltijd;
        }



        public void setAantal(int aantal)
        {
            Aantal = aantal;
        }

        public int getAantal()
        {
            return Aantal;
        }

        public void setPrijs(decimal prijs)
        {
            Prijs = prijs;
        }

        public decimal getPrijs()
        {
            return Prijs;
        }



    }

    //was beter geweest als BesteldeConsumpties en Bestelling hetzelfde waren.

    public class BesteldeConsumpties
    {
        public string Consumptie { get; set; }
        public int Aantal { get; set; }
        public decimal Prijs { get; set; }
        public Enums.MenuItemCategorieId CategorieId { get; set; }
        public decimal Btw { get; set; }

    }

    public class MenuItem
    {

        public MenuItem(int id, string item, int voorraad, int aantal)
        {
            this.BestellingId = id;
            this.BestellingNaam = item;
            this.Voorraad = voorraad;
            this.Aantal = aantal;
        }

        public MenuItem(int id, string item, int voorraad, int aantal, int type)
        {
            this.BestellingId = id;
            this.BestellingNaam = item;
            this.Voorraad = voorraad;
            this.Aantal = aantal;
            this.TypeGerecht = type;
        }

        public string BestellingNaam { get; set; }
        public int BestellingId { get; set; }
        public int Voorraad { get; set; }
        public int Aantal { get; set; }
        public int TypeGerecht { get; set; }
    }

    public class Enums
    {
        public enum WerknemersType 
        {
            Ober = 1, Barman, Kok, Eigenaar
        }

        public enum BetaalWijze
        {
            Pin = 1, Contant, Creditcard
        }

        public enum MenuItemCategorieId
        {
            Lunch = 1, Diner, Non_Alcoholische_Dranken, Alcoholische_Dranken
        }
    }
}
