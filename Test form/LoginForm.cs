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
using OberTafeloverzicht;
using Keuken_Kok;
using BarmanForm;

namespace Test_form
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }


        

        private void btn_inloggen_Click(object sender, EventArgs e)
        {
            string inlogcode = Tbx_Inlogveld.Text.ToString(); //input 

            Tbx_Inlogveld.Clear(); 

            try 
            {
                // check of ingevoerde code correct is
                // methode returnt een werknemer, lege werknemer betekend ongeldige code
                Werknemer ingelogdeWerknemer = Inloggen.Instance.ValideerInloggen(inlogcode);            
                
                if (ingelogdeWerknemer == null)
                {
                    System.Windows.Forms.MessageBox.Show("Inlogcode incorrect.");
                }
                else
                {
                    //check het type gebruiker dat ingelogd heeft
                    switch (ingelogdeWerknemer.WerknemersType)
                    {
                        case Enums.WerknemersType.Barman:
                            BarmanForm.BarmanForm barmanForm = new BarmanForm.BarmanForm();
                            this.Hide();
                            barmanForm.ShowDialog();
                            this.Visible = true;
                            break;

                        case Enums.WerknemersType.Kok:
                            KeukenForm keukenForm = new KeukenForm();
                            this.Hide();
                            keukenForm.ShowDialog();
                            this.Visible = true;
                            break;

                        case Enums.WerknemersType.Ober:

                            OberTafelOverzichtForm oberTafelOverzichtForm = new OberTafelOverzichtForm(ingelogdeWerknemer);
                            this.Hide();
                            oberTafelOverzichtForm.ShowDialog();
                            this.Visible = true;
                            break;

                        default: //indien het type geen van de verwachte types is geef dit door aan gebruiker
                            throw new Exceptions.DatabaseErrorException();
                    }
                }

            }

            
            //ww correct, maar onverwacht probleem met de data in de db 
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
    }
}
