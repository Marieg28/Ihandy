namespace Accueil
{
    partial class PlacementForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PlacementForm));
            this.pictureBox_retourAcc = new System.Windows.Forms.PictureBox();
            this.lbl_titre = new System.Windows.Forms.Label();
            this.pictureBox_electrode = new System.Windows.Forms.PictureBox();
            this.btn_voirEtap = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_retourAcc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_electrode)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox_retourAcc
            // 
            this.pictureBox_retourAcc.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_retourAcc.Image")));
            this.pictureBox_retourAcc.Location = new System.Drawing.Point(0, 0);
            this.pictureBox_retourAcc.Name = "pictureBox_retourAcc";
            this.pictureBox_retourAcc.Size = new System.Drawing.Size(54, 49);
            this.pictureBox_retourAcc.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_retourAcc.TabIndex = 1;
            this.pictureBox_retourAcc.TabStop = false;
            // 
            // lbl_titre
            // 
            this.lbl_titre.AutoSize = true;
            this.lbl_titre.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titre.Location = new System.Drawing.Point(225, 81);
            this.lbl_titre.Name = "lbl_titre";
            this.lbl_titre.Size = new System.Drawing.Size(264, 31);
            this.lbl_titre.TabIndex = 2;
            this.lbl_titre.Text = "Placement des électrodes";
            // 
            // pictureBox_electrode
            // 
            this.pictureBox_electrode.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_electrode.Image")));
            this.pictureBox_electrode.Location = new System.Drawing.Point(245, 158);
            this.pictureBox_electrode.Name = "pictureBox_electrode";
            this.pictureBox_electrode.Size = new System.Drawing.Size(207, 187);
            this.pictureBox_electrode.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_electrode.TabIndex = 3;
            this.pictureBox_electrode.TabStop = false;
            // 
            // btn_voirEtap
            // 
            this.btn_voirEtap.Location = new System.Drawing.Point(278, 396);
            this.btn_voirEtap.Name = "btn_voirEtap";
            this.btn_voirEtap.Size = new System.Drawing.Size(133, 23);
            this.btn_voirEtap.TabIndex = 4;
            this.btn_voirEtap.Text = "Voir les étapes ";
            this.btn_voirEtap.UseVisualStyleBackColor = true;
            this.btn_voirEtap.Click += new System.EventHandler(this.btn_voirEtap_Click);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(173, 477);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(708, 574);
            this.panel1.TabIndex = 5;
            // 
            // PlacementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(708, 574);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_voirEtap);
            this.Controls.Add(this.pictureBox_electrode);
            this.Controls.Add(this.lbl_titre);
            this.Controls.Add(this.pictureBox_retourAcc);
            this.Name = "PlacementForm";
            this.Text = "PlacementForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_retourAcc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_electrode)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox_retourAcc;
        private System.Windows.Forms.Label lbl_titre;
        private System.Windows.Forms.PictureBox pictureBox_electrode;
        private System.Windows.Forms.Button btn_voirEtap;
        private System.Windows.Forms.Panel panel1;
    }
}