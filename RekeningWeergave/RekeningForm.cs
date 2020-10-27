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
using DAL;
using Logica;


namespace RekeningWeergave
{
    public partial class RekeningForm : Form
    {
        private Tafel doorgegevenTafel = null;
        private List<BesteldeConsumpties> besteldeConsumptieLijst = null;




        public RekeningForm(Tafel tafel)
        {
            InitializeComponent();
            doorgegevenTafel = tafel;

            lblTafelnummer.Text = "Tafel: " + doorgegevenTafel.TafelNummer;

            ConsumptieLogica logic = new ConsumptieLogica();
            besteldeConsumptieLijst = logic.ConsumptieLijst(doorgegevenTafel.TafelNummer);
            IntitListview();
            Bedragen();
            Betaal();


        }


        private void IntitListview()
        {
            lvRekening.Columns.Add("Consumptie", lvRekening.ClientSize.Width / 3 );
            lvRekening.Columns.Add("Aantal", lvRekening.ClientSize.Width / 3);
            lvRekening.Columns.Add("Prijs", lvRekening.ClientSize.Width / 3 - 17);

            for (int i = 0; i < besteldeConsumptieLijst.Count; i++)
            {
                ListViewItem li = new ListViewItem(besteldeConsumptieLijst[i].Consumptie.ToString(), 0);
                li.SubItems.Add(besteldeConsumptieLijst[i].Aantal.ToString());
                li.SubItems.Add((besteldeConsumptieLijst[i].Prijs * besteldeConsumptieLijst[i].Aantal).ToString("€0.00"));
                lvRekening.Items.Add(li);
            }
        }


        private void Bedragen()
        {
            RekeningLogica rekeninigLogic = new RekeningLogica();
            lblBtwHoog.Text = rekeninigLogic.btwHoog(besteldeConsumptieLijst).ToString("€0.00");
            lblBtwLaag.Text = rekeninigLogic.btwLaag(besteldeConsumptieLijst).ToString("€0.00");
            lblTotaalprijs.Text = rekeninigLogic.totaalPrijs(besteldeConsumptieLijst).ToString("€0.00");
        }


        private void Betaal()
        {
            cbBetaalwijze.DataSource = Enum.GetValues(typeof(Enums.BetaalWijze));
        }

        //zorgt ervoor dat er geen tekst in gevoerd kunnen worden in textbox.
        private void txtFooi_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                                 (e.KeyChar != ','))
            {
                e.Handled = true;
            }
            if ((e.KeyChar == ',') && ((sender as TextBox).Text.IndexOf(',') > -1))
            {
                e.Handled = true;
            }
            //zorgt ervoor dat er twee getallen na de punt ingevoerd mag worden en staat toe dat je backspace mag doen
            if (System.Text.RegularExpressions.Regex.IsMatch(txtFooi.Text, @"\,\d\d") && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }


        private void btnBetalen_Click(object sender, EventArgs e)
        {

            RekeningLogica rekeningLogica = new RekeningLogica();
            List<BesteldeConsumpties> lijst = besteldeConsumptieLijst;
            int rekeningId = rekeningLogica.haalRekeningId(doorgegevenTafel.TafelNummer);
            decimal fooi = 0;

            Enums.BetaalWijze betaalWijzeTekst = (Enums.BetaalWijze)Enum.Parse(typeof(Enums.BetaalWijze), cbBetaalwijze.SelectedValue.ToString());
            int betaalWijzeWaarde = (int)betaalWijzeTekst;

            rekeningLogica.rekeningOpslaan(betaalWijzeWaarde, lijst);
            if (!(string.IsNullOrEmpty(txtFooi.Text)))
            {
                fooi = Convert.ToDecimal(txtFooi.Text);
                rekeningLogica.rekeningFooi(fooi);
            }

            //na afrekenen tafel weer onbezet melden
            TafelOverzicht.Instance.VeranderTafelStatus(doorgegevenTafel, 0);

            if (MessageBox.Show("Rekening is afgehandeld.", "Rekening", MessageBoxButtons.OK) == DialogResult.OK)
            {
                this.Close();
            }

        }


        private void btnUitloggen_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void btnTerug_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
