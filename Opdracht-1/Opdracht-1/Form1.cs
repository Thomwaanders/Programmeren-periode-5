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
            }
            
            if(txtVoornaam.Text == "" || txtAchternaam.Text == "" || txtAdres.Text == "" || txtPostcode.Text == "")
            {
                MessageBox.Show("Vul alle velden in!");
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
            
            if (radioButton1.Checked)
            {
                kubusBalk = "cilinder";
                uitkomst = "Inhoud bloembak: " + objCilinder.cilinderVolume + "m3";
            } else if (objBalk.Iskubus == true)
            {
                kubusBalk = "kubus";
                uitkomst = "Inhoud bloembak: " + objBalk.Volume + "m3";
            }
            else
            {
                kubusBalk = "balk";
                uitkomst = "Inhoud bloembak: " + objBalk.Volume + "m3";
            }


            txtBon.Text = "Klant: " + Environment.NewLine
                + txtVoornaam.Text + " " + txtTussenvoegsel.Text + " " + txtAchternaam.Text + Environment.NewLine
                + txtAdres.Text + Environment.NewLine
                + txtPostcode.Text + Environment.NewLine + Environment.NewLine
                + "Bestelling: " + kubusBalk + "vormige bloembak" + Environment.NewLine
                + "Lengte: " + txtLengte.Text + " cm" + Environment.NewLine
                + "Breedte: " + txtBreedte.Text + " cm" + Environment.NewLine
                + "Hoogte: " + txtHoogte.Text + " cm" + Environment.NewLine + Environment.NewLine
                + uitkomst;
               

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                txtLengte.Enabled = false;
            }
        }
    }
}
