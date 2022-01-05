
namespace GestionEmploye.WinForms
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.pan_Header = new System.Windows.Forms.Panel();
            this.lbl_GestionEmploye = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pan_Content = new System.Windows.Forms.Panel();
            this.split_PanContent = new System.Windows.Forms.SplitContainer();
            this.listBox_ListeEmployes = new System.Windows.Forms.ListBox();
            this.pnl_Rafraichir = new System.Windows.Forms.Panel();
            this.btn_rafraichir = new System.Windows.Forms.Button();
            this.pnl_Detail = new System.Windows.Forms.Panel();
            this.btn_Sauvegarder = new System.Windows.Forms.Button();
            this.chkBox_EstPiloteDeLigne = new System.Windows.Forms.CheckBox();
            this.cmbBox_ListeRoles = new System.Windows.Forms.ComboBox();
            this.lbl_Role = new System.Windows.Forms.Label();
            this.dtpick_DateEmbauche = new System.Windows.Forms.DateTimePicker();
            this.lbl_DateEmbauche = new System.Windows.Forms.Label();
            this.lbl_Prenom = new System.Windows.Forms.Label();
            this.txtBx_Prenom = new System.Windows.Forms.TextBox();
            this.txtBx_Nom = new System.Windows.Forms.TextBox();
            this.lbl_Nom = new System.Windows.Forms.Label();
            this.bs_Employes = new System.Windows.Forms.BindingSource(this.components);
            this.pan_Header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pan_Content.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.split_PanContent)).BeginInit();
            this.split_PanContent.Panel1.SuspendLayout();
            this.split_PanContent.Panel2.SuspendLayout();
            this.split_PanContent.SuspendLayout();
            this.pnl_Rafraichir.SuspendLayout();
            this.pnl_Detail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bs_Employes)).BeginInit();
            this.SuspendLayout();
            // 
            // pan_Header
            // 
            this.pan_Header.BackColor = System.Drawing.Color.OrangeRed;
            this.pan_Header.Controls.Add(this.lbl_GestionEmploye);
            this.pan_Header.Controls.Add(this.pictureBox1);
            this.pan_Header.Dock = System.Windows.Forms.DockStyle.Top;
            this.pan_Header.Location = new System.Drawing.Point(0, 0);
            this.pan_Header.Name = "pan_Header";
            this.pan_Header.Size = new System.Drawing.Size(982, 150);
            this.pan_Header.TabIndex = 0;
            // 
            // lbl_GestionEmploye
            // 
            this.lbl_GestionEmploye.AutoSize = true;
            this.lbl_GestionEmploye.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_GestionEmploye.Location = new System.Drawing.Point(333, 37);
            this.lbl_GestionEmploye.Name = "lbl_GestionEmploye";
            this.lbl_GestionEmploye.Size = new System.Drawing.Size(510, 67);
            this.lbl_GestionEmploye.TabIndex = 1;
            this.lbl_GestionEmploye.Text = "Gestion des employes";
            this.lbl_GestionEmploye.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(224, 150);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pan_Content
            // 
            this.pan_Content.Controls.Add(this.split_PanContent);
            this.pan_Content.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pan_Content.Location = new System.Drawing.Point(0, 150);
            this.pan_Content.Name = "pan_Content";
            this.pan_Content.Size = new System.Drawing.Size(982, 595);
            this.pan_Content.TabIndex = 1;
            // 
            // split_PanContent
            // 
            this.split_PanContent.Cursor = System.Windows.Forms.Cursors.VSplit;
            this.split_PanContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.split_PanContent.Location = new System.Drawing.Point(0, 0);
            this.split_PanContent.Name = "split_PanContent";
            // 
            // split_PanContent.Panel1
            // 
            this.split_PanContent.Panel1.Controls.Add(this.listBox_ListeEmployes);
            this.split_PanContent.Panel1.Controls.Add(this.pnl_Rafraichir);
            this.split_PanContent.Panel1MinSize = 250;
            // 
            // split_PanContent.Panel2
            // 
            this.split_PanContent.Panel2.Controls.Add(this.pnl_Detail);
            this.split_PanContent.Panel2MinSize = 500;
            this.split_PanContent.Size = new System.Drawing.Size(982, 595);
            this.split_PanContent.SplitterDistance = 301;
            this.split_PanContent.TabIndex = 0;
            // 
            // listBox_ListeEmployes
            // 
            this.listBox_ListeEmployes.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.listBox_ListeEmployes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox_ListeEmployes.FormattingEnabled = true;
            this.listBox_ListeEmployes.ItemHeight = 20;
            this.listBox_ListeEmployes.Location = new System.Drawing.Point(0, 49);
            this.listBox_ListeEmployes.Name = "listBox_ListeEmployes";
            this.listBox_ListeEmployes.Size = new System.Drawing.Size(301, 546);
            this.listBox_ListeEmployes.TabIndex = 2;
            // 
            // pnl_Rafraichir
            // 
            this.pnl_Rafraichir.Controls.Add(this.btn_rafraichir);
            this.pnl_Rafraichir.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.pnl_Rafraichir.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_Rafraichir.Location = new System.Drawing.Point(0, 0);
            this.pnl_Rafraichir.Name = "pnl_Rafraichir";
            this.pnl_Rafraichir.Size = new System.Drawing.Size(301, 49);
            this.pnl_Rafraichir.TabIndex = 1;
            // 
            // btn_rafraichir
            // 
            this.btn_rafraichir.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_rafraichir.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btn_rafraichir.Location = new System.Drawing.Point(12, 6);
            this.btn_rafraichir.Name = "btn_rafraichir";
            this.btn_rafraichir.Size = new System.Drawing.Size(276, 34);
            this.btn_rafraichir.TabIndex = 0;
            this.btn_rafraichir.Text = "Rafraichir";
            this.btn_rafraichir.UseVisualStyleBackColor = true;
            this.btn_rafraichir.Click += new System.EventHandler(this.btn_rafraichir_Click);
            // 
            // pnl_Detail
            // 
            this.pnl_Detail.Controls.Add(this.btn_Sauvegarder);
            this.pnl_Detail.Controls.Add(this.chkBox_EstPiloteDeLigne);
            this.pnl_Detail.Controls.Add(this.cmbBox_ListeRoles);
            this.pnl_Detail.Controls.Add(this.lbl_Role);
            this.pnl_Detail.Controls.Add(this.dtpick_DateEmbauche);
            this.pnl_Detail.Controls.Add(this.lbl_DateEmbauche);
            this.pnl_Detail.Controls.Add(this.lbl_Prenom);
            this.pnl_Detail.Controls.Add(this.txtBx_Prenom);
            this.pnl_Detail.Controls.Add(this.txtBx_Nom);
            this.pnl_Detail.Controls.Add(this.lbl_Nom);
            this.pnl_Detail.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.pnl_Detail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_Detail.Location = new System.Drawing.Point(0, 0);
            this.pnl_Detail.Name = "pnl_Detail";
            this.pnl_Detail.Size = new System.Drawing.Size(677, 595);
            this.pnl_Detail.TabIndex = 0;
            // 
            // btn_Sauvegarder
            // 
            this.btn_Sauvegarder.Location = new System.Drawing.Point(28, 462);
            this.btn_Sauvegarder.Name = "btn_Sauvegarder";
            this.btn_Sauvegarder.Size = new System.Drawing.Size(126, 29);
            this.btn_Sauvegarder.TabIndex = 9;
            this.btn_Sauvegarder.Text = "Sauvegarder";
            this.btn_Sauvegarder.UseVisualStyleBackColor = true;
            this.btn_Sauvegarder.Click += new System.EventHandler(this.btn_Sauvegarder_Click);
            // 
            // chkBox_EstPiloteDeLigne
            // 
            this.chkBox_EstPiloteDeLigne.AutoSize = true;
            this.chkBox_EstPiloteDeLigne.Location = new System.Drawing.Point(28, 385);
            this.chkBox_EstPiloteDeLigne.Name = "chkBox_EstPiloteDeLigne";
            this.chkBox_EstPiloteDeLigne.Size = new System.Drawing.Size(151, 24);
            this.chkBox_EstPiloteDeLigne.TabIndex = 8;
            this.chkBox_EstPiloteDeLigne.Text = "Est pilote de ligne";
            this.chkBox_EstPiloteDeLigne.UseVisualStyleBackColor = true;
            // 
            // cmbBox_ListeRoles
            // 
            this.cmbBox_ListeRoles.FormattingEnabled = true;
            this.cmbBox_ListeRoles.Location = new System.Drawing.Point(28, 325);
            this.cmbBox_ListeRoles.Name = "cmbBox_ListeRoles";
            this.cmbBox_ListeRoles.Size = new System.Drawing.Size(151, 28);
            this.cmbBox_ListeRoles.TabIndex = 7;
            // 
            // lbl_Role
            // 
            this.lbl_Role.AutoSize = true;
            this.lbl_Role.Location = new System.Drawing.Point(28, 292);
            this.lbl_Role.Name = "lbl_Role";
            this.lbl_Role.Size = new System.Drawing.Size(39, 20);
            this.lbl_Role.TabIndex = 6;
            this.lbl_Role.Text = "Role";
            // 
            // dtpick_DateEmbauche
            // 
            this.dtpick_DateEmbauche.Location = new System.Drawing.Point(28, 235);
            this.dtpick_DateEmbauche.Name = "dtpick_DateEmbauche";
            this.dtpick_DateEmbauche.Size = new System.Drawing.Size(250, 27);
            this.dtpick_DateEmbauche.TabIndex = 5;
            // 
            // lbl_DateEmbauche
            // 
            this.lbl_DateEmbauche.AutoSize = true;
            this.lbl_DateEmbauche.Location = new System.Drawing.Point(28, 195);
            this.lbl_DateEmbauche.Name = "lbl_DateEmbauche";
            this.lbl_DateEmbauche.Size = new System.Drawing.Size(126, 20);
            this.lbl_DateEmbauche.TabIndex = 4;
            this.lbl_DateEmbauche.Text = "Date d\'embauche";
            // 
            // lbl_Prenom
            // 
            this.lbl_Prenom.AutoSize = true;
            this.lbl_Prenom.Location = new System.Drawing.Point(28, 102);
            this.lbl_Prenom.Name = "lbl_Prenom";
            this.lbl_Prenom.Size = new System.Drawing.Size(60, 20);
            this.lbl_Prenom.TabIndex = 3;
            this.lbl_Prenom.Text = "Prenom";
            // 
            // txtBx_Prenom
            // 
            this.txtBx_Prenom.Location = new System.Drawing.Point(28, 140);
            this.txtBx_Prenom.Name = "txtBx_Prenom";
            this.txtBx_Prenom.Size = new System.Drawing.Size(256, 27);
            this.txtBx_Prenom.TabIndex = 2;
            // 
            // txtBx_Nom
            // 
            this.txtBx_Nom.Location = new System.Drawing.Point(28, 49);
            this.txtBx_Nom.Name = "txtBx_Nom";
            this.txtBx_Nom.Size = new System.Drawing.Size(256, 27);
            this.txtBx_Nom.TabIndex = 1;
            // 
            // lbl_Nom
            // 
            this.lbl_Nom.AutoSize = true;
            this.lbl_Nom.Location = new System.Drawing.Point(28, 20);
            this.lbl_Nom.Name = "lbl_Nom";
            this.lbl_Nom.Size = new System.Drawing.Size(42, 20);
            this.lbl_Nom.TabIndex = 0;
            this.lbl_Nom.Text = "Nom";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 745);
            this.Controls.Add(this.pan_Content);
            this.Controls.Add(this.pan_Header);
            this.MaximumSize = new System.Drawing.Size(1500, 1000);
            this.MinimumSize = new System.Drawing.Size(750, 750);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.pan_Header.ResumeLayout(false);
            this.pan_Header.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pan_Content.ResumeLayout(false);
            this.split_PanContent.Panel1.ResumeLayout(false);
            this.split_PanContent.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.split_PanContent)).EndInit();
            this.split_PanContent.ResumeLayout(false);
            this.pnl_Rafraichir.ResumeLayout(false);
            this.pnl_Detail.ResumeLayout(false);
            this.pnl_Detail.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bs_Employes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pan_Header;
        private System.Windows.Forms.Panel pan_Content;
        private System.Windows.Forms.SplitContainer split_PanContent;
        private System.Windows.Forms.Button btn_rafraichir;
        private System.Windows.Forms.ListBox listBox_ListeEmployes;
        private System.Windows.Forms.Panel pnl_Rafraichir;
        private System.Windows.Forms.Panel pnl_Detail;
        private System.Windows.Forms.TextBox txtBx_Prenom;
        private System.Windows.Forms.TextBox txtBx_Nom;
        private System.Windows.Forms.Label lbl_Nom;
        private System.Windows.Forms.Label lbl_Prenom;
        private System.Windows.Forms.Label lbl_DateEmbauche;
        private System.Windows.Forms.Label lbl_Role;
        private System.Windows.Forms.DateTimePicker dtpick_DateEmbauche;
        private System.Windows.Forms.ComboBox cmbBox_ListeRoles;
        private System.Windows.Forms.CheckBox chkBox_EstPiloteDeLigne;
        private System.Windows.Forms.Button btn_Sauvegarder;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbl_GestionEmploye;
        private System.Windows.Forms.BindingSource bs_Employes;
    }
}

