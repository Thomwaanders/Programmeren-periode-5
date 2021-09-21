using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Opdracht_1
{
    public partial class frmOpdracht1 : Form
    {
        Balk objBalk;
        Klant objklant;
        Cilinder objCilinder;


        public frmOpdracht1()
        {
            InitializeComponent();
        }



        private void frmOpdracht1_Load(object sender, EventArgs e)
        {
           
        }
        
        


        public void btnBestel_Click(object sender, EventArgs e)
        {
            double doubleLengte;
            double.TryParse(txtLengte.Text, out doubleLengte);

            double doubleBreedte;
            double.TryParse(txtBreedte.Text, out doubleBreedte);

            double doubleHoogte;
            double.TryParse(txtHoogte.Text, out doubleHoogte);

            try
            {
                if (radioButton1.Checked)
                {
                    objCilinder = new Cilinder(doubleBreedte, doubleHoogte);
                } else
                    objBalk = new Balk(doubleLengte, doubleBreedte, doubleHoogte);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                this.Close();
            }
            
            if(txtVoornaam.Text == "" || txtAchternaam.Text == "" || txtAdres.Text == "" || txtPostcode.Text == "")
            {
                MessageBox.Show("Vul alle velden in!");
                this.Close();
            }
            else
            {
                btnBestel.Enabled = true;
                bon();
            }
             
        }



        
        void bon()
        {

            string kubusBalk;
            string uitkomst;
            string kosten;

            if(radioButton1.Checked) 
            {
                if (objCilinder.cilinderVolume <= 0.2)
                {
                    kosten = "$40";
                }
                else if (objCilinder.cilinderVolume >= 0.2 && objCilinder.cilinderVolume <= 0.4)
                {
                    kosten = "$80";
                }
                else if (objCilinder.cilinderVolume >= 0.4 && objCilinder.cilinderVolume <= 0.6)
                {
                    kosten = "$140";
                }
                else if (objCilinder.cilinderVolume >= 0.6 && objCilinder.cilinderVolume <= 0.8)
                {
                    kosten = "$210";
                }
                else
                {
                    kosten = "$250";
                }
            }
            else
            {
                if (objBalk.Volume <= 0.2)
                {
                    kosten = "$40";
                }
                else if (objBalk.Volume >= 0.2 && objBalk.Volume <= 0.4)
                {
                    kosten = "$80";
                }
                else if (objBalk.Volume >= 0.4 && objBalk.Volume <= 0.6)
                {
                    kosten = "$140";
                }
                else if (objBalk.Volume >= 0.6 && objBalk.Volume <= 0.8)
                {
                    kosten = "$210";
                }
                else
                {
                    kosten = "$250";
                }

            }

            if (radioButton1.Checked)
            {
                kubusBalk = "cilinder";
                uitkomst = "Inhoud bloembak: " + objCilinder.cilinderVolume + "m3";
                pictureBox1.Image = Properties.Resources.cilinder_vormige_pot;
            } else if (objBalk.Iskubus == true)
            {
                kubusBalk = "kubus";
                uitkomst = "Inhoud bloembak: " + objBalk.Volume + "m3";
                pictureBox1.Image = Properties.Resources.kubus;
            }
            else
            {
                kubusBalk = "balk";
                uitkomst = "Inhoud bloembak: " + objBalk.Volume + "m3";
                pictureBox1.Image = Properties.Resources.rechthoekige_pot;
            }


            txtBon.Text = "Klant: " + Environment.NewLine
                + txtVoornaam.Text + " " + txtTussenvoegsel.Text + " " + txtAchternaam.Text + Environment.NewLine
                + txtAdres.Text + Environment.NewLine
                + txtPostcode.Text + Environment.NewLine + Environment.NewLine
                + "Bestelling: " + kubusBalk + "vormige bloembak" + Environment.NewLine
                + "Lengte: " + txtLengte.Text + " cm" + Environment.NewLine
                + "Breedte: " + txtBreedte.Text + " cm" + Environment.NewLine
                + "Hoogte: " + txtHoogte.Text + " cm" + Environment.NewLine + Environment.NewLine
                + uitkomst + Environment.NewLine
                + "Pirjs van de pot: " + kosten;
               

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                txtLengte.Enabled = false;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
           
        }
    }
}
