
namespace Bibliolib
{
    partial class espaceAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(espaceAdmin));
            this.navBar = new System.Windows.Forms.MenuStrip();
            this.créerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uneNouvelleLibrairieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.unNouveauAdministrateurToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deSiteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.duLogicielToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.publierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uneAnnonceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.unÉvenementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.unePromoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gérerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.leStockToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lesUtilisateursToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lesAdministrateursToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.paramètreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editerProfil = new System.Windows.Forms.ToolStripMenuItem();
            this.déconnexionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.box = new System.Windows.Forms.Label();
            this.message = new System.Windows.Forms.TextBox();
            this.send_btn = new System.Windows.Forms.Button();
            this.labelAdmin = new System.Windows.Forms.Label();
            this.adminLogin = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.listeAdmin = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.listAdmin = new System.Windows.Forms.ListBox();
            this.listAdminSite = new System.Windows.Forms.ListBox();
            this.idhide = new System.Windows.Forms.Label();
            this.uneNouvelleAdresseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lesAdressesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.navBar.SuspendLayout();
            this.panel1.SuspendLayout();
            this.listeAdmin.SuspendLayout();
            this.SuspendLayout();
            // 
            // navBar
            // 
            this.navBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.créerToolStripMenuItem,
            this.publierToolStripMenuItem,
            this.gérerToolStripMenuItem,
            this.paramètreToolStripMenuItem});
            this.navBar.Location = new System.Drawing.Point(0, 0);
            this.navBar.Name = "navBar";
            this.navBar.Size = new System.Drawing.Size(975, 24);
            this.navBar.TabIndex = 0;
            this.navBar.Text = "Menu";
            // 
            // créerToolStripMenuItem
            // 
            this.créerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.uneNouvelleLibrairieToolStripMenuItem,
            this.unNouveauAdministrateurToolStripMenuItem,
            this.uneNouvelleAdresseToolStripMenuItem});
            this.créerToolStripMenuItem.Name = "créerToolStripMenuItem";
            this.créerToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.créerToolStripMenuItem.Text = "Créer";
            // 
            // uneNouvelleLibrairieToolStripMenuItem
            // 
            this.uneNouvelleLibrairieToolStripMenuItem.Name = "uneNouvelleLibrairieToolStripMenuItem";
            this.uneNouvelleLibrairieToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.uneNouvelleLibrairieToolStripMenuItem.Text = "un nouvel etablissement";
            this.uneNouvelleLibrairieToolStripMenuItem.Click += new System.EventHandler(this.uneNouvelleLibrairieToolStripMenuItem_Click);
            // 
            // unNouveauAdministrateurToolStripMenuItem
            // 
            this.unNouveauAdministrateurToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deSiteToolStripMenuItem,
            this.duLogicielToolStripMenuItem});
            this.unNouveauAdministrateurToolStripMenuItem.Name = "unNouveauAdministrateurToolStripMenuItem";
            this.unNouveauAdministrateurToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.unNouveauAdministrateurToolStripMenuItem.Text = "un nouvel Administrateur";
            // 
            // deSiteToolStripMenuItem
            // 
            this.deSiteToolStripMenuItem.Name = "deSiteToolStripMenuItem";
            this.deSiteToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.deSiteToolStripMenuItem.Text = "De site";
            this.deSiteToolStripMenuItem.Click += new System.EventHandler(this.deSiteToolStripMenuItem_Click);
            // 
            // duLogicielToolStripMenuItem
            // 
            this.duLogicielToolStripMenuItem.Name = "duLogicielToolStripMenuItem";
            this.duLogicielToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.duLogicielToolStripMenuItem.Text = "Du logiciel";
            this.duLogicielToolStripMenuItem.Click += new System.EventHandler(this.duLogicielToolStripMenuItem_Click);
            // 
            // publierToolStripMenuItem
            // 
            this.publierToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.uneAnnonceToolStripMenuItem,
            this.unÉvenementToolStripMenuItem,
            this.unePromoToolStripMenuItem});
            this.publierToolStripMenuItem.Name = "publierToolStripMenuItem";
            this.publierToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.publierToolStripMenuItem.Text = "Publier";
            // 
            // uneAnnonceToolStripMenuItem
            // 
            this.uneAnnonceToolStripMenuItem.Name = "uneAnnonceToolStripMenuItem";
            this.uneAnnonceToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.uneAnnonceToolStripMenuItem.Text = "une annonce";
            // 
            // unÉvenementToolStripMenuItem
            // 
            this.unÉvenementToolStripMenuItem.Name = "unÉvenementToolStripMenuItem";
            this.unÉvenementToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.unÉvenementToolStripMenuItem.Text = "un évenement";
            // 
            // unePromoToolStripMenuItem
            // 
            this.unePromoToolStripMenuItem.Name = "unePromoToolStripMenuItem";
            this.unePromoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.unePromoToolStripMenuItem.Text = "une promo";
            // 
            // gérerToolStripMenuItem
            // 
            this.gérerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.leStockToolStripMenuItem,
            this.lesUtilisateursToolStripMenuItem,
            this.lesAdministrateursToolStripMenuItem,
            this.lesAdressesToolStripMenuItem});
            this.gérerToolStripMenuItem.Name = "gérerToolStripMenuItem";
            this.gérerToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.gérerToolStripMenuItem.Text = "Gérer";
            // 
            // leStockToolStripMenuItem
            // 
            this.leStockToolStripMenuItem.Name = "leStockToolStripMenuItem";
            this.leStockToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.leStockToolStripMenuItem.Text = "le stock";
            this.leStockToolStripMenuItem.Click += new System.EventHandler(this.leStockToolStripMenuItem_Click);
            // 
            // lesUtilisateursToolStripMenuItem
            // 
            this.lesUtilisateursToolStripMenuItem.Name = "lesUtilisateursToolStripMenuItem";
            this.lesUtilisateursToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.lesUtilisateursToolStripMenuItem.Text = "les utilisateurs";
            // 
            // lesAdministrateursToolStripMenuItem
            // 
            this.lesAdministrateursToolStripMenuItem.Name = "lesAdministrateursToolStripMenuItem";
            this.lesAdministrateursToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.lesAdministrateursToolStripMenuItem.Text = "les administrateurs";
            // 
            // paramètreToolStripMenuItem
            // 
            this.paramètreToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editerProfil,
            this.déconnexionToolStripMenuItem});
            this.paramètreToolStripMenuItem.Name = "paramètreToolStripMenuItem";
            this.paramètreToolStripMenuItem.Size = new System.Drawing.Size(78, 20);
            this.paramètreToolStripMenuItem.Text = "Paramètres";
            // 
            // editerProfil
            // 
            this.editerProfil.Name = "editerProfil";
            this.editerProfil.Size = new System.Drawing.Size(180, 22);
            this.editerProfil.Text = "éditer mon profil";
            this.editerProfil.Click += new System.EventHandler(this.changerDeMotDePasseToolStripMenuItem_Click);
            // 
            // déconnexionToolStripMenuItem
            // 
            this.déconnexionToolStripMenuItem.Name = "déconnexionToolStripMenuItem";
            this.déconnexionToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.déconnexionToolStripMenuItem.Text = "déconnexion";
            this.déconnexionToolStripMenuItem.Click += new System.EventHandler(this.déconnexionToolStripMenuItem_Click);
            // 
            // box
            // 
            this.box.AutoSize = true;
            this.box.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.box.Location = new System.Drawing.Point(467, 25);
            this.box.Name = "box";
            this.box.Size = new System.Drawing.Size(44, 15);
            this.box.TabIndex = 0;
            this.box.Text = "ADMIN";
            // 
            // message
            // 
            this.message.Location = new System.Drawing.Point(30, 342);
            this.message.Multiline = true;
            this.message.Name = "message";
            this.message.Size = new System.Drawing.Size(446, 82);
            this.message.TabIndex = 1;
            this.message.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // send_btn
            // 
            this.send_btn.Enabled = false;
            this.send_btn.Location = new System.Drawing.Point(387, 430);
            this.send_btn.Name = "send_btn";
            this.send_btn.Size = new System.Drawing.Size(75, 23);
            this.send_btn.TabIndex = 3;
            this.send_btn.Text = "Envoyer";
            this.send_btn.UseVisualStyleBackColor = true;
            this.send_btn.Click += new System.EventHandler(this.send_btn_Click);
            // 
            // labelAdmin
            // 
            this.labelAdmin.AutoSize = true;
            this.labelAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAdmin.Location = new System.Drawing.Point(12, 105);
            this.labelAdmin.Name = "labelAdmin";
            this.labelAdmin.Size = new System.Drawing.Size(123, 17);
            this.labelAdmin.TabIndex = 4;
            this.labelAdmin.Text = "Administrateur :";
            // 
            // adminLogin
            // 
            this.adminLogin.AutoSize = true;
            this.adminLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminLogin.Location = new System.Drawing.Point(171, 105);
            this.adminLogin.Name = "adminLogin";
            this.adminLogin.Size = new System.Drawing.Size(0, 15);
            this.adminLogin.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.panel1.Controls.Add(this.flowLayoutPanel1);
            this.panel1.Controls.Add(this.message);
            this.panel1.Controls.Add(this.send_btn);
            this.panel1.Location = new System.Drawing.Point(467, 43);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(496, 463);
            this.panel1.TabIndex = 6;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint_1);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.ColumnCount = 1;
            this.flowLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.RowCount = 1;
            this.flowLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.flowLayoutPanel1.Size = new System.Drawing.Size(496, 318);
            this.flowLayoutPanel1.TabIndex = 4;
            // 
            // listeAdmin
            // 
            this.listeAdmin.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.listeAdmin.AutoSize = true;
            this.listeAdmin.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.listeAdmin.Controls.Add(this.label2);
            this.listeAdmin.Controls.Add(this.label1);
            this.listeAdmin.Controls.Add(this.listAdmin);
            this.listeAdmin.Controls.Add(this.listAdminSite);
            this.listeAdmin.Location = new System.Drawing.Point(15, 202);
            this.listeAdmin.Name = "listeAdmin";
            this.listeAdmin.Size = new System.Drawing.Size(403, 299);
            this.listeAdmin.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Administrateurs de Logiciel";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(223, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Administrateurs de Sites";
            // 
            // listAdmin
            // 
            this.listAdmin.FormattingEnabled = true;
            this.listAdmin.Location = new System.Drawing.Point(21, 42);
            this.listAdmin.Name = "listAdmin";
            this.listAdmin.Size = new System.Drawing.Size(151, 238);
            this.listAdmin.TabIndex = 1;
            this.listAdmin.SelectedIndexChanged += new System.EventHandler(this.listAdmin_SelectedIndexChanged);
            // 
            // listAdminSite
            // 
            this.listAdminSite.FormattingEnabled = true;
            this.listAdminSite.Location = new System.Drawing.Point(207, 42);
            this.listAdminSite.MultiColumn = true;
            this.listAdminSite.Name = "listAdminSite";
            this.listAdminSite.Size = new System.Drawing.Size(153, 238);
            this.listAdminSite.TabIndex = 0;
            this.listAdminSite.SelectedIndexChanged += new System.EventHandler(this.listAdminSite_SelectedIndexChanged_1);
            // 
            // idhide
            // 
            this.idhide.AutoSize = true;
            this.idhide.Location = new System.Drawing.Point(517, 27);
            this.idhide.Name = "idhide";
            this.idhide.Size = new System.Drawing.Size(0, 13);
            this.idhide.TabIndex = 8;
            this.idhide.Visible = false;
            // 
            // uneNouvelleAdresseToolStripMenuItem
            // 
            this.uneNouvelleAdresseToolStripMenuItem.Name = "uneNouvelleAdresseToolStripMenuItem";
            this.uneNouvelleAdresseToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.uneNouvelleAdresseToolStripMenuItem.Text = "une nouvelle adresse";
            this.uneNouvelleAdresseToolStripMenuItem.Click += new System.EventHandler(this.uneNouvelleAdresseToolStripMenuItem_Click);
            // 
            // lesAdressesToolStripMenuItem
            // 
            this.lesAdressesToolStripMenuItem.Name = "lesAdressesToolStripMenuItem";
            this.lesAdressesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.lesAdressesToolStripMenuItem.Text = "les adresses";
            // 
            // espaceAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(975, 525);
            this.Controls.Add(this.idhide);
            this.Controls.Add(this.listeAdmin);
            this.Controls.Add(this.box);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.adminLogin);
            this.Controls.Add(this.labelAdmin);
            this.Controls.Add(this.navBar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.navBar;
            this.Name = "espaceAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Accueil";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.espaceAdmin_FormClosing);
            this.Load += new System.EventHandler(this.espaceAdmin_Load);
            this.navBar.ResumeLayout(false);
            this.navBar.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.listeAdmin.ResumeLayout(false);
            this.listeAdmin.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip navBar;
        private System.Windows.Forms.ToolStripMenuItem créerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uneNouvelleLibrairieToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem unNouveauAdministrateurToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deSiteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem duLogicielToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem publierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uneAnnonceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem unÉvenementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem unePromoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gérerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem leStockToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lesUtilisateursToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem paramètreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editerProfil;
        private System.Windows.Forms.ToolStripMenuItem déconnexionToolStripMenuItem;
        private System.Windows.Forms.Label box;
        private System.Windows.Forms.TextBox message;
        private System.Windows.Forms.Button send_btn;
        private System.Windows.Forms.Label labelAdmin;
        private System.Windows.Forms.Label adminLogin;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel listeAdmin;
        private System.Windows.Forms.ListBox listAdminSite;
        private System.Windows.Forms.ListBox listAdmin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TableLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.ToolStripMenuItem lesAdministrateursToolStripMenuItem;
        private System.Windows.Forms.Label idhide;
        private System.Windows.Forms.ToolStripMenuItem uneNouvelleAdresseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lesAdressesToolStripMenuItem;
    }
}