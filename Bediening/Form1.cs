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

namespace Bediening
{
    public partial class Form1 : Form
    {
        //Werknemer werknemer = new Werknemer();
        // tafel nummer moet nog aangepast worden met het nummer dat je door geeft

        Logica.MenuItem menu = new Logica.MenuItem();

        public List<MenuElement> menuElementenLijst = new List<MenuElement>();

        public Tafel doorgegevenTafel = null;

        public Form1(Tafel tafel)
        {

            InitializeComponent();

            doorgegevenTafel = tafel;

            tafel_nummer.Text = "Tafel: " + doorgegevenTafel.TafelNummer;

            DrankenPanel.SelectedIndexChanged += new System.EventHandler(DrankenPanel_SelectedIndexChanged);
            pictureBox1.BackColor = Color.FromArgb(211, 211, 211);
            pictureBox2.BackColor = Color.FromArgb(169, 169, 169);
            pictureBox3.BackColor = Color.FromArgb(128, 128, 128);
            pictureBox4.BackColor = Color.SlateGray;

            label1.Text = "Voorgerecht";
            label2.Text = "Hoofdgerecht";
            label3.Text = "Nagerecht";
            label4.Text = " -- ";

            foreach (Model.MenuItem menuItem in menu.NummerGerecht(1))
            {
                int aantal = menuItem.Aantal;

                MenuElement element = new MenuElement(menuItem.BestellingId, menuItem.BestellingNaam, menuItem.Voorraad, doorgegevenTafel.TafelNummer, ref aantal, menuItem.TypeGerecht);

                this.LunchPanel.Controls.Add(element);

                menuElementenLijst.Add(element);
            }
            foreach (Model.MenuItem menuItem in menu.NummerGerecht(2))
            {
                int aantal = menuItem.Aantal;

                MenuElement element = new MenuElement(menuItem.BestellingId, menuItem.BestellingNaam, menuItem.Voorraad, doorgegevenTafel.TafelNummer, ref aantal, menuItem.TypeGerecht);

                this.DinerPanel.Controls.Add(element);

                menuElementenLijst.Add(element);
            }
            foreach (Model.MenuItem menuItem in menu.NummerGerecht(3))
            {
                int aantal = menuItem.Aantal;

                MenuElement element = new MenuElement(menuItem.BestellingId, menuItem.BestellingNaam, menuItem.Voorraad, doorgegevenTafel.TafelNummer, ref aantal, menuItem.TypeGerecht);

                this.flowLayoutPanel4.Controls.Add(element);

                menuElementenLijst.Add(element);
            }
            foreach (Model.MenuItem menuItem in menu.NummerGerecht(4))
            {
                int aantal = menuItem.Aantal;

                MenuElement element = new MenuElement(menuItem.BestellingId, menuItem.BestellingNaam, menuItem.Voorraad, doorgegevenTafel.TafelNummer, ref aantal, menuItem.TypeGerecht);

                this.AlcoholPanel.Controls.Add(element);

                menuElementenLijst.Add(element);
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void Bevestig_Button_Click(object sender, EventArgs e)
        {
            //roep methode aan vullen lijst
            //List<MenuElement> menuElements = new List<MenuElement>();
            List<Model.MenuItem> menuItemLijst = new List<Model.MenuItem>();

            foreach (MenuElement element in menuElementenLijst)
            {
                if (element.aantal > 0)
                {
                    Model.MenuItem menuItem = new Model.MenuItem(element.item, element.naam, element.voorraad, element.aantal);

                    menuItemLijst.Add(menuItem);
                }
            }



            Logica.MenuItem menu = new Logica.MenuItem();


            Bestelling_Bevestigen.Form1 form1 = new Bestelling_Bevestigen.Form1(menuItemLijst, doorgegevenTafel);
            this.Hide();
            form1.ShowDialog();

            this.Visible = true;

        }

        private void Terug_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Uitloggen_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tafel_nummer_Click(object sender, EventArgs e)
        {

        }

        

        private void DrankenPanel_SelectedIndexChanged(object sender, EventArgs e)
        {
            label1.Text = "Yes";

            switch (DrankenPanel.SelectedTab.Tag)
            {
                case "lunch":
                    label1.Text = "Voorgerecht";
                    label2.Text = "Hoofdgerecht";
                    label3.Text = "Nagerecht";
                    label4.Text = " -- ";
                    break;
                case "diner":
                    label1.Text = "Voorgerecht";
                    label2.Text = "Hoofdgerecht";
                    label3.Text = "Nagerecht";
                    label4.Text = "Tussengerecht";
                    break;
                case "dranken":
                    label1.Text = "Warme dranken";
                    label2.Text = " -- ";
                    label3.Text = "Koude dranken"; 
                    label4.Text = " -- ";
                    break;
                case "alcohol":
                    label1.Text = "Bier";
                    label2.Text = "Wijn";
                    label3.Text = "Gedestileerd";
                    label4.Text = " -- ";
                    break;               
            }

            int x = 0;
        }
    }
}
