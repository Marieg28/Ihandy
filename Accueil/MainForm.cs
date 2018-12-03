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
        public static Panel info;
        public MainForm()
        {
            InitializeComponent();
            WindowState = FormWindowState.Maximized;
            this.BackColor = Color.White;
            lbl_Bvn.BackColor = Color.White;
            lbl_Bvn.Location = new Point(50, 40);
            lbl_Bvn.Font = new Font("Arial", 30, FontStyle.Bold);
            btn_clb.Size = new Size(150, 50);
            btn_jeu.Size = new Size(150, 50);
            btn_electrode.Size = new Size(150, 50);

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
            info = new Panel();
            info.BackColor = Color.Gold;
            info.Location = new Point(250,250);
            info.Size = new Size(250, 250);
            info.AutoSize = true;
            Label lbl_info = new Label();
            lbl_info.Text = "Coucou";
            lbl_info.TextAlign = ContentAlignment.MiddleCenter;
            Controls.Add(info);
            info.BringToFront();
            info.Controls.Add(lbl_info);
        }
    }
}
