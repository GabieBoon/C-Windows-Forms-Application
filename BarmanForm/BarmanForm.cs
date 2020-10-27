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

namespace BarmanForm
{
    public partial class BarmanForm : Form
    {
        public BarmanForm()
        {
            InitializeComponent();
        }

        private void BTN_Uitloggen_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public ListView ShowBestellingenToDo()
        {
            DAL.Barman_DAL db = new DAL.Barman_DAL();

            List<Model.BestellingItem> bestellingenLijst = new List<Model.BestellingItem>(db.BestellingToDoOphalen());

            LV_Orders.FullRowSelect = true;
            LV_Orders.Scrollable = true;
            LV_Orders.GridLines = true;
            LV_Orders.MultiSelect = false;
            LV_Orders.View = View.Details;

            Model.BestellingItem geselecteerdebestelling = null;

            if (LV_Orders.SelectedItems.Count != 0)
            {
                geselecteerdebestelling = (BestellingItem)LV_Orders.SelectedItems[0].Tag;

            }

            LV_Orders.Items.Clear();

            foreach (Model.BestellingItem bestellingItem in bestellingenLijst)
            {
                ListViewItem listViewItem = new ListViewItem(bestellingItem.aantal.ToString());
                listViewItem.SubItems.Add(bestellingItem.naam);
                listViewItem.SubItems.Add(bestellingItem.besteltijd.ToString());
                listViewItem.SubItems.Add(bestellingItem.tafelId.ToString());
                listViewItem.SubItems.Add(bestellingItem.werknemerId);
                listViewItem.SubItems.Add(bestellingItem.status.ToString());

                listViewItem.Tag = bestellingItem;

                LV_Orders.Items.Add(listViewItem);

                if (listViewItem.Tag.Equals(geselecteerdebestelling))
                {
                    listViewItem.Focused = true;
                    listViewItem.Selected = true;
                    listViewItem.EnsureVisible();
                }
            }

            return LV_Orders;

        }

        public ListView ShowBestellingenDone()
        {
            DAL.Barman_DAL db = new DAL.Barman_DAL();

            List<Model.BestellingItem> bestellingenLijst = new List<Model.BestellingItem>(db.BestellingDoneOphalen());

            LV_Gereed.FullRowSelect = true;
            LV_Gereed.Scrollable = true;
            LV_Gereed.GridLines = true;
            LV_Gereed.MultiSelect = false;
            LV_Gereed.View = View.Details;

            Model.BestellingItem geselecteerdebestelling = null;

            if (LV_Gereed.SelectedItems.Count != 0)
            {
                geselecteerdebestelling = (BestellingItem)LV_Gereed.SelectedItems[0].Tag;

            }

            LV_Gereed.Items.Clear();

            foreach (Model.BestellingItem bestellingItem in bestellingenLijst)
            {
                ListViewItem listViewItem = new ListViewItem(bestellingItem.aantal.ToString());
                listViewItem.SubItems.Add(bestellingItem.naam);
                listViewItem.SubItems.Add(bestellingItem.besteltijd.ToString());
                listViewItem.SubItems.Add(bestellingItem.tafelId.ToString());
                listViewItem.SubItems.Add(bestellingItem.werknemerId);
                listViewItem.SubItems.Add(bestellingItem.status.ToString());

                listViewItem.Tag = bestellingItem;

                LV_Gereed.Items.Add(listViewItem);

                if (listViewItem.Tag.Equals(geselecteerdebestelling))
                {
                    listViewItem.Focused = true;
                    listViewItem.Selected = true;
                    listViewItem.EnsureVisible();
                }
            }

            return LV_Gereed;

        }

        private void BarmanForm_Load(object sender, EventArgs e)
        {
            LV_Orders = ShowBestellingenToDo();
            LV_Gereed = ShowBestellingenDone();

            System.Windows.Forms.Timer updateTimer = new System.Windows.Forms.Timer();
            updateTimer.Tick += (send, ea) => Update(send, ea, LV_Orders, LV_Gereed);
            updateTimer.Interval = 8000; //in milliseconden
            updateTimer.Enabled = true;
        }

        private void Update(object sender, EventArgs e, ListView LV_Orders, ListView LV_Gereed)
        {
            LV_Orders = ShowBestellingenToDo();
            LV_Gereed = ShowBestellingenDone();
        }

            private void BTN_GereedMelden_Click(object sender, EventArgs e)
        {
                foreach(ListViewItem item in LV_Orders.Items)
                {
                    if(item.Selected)
                    {
                        Model.BestellingItem bestellingItem = (Model.BestellingItem)LV_Orders.SelectedItems[0].Tag;
                        Logica.Barman_Logica.Instance.meldGereed(bestellingItem);
                    }
                }
            ShowBestellingenDone();
            ShowBestellingenToDo();
        }

        private void button1_Click(object sender, EventArgs e)      //button meld ongereed
        {
            foreach (ListViewItem item in LV_Gereed.Items)
            {
                if (item.Selected)
                {
                    Model.BestellingItem bestellingItem = (Model.BestellingItem)LV_Gereed.SelectedItems[0].Tag;
                    Logica.Barman_Logica.Instance.meldOnGereed(bestellingItem);

                }
            }
            ShowBestellingenDone();
            ShowBestellingenToDo();
        }




        // zooi
        private void LV_Orders_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }
    }
}
