using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model;
using Logica;

namespace Bestelling_Bevestigen
{
    public partial class Form1 : Form
    {
        public List<Model.MenuItem> doorgegevenLijst = null;

        public Tafel doorgegevenTafel = null;

        public Form1(List<Model.MenuItem> menuItemLijst, Tafel tafel)
        {

            InitializeComponent();

            doorgegevenLijst = menuItemLijst;
            doorgegevenTafel = tafel;

            tafel_nummer.Text = "Tafel: " + doorgegevenTafel.TafelNummer;

            ShowBestellingenLijst();
        }
        public ListView ShowBestellingenLijst()
        {
            DAL.Bestelling_DAL data = new DAL.Bestelling_DAL();

            Bestellingen_lijst.FullRowSelect = true;
            Bestellingen_lijst.Scrollable = true;
            Bestellingen_lijst.GridLines = true;
            Bestellingen_lijst.MultiSelect = false;
            Bestellingen_lijst.View = View.Details;

            Bestellingen_lijst.Items.Clear();

            foreach (Model.MenuItem bestellingItem in doorgegevenLijst)
            {
                ListViewItem listViewItem = new ListViewItem(bestellingItem.BestellingNaam);
                listViewItem.SubItems.Add(bestellingItem.Aantal.ToString());

                listViewItem.Tag = bestellingItem;

                Bestellingen_lijst.Items.Add(listViewItem);
            }

            return Bestellingen_lijst;

        }

        private void BarmanForm_Load(object sender, EventArgs e)
        {



        }
      
        private void Bevestig_button_Click(object sender, EventArgs e)
        {

            Logica.MenuItem menu = new Logica.MenuItem();
            Logica.Bestelling bestelling = new Logica.Bestelling();

            foreach (Model.MenuItem bestellingItem in doorgegevenLijst)
            {                
                bestelling.Check_gegevens(doorgegevenTafel.TafelNummer, bestellingItem.BestellingId, bestellingItem.Aantal);
            }

            //indien de tafel nog niet besteld heeft, verander de status naar besteld
            if (doorgegevenTafel.TafelStatus == 1)
            {
                TafelOverzicht.Instance.VeranderTafelStatus(doorgegevenTafel, 2);
            }

            if (MessageBox.Show("De bestelling is afgehandeld.", "Bestelling", MessageBoxButtons.OK) == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

