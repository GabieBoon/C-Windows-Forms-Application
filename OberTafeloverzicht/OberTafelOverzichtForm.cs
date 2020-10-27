using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Logica;
using Model;
using Bediening;
using RekeningWeergave;


namespace OberTafeloverzicht
{
    public partial class OberTafelOverzichtForm : Form
    {
        public ListView TeBeZorgen;

        public Button[] buttonLijst;

        public Tafel aangeklikteTafel;
        public Werknemer ingelogdeWerknemer;

        public List<TeBezorgenBestelling> bezorgdeBestellingen = new List<TeBezorgenBestelling>();

        public OberTafelOverzichtForm(Werknemer doorgegevenWerknemer)
        {
            //init form
            InitializeComponent();            

            ingelogdeWerknemer = doorgegevenWerknemer;

            //haal informatie op 
            List<Tafel> tafelLijst = null;

            try
            {
                tafelLijst = TafelOverzicht.Instance.HaalTafelInformatie();
            }
            catch (Exceptions.DatabaseErrorException)
            {
                System.Windows.Forms.MessageBox.Show("Fout in de database. Neem contact op met de administrator.");
            }
            //probleem met de internetverbinding
            catch (Exceptions.NetworkProblemException)
            {
                System.Windows.Forms.MessageBox.Show("Er is een probleem met de internetverbinding.");
            }

            //maak een array voor alle buttons 
            buttonLijst = new Button[tafelLijst.Count];
            int tafelTeller = 1;

            //positie van de tafelbuttons
            int positieKolom1 = 90;
            int positieKolom2 = 255;
            int beginY = 10;
            int verschilInY = 75;

            // maak alle tafelbuttons aan
            foreach (Tafel tafel in tafelLijst)
            {
                int positieX = 0;
                Button TafelButton = new Button();

                //plaats de button op de juiste plek

                if (tafelTeller % 2 == 1) //zorgt voor button links, dan rechts, weer links etc.
                {
                    positieX = positieKolom1;
                }
                else
                {
                    positieX = positieKolom2;
                }

                //bereken het regelnummer
                int regelNummer = tafelTeller / 2 + (tafelTeller%2);
                
                //bereken de preciese positie van de button mbv voorgaande regels
                TafelButton.Location = new System.Drawing.Point(positieX, (regelNummer * verschilInY + beginY) );

                //Tag om tafelinformatie aan de button te kunnen koppelen
                TafelButton.Tag = tafel;
                TafelButton.Text = "" + tafel.TafelNummer;

                // geef de tafel een kleurtje
                switch (tafel.TafelStatus)
                {
                    case 0:
                        TafelButton.BackColor = Color.Green;
                        break;
                    case 1:
                        TafelButton.BackColor = Color.OrangeRed;
                        break;
                    case 2:
                        TafelButton.BackColor = Color.Red;
                        break;
                }

                TafelButton.ForeColor = Color.White;


                //koppel de button aan de eventhandler
                TafelButton.Click += new EventHandler(TafelButton_Click);

                //voeg de button toe aan de array en de controls
                TafelOverzichtPanel.Controls.Add(TafelButton);
                buttonLijst[tafelTeller - 1] = TafelButton;

                tafelTeller++;
            }

            TeBeZorgen = new ListView();
            TeBeZorgen.Height = 480;
            TeBeZorgen.Width = 440;
            TeBeZorgen.Location = new Point(10, 10);            
            TeBeZorgen.View = View.Details;
            TeBeZorgen.GridLines = true;
            TeBeZorgen.FullRowSelect = true;
            TeBeZorgen.MultiSelect = false;

            TeBeZorgen.Columns.Add("Tafel", -2, HorizontalAlignment.Left);
            TeBeZorgen.Columns.Add("Item", 175, HorizontalAlignment.Left);
            TeBeZorgen.Columns.Add("Aantal", -2, HorizontalAlignment.Left);
            TeBeZorgen.Columns.Add("Ophaalplaats", -2, HorizontalAlignment.Left);
            //TeBezorgen.Columns.Add("Bezorgt", -2, HorizontalAlignment.Left);
            TeBeZorgen.Scrollable = true;

            BestellingenKlaar.Controls.Add(TeBeZorgen);
            

            //haal data op inc errors

            // vul de listview met een foreach loop
            List<TeBezorgenBestelling> teBezorgenBestellingenLijst = null;

            try
            {
                teBezorgenBestellingenLijst = TafelOverzicht.Instance.HaalTeBezorgenBestellingen(ingelogdeWerknemer);
            }
            catch (Exceptions.DatabaseErrorException)
            {
                //throw new Exceptions.DatabaseErrorException();
            }
            catch (Exceptions.NetworkProblemException)
            {
                //throw new Exceptions.NetworkProblemException();
            }

            foreach (TeBezorgenBestelling teBezorgenBestelling in teBezorgenBestellingenLijst)
            {
                ListViewItem listViewItem = new ListViewItem(teBezorgenBestelling.TafelNummer.ToString());
                listViewItem.SubItems.Add(teBezorgenBestelling.Item);
                listViewItem.SubItems.Add(teBezorgenBestelling.Aantal.ToString());
                listViewItem.SubItems.Add(teBezorgenBestelling.Ophaalplaats.ToString());

                listViewItem.Tag = teBezorgenBestelling;

                TeBeZorgen.Items.Add(listViewItem);
            }


            

            // maak een timer die om de 10 sec de Update methode aanroept
            System.Windows.Forms.Timer updateTimer = new System.Windows.Forms.Timer();
            updateTimer.Tick += (sender, e) => Update(sender, e, ingelogdeWerknemer, TeBeZorgen);
            updateTimer.Interval = 5000; //in milliseconden
            updateTimer.Enabled = true;
            
            //System.Windows.Forms.Timer != System.Timers.Timer
        }

        //Update de kleur van de tafels elke 10 sec
        private void Update(object sender, EventArgs e, Werknemer werknemer, ListView listView)
        {
            UpdateTafelOverzicht();

            UpdateBestellingen(werknemer, listView);          
        }

        public void UpdateTafelOverzicht()
        {
            int tafelTeller = 0;

            List<Tafel> tafelLijst = null;

            try
            {
                tafelLijst = TafelOverzicht.Instance.HaalTafelInformatie();

                foreach (Tafel tafel in tafelLijst)
                {
                    switch (tafel.TafelStatus)
                    {
                        case 0:
                            buttonLijst[tafelTeller].BackColor = Color.Green;
                            break;
                        case 1:
                            buttonLijst[tafelTeller].BackColor = Color.OrangeRed;
                            break;
                        case 2:
                            buttonLijst[tafelTeller].BackColor = Color.Red;
                            break;
                    }

                    buttonLijst[tafelTeller].Tag = tafel;


                    tafelTeller++;
                }
            }
            catch (Exceptions.DatabaseErrorException)
            {
                System.Windows.Forms.MessageBox.Show("Fout in de database. Neem contact op met de administrator.");
            }
            //probleem met de internetverbinding
            catch (Exceptions.NetworkProblemException)
            {

                System.Windows.Forms.MessageBox.Show("Er is een probleem met de internetverbinding.");
            }
        }

        public void UpdateBestellingen(Werknemer werknemer, ListView listView)
        {
            List<TeBezorgenBestelling> teBezorgenBestellingenLijst = null;

            try
            {
                teBezorgenBestellingenLijst = TafelOverzicht.Instance.HaalTeBezorgenBestellingen(werknemer);

                TeBezorgenBestelling geselecteerdebestelling = null;

                if (listView.SelectedItems.Count != 0)
                {
                     geselecteerdebestelling = (TeBezorgenBestelling)listView.SelectedItems[0].Tag;

                }

                listView.Items.Clear();

                foreach (TeBezorgenBestelling teBezorgenBestelling in teBezorgenBestellingenLijst)
                {
                    ListViewItem listViewItem = new ListViewItem(teBezorgenBestelling.TafelNummer.ToString());
                    listViewItem.SubItems.Add(teBezorgenBestelling.Item);
                    listViewItem.SubItems.Add(teBezorgenBestelling.Aantal.ToString());
                    listViewItem.SubItems.Add(teBezorgenBestelling.Ophaalplaats);

                    listViewItem.Tag = teBezorgenBestelling;
                   
                    listView.Items.Add(listViewItem);

                    if (listViewItem.Tag.Equals(geselecteerdebestelling))
                    {
                        listViewItem.Focused = true;
                        listViewItem.Selected = true;
                        listViewItem.EnsureVisible();
                    }
                }

            }
            catch (Exceptions.DatabaseErrorException)
            {
                System.Windows.Forms.MessageBox.Show("Fout in de database. Neem contact op met de administrator.");
            }
            catch (Exceptions.NetworkProblemException)
            {
                System.Windows.Forms.MessageBox.Show("Er is een probleem met de internetverbinding.");
            }         
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //verwijderen!
        }

        private void btn_Uitloggen_Click(object sender, EventArgs e)
        {            
            this.Close(); //ga terug naar het inlogscherm
        }

        

        private void TafelButton_Click(object sender, EventArgs e)
        {
            Tafel tafel = (Tafel)((Button)sender).Tag;

            aangeklikteTafel = tafel;

            lbl_TafelnummerToewijzen.Text = "Tafel: " + aangeklikteTafel.TafelNummer;
            lblTafelnummerMenuScherm.Text = "Tafel: " + aangeklikteTafel.TafelNummer;

            switch (tafel.TafelStatus)
            {
                case 0:
                    TafelOverzichtPanel.Visible = false;
                    BestellenRekeningPanel.Visible = false;
                    GroepklantenAanwijzenPanel.Visible = true;
                    break;
                case 1:
                    Bediening.Form1 form1 = new Form1(aangeklikteTafel);
                    this.Hide();
                    form1.ShowDialog();
                    this.Visible = true;
                    break;
                case 2:
                    TafelOverzichtPanel.Visible = false;
                    BestellenRekeningPanel.Visible = true;
                    GroepklantenAanwijzenPanel.Visible = false;
                    break;
            }

        }

        private void MeldGereed_Click(object sender, EventArgs e)
        {
            TeBezorgenBestelling teBezorgenBestelling;

            if (TeBeZorgen.SelectedItems.Count != 0)
            {
                teBezorgenBestelling = (TeBezorgenBestelling)(TeBeZorgen.SelectedItems[0]).Tag;

                Logica.TafelOverzicht.Instance.MeldStatusKlaar(teBezorgenBestelling);

                bezorgdeBestellingen.Add(teBezorgenBestelling);
            }

            UpdateBestellingen(ingelogdeWerknemer, TeBeZorgen);

            
        }

        private void Lbl_AantalPersonen_Click(object sender, EventArgs e)
        {

        }

        private void btn_Plus_Click(object sender, EventArgs e)
        {
            int aantalpersonen = Int32.Parse(lbl_AantalPersonenCijfer.Text);
            
            if (aantalpersonen < aangeklikteTafel.MaxKlanten)
            {
                aantalpersonen++;
            }
            lbl_AantalPersonenCijfer.Text = aantalpersonen.ToString();
        }

        private void btn_Min_Click(object sender, EventArgs e)
        {
            int aantalpersonen = Int32.Parse(lbl_AantalPersonenCijfer.Text);
            if (aantalpersonen > 1)
            {
                aantalpersonen--;
            }
            lbl_AantalPersonenCijfer.Text = aantalpersonen.ToString();
        }

        private void btn_TafelToewijzen_Click(object sender, EventArgs e)
        {
            try
            {
                Logica.TafelOverzicht.Instance.VeranderTafelStatus(aangeklikteTafel, 1);

                UpdateTafelOverzicht();
            }
            
            catch (Exceptions.NetworkProblemException)
            {
                System.Windows.Forms.MessageBox.Show("Er is een probleem met de internetverbinding.");
            }


            Logica.TafelOverzicht.Instance.MaakGroepKlantenEnRekeningAan(aangeklikteTafel, ingelogdeWerknemer, Int32.Parse(lbl_AantalPersonenCijfer.Text));

            TafelOverzichtPanel.Visible = true;
            GroepklantenAanwijzenPanel.Visible = false;

            UpdateTafelOverzicht();
        }

        private void btn_Terug_Click(object sender, EventArgs e)
        {
            TafelOverzichtPanel.Visible = true;
            GroepklantenAanwijzenPanel.Visible = false;
        }

        private void btn_Bestellen_Click(object sender, EventArgs e)
        {
            Bediening.Form1 form1 = new Form1(aangeklikteTafel);
            this.Hide();
            form1.ShowDialog();
            this.Visible = true;

            TafelOverzichtPanel.Visible = true;
            BestellenRekeningPanel.Visible = false;
            GroepklantenAanwijzenPanel.Visible = false;
        }

        private void btn_Afrekenen_Click(object sender, EventArgs e)
        {
            RekeningForm rekeningForm = new RekeningForm(aangeklikteTafel);
            this.Hide();
            rekeningForm.ShowDialog();
            this.Visible = true;

            TafelOverzichtPanel.Visible = true;
            BestellenRekeningPanel.Visible = false;
            GroepklantenAanwijzenPanel.Visible = false;
        }

        private void btn_TerugTussenscherm_Click(object sender, EventArgs e)
        {
            TafelOverzichtPanel.Visible = true;
            BestellenRekeningPanel.Visible = false;
            GroepklantenAanwijzenPanel.Visible = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_OngedaanMaken_Click(object sender, EventArgs e)
        {
            if (bezorgdeBestellingen.Count != 0)
            {
                TafelOverzicht.Instance.MeldStatusOnKlaar(bezorgdeBestellingen[bezorgdeBestellingen.Count - 1]);

                bezorgdeBestellingen.RemoveAt(bezorgdeBestellingen.Count - 1);
            }

            UpdateBestellingen(ingelogdeWerknemer, TeBeZorgen);
        }
    }
}
