using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bediening
{
    public partial class MenuElement : UserControl
    {
        public int item; // refactor naar een menu item model class
        public int tafel;
        public string naam;
        public int voorraad;
        public int aantal;
        public int typeGerecht;

        public MenuElement(int item, string naam, int voorraad, int tafel, ref int aantal, int Type)
        {
            this.item = item;
            this.tafel = tafel;
            this.naam = naam;
            this.voorraad = voorraad;
            this.aantal = aantal;
            this.typeGerecht = Type;
            InitializeComponent();
            Gerecht_verdeling(Type);
            this.label2.Text = naam;
            if (voorraad <= 0)
            {
                button2.Hide();
                button1.Hide();

                this.label1.Text = "Niet voorradig";
            }

            label3.Text = "";
        }


        private void button2_Click(object sender, EventArgs e)
        {

            this.label2.Text = naam;
            if (voorraad > 0)
            {
                if (aantal >= 1)
                {
                    aantal--;
                }
                else
                {
                    aantal = 0;
                }
                label1.Text = "" + aantal + "";

                if (label3.Text != "")
                {
                    label3.Text = "";
                }
            }
            else
            {
                MessageBox.Show("Niet voorradig");
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (voorraad > 0)
            {
                if (aantal < voorraad)
                {
                    aantal++;
                    label1.Text = "" + aantal + "";
                    
                }
                else
                {
                    label3.Text = "Gehele voorraad geselecteerd";
                }
            }
            else
            {

                MessageBox.Show("Niet voorradig");
            }
            this.label2.Text =  naam;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void bevestig_Click(object sender, EventArgs e)
        {
            Logica.Bestelling bestel = new Logica.Bestelling();


            if (voorraad > 0)
            {
                bestel.Check_gegevens(tafel, this.item, aantal);

                label2.Text = "Bevestigt";
            }
            else
            {
                MessageBox.Show("Niet voorradig");
            }

        }

        private void MenuElement_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Logica.Bestelling bestel = new Logica.Bestelling();
            //if (voorraad > 0)
            //{
            //    bestel.Verwijder_gegevens(tafel, this.item);
            //}
            //else
            //{
            //    this.label1.Text = "Voorraad is leeg";
            //}
        }

        public void Gerecht_verdeling(int type)
        {

            switch (type)
            {
                case 1:
                    this.BackColor = Color.FromArgb(211, 211, 211);
                    break;
                case 2:
                    this.BackColor = Color.SlateGray;
                    break;
                case 3:
                    this.BackColor = Color.FromArgb(169, 169, 169);
                    break;
                case 4:
                    this.BackColor = Color.FromArgb(128, 128, 128);
                    break;
                case 5:
                    this.BackColor = Color.FromArgb(211, 211, 211);
                    break;
                case 6:
                    this.BackColor = Color.FromArgb(211, 211, 211);
                    break;
                case 7:
                    this.BackColor = Color.FromArgb(169, 169, 169);
                    break;
                case 8:
                    this.BackColor = Color.FromArgb(128, 128, 128);
                    break;
                case 9:
                    this.BackColor = Color.FromArgb(128, 128, 128);
                    break;
                default:
                    this.BackColor = Color.White;
                    break;
            }
        }
    }
}
