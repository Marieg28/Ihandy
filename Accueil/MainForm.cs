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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            WindowState = FormWindowState.Maximized;
            lbl_Bvn.Font = new Font("Arial", 30, FontStyle.Bold);
        }



        private void btn_clb_Click(object sender, EventArgs e)
        {
            CalibrageForm clbForm = new CalibrageForm();
            Hide();
            clbForm.ShowDialog();
            Close();

        }

        private void btn_jeu_Click(object sender, EventArgs e)
        {

        }

        private void link_info_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Info infoForm = new Info();
            if (infoForm.ShowDialog() == DialogResult.OK)
            {
                // Faire apparaitre les participants
                //participantForm.
                //foreach (Participant participant in selectedCourse.Participants)
            }

        }
    }
}
