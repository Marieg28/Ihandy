using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Accueil
{
    public partial class PlacementForm : Form
    {
        public static Panel etape1;
        public PlacementForm()
        {
            InitializeComponent();
            WindowState = FormWindowState.Maximized;

        }

        private void btn_voirEtap_Click(object sender, EventArgs e)
        {
            //Critère du panel 
            etape1 = new Panel();
            etape1.AutoSize = true; 
            etape1.BackColor = Color.White;
            etape1.Location = new Point(0, 0);
            etape1.Size = new Size();
            etape1.BringToFront();

            //Critère label 
            Label lblTitrePart1 = new Label();
            lblTitrePart1.Text = "Etape 1/4";

            Label lblAjoutElec = new Label();
            lblAjoutElec.Text = "1- Ajoutez une électrode à chacun \n des 3 connecteurs du capteur.";

            Label lblElevOpercule = new Label();
            lblElevOpercule.Text = "2- Retirez la pélicule papier des 2 électrodes \n placées sur le circuit imprimé";


            //Critère images
            PictureBox imgAjoutElec = new PictureBox();
            //imgAjoutElec.Image = Image.FromFile("\\Image/MyoWare_P1_1.jpg");
            imgAjoutElec.Location = new Point(250,250);


            PictureBox imgElevOpercule = new PictureBox();
           // imgElevOpercule.Image = Image.FromFile("MyoWare_P1_2.jpg");
            imgElevOpercule.Location = new Point(1000, 250);

            Controls.Add(etape1);
            etape1.Controls.Add(imgAjoutElec);
            etape1.Controls.Add(imgElevOpercule);





        }
    }
 }
