namespace Accueil
{
    partial class Accueil
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_Bvn = new System.Windows.Forms.Label();
            this.btn_clb = new System.Windows.Forms.Button();
            this.btn_jeu = new System.Windows.Forms.Button();
            this.link_info = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // lbl_Bvn
            // 
            this.lbl_Bvn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_Bvn.AutoSize = true;
            this.lbl_Bvn.Location = new System.Drawing.Point(204, 47);
            this.lbl_Bvn.Name = "lbl_Bvn";
            this.lbl_Bvn.Size = new System.Drawing.Size(112, 13);
            this.lbl_Bvn.TabIndex = 0;
            this.lbl_Bvn.Text = "Bienvenue sur IHandy";
            // 
            // btn_clb
            // 
            this.btn_clb.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_clb.Location = new System.Drawing.Point(207, 128);
            this.btn_clb.Name = "btn_clb";
            this.btn_clb.Size = new System.Drawing.Size(94, 23);
            this.btn_clb.TabIndex = 1;
            this.btn_clb.Text = "Calibrage";
            this.btn_clb.UseVisualStyleBackColor = true;
            this.btn_clb.Click += new System.EventHandler(this.btn_clb_Click);
            // 
            // btn_jeu
            // 
            this.btn_jeu.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_jeu.Location = new System.Drawing.Point(207, 189);
            this.btn_jeu.Name = "btn_jeu";
            this.btn_jeu.Size = new System.Drawing.Size(101, 23);
            this.btn_jeu.TabIndex = 2;
            this.btn_jeu.Text = "Entraînement";
            this.btn_jeu.UseVisualStyleBackColor = true;
            this.btn_jeu.Click += new System.EventHandler(this.btn_jeu_Click);
            // 
            // link_info
            // 
            this.link_info.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.link_info.AutoSize = true;
            this.link_info.Location = new System.Drawing.Point(204, 268);
            this.link_info.Name = "link_info";
            this.link_info.Size = new System.Drawing.Size(119, 13);
            this.link_info.TabIndex = 3;
            this.link_info.TabStop = true;
            this.link_info.Text = "Qu\'est-ce que IHandy ?";
            this.link_info.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.link_info_LinkClicked);
            // 
            // Accueil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 469);
            this.Controls.Add(this.link_info);
            this.Controls.Add(this.btn_jeu);
            this.Controls.Add(this.btn_clb);
            this.Controls.Add(this.lbl_Bvn);
            this.Name = "Accueil";
            this.Text = "IHandy";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Bvn;
        private System.Windows.Forms.Button btn_clb;
        private System.Windows.Forms.Button btn_jeu;
        private System.Windows.Forms.LinkLabel link_info;
    }
}

