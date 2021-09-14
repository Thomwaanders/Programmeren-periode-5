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
            
            if (objBalk.Iskubus == true)
            {
                kubusBalk = "Kubus";
            }
            else
                kubusBalk = "Balk";

            txtBon.Text = "";

            txtBon.Text = "Klant: " + Environment.NewLine
                + txtVoornaam.Text + " " + txtTussenvoegsel.Text + " " + txtAchternaam.Text + Environment.NewLine
                + txtAdres.Text + Environment.NewLine
                + txtPostcode.Text + Environment.NewLine + Environment.NewLine
                + "Bestelling: " + kubusBalk + "vormige bloembak" + Environment.NewLine
                + "Lengte: " + txtLengte.Text + " cm" + Environment.NewLine
                + "Breedte: " + txtBreedte.Text + " cm" + Environment.NewLine
                + "Hoogte: " + txtHoogte.Text + " cm" + Environment.NewLine + Environment.NewLine
                + "Inhoud bloembak: " + objBalk.Volume + " m3";
        }
    }
}
