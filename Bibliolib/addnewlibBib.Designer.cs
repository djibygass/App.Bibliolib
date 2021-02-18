
namespace Bibliolib
{
    partial class addnewlibBib
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(addnewlibBib));
            this.comboBoxAdress = new System.Windows.Forms.ComboBox();
            this.comboBoxAdminsite = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.checkBoxbib = new System.Windows.Forms.CheckBox();
            this.checkBoxlib = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Adminlogin4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxAdress
            // 
            this.comboBoxAdress.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.comboBoxAdress.FormattingEnabled = true;
            this.comboBoxAdress.Location = new System.Drawing.Point(165, 149);
            this.comboBoxAdress.Name = "comboBoxAdress";
            this.comboBoxAdress.Size = new System.Drawing.Size(292, 21);
            this.comboBoxAdress.TabIndex = 0;
            this.comboBoxAdress.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // comboBoxAdminsite
            // 
            this.comboBoxAdminsite.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.comboBoxAdminsite.FormattingEnabled = true;
            this.comboBoxAdminsite.Location = new System.Drawing.Point(165, 247);
            this.comboBoxAdminsite.Name = "comboBoxAdminsite";
            this.comboBoxAdminsite.Size = new System.Drawing.Size(292, 21);
            this.comboBoxAdminsite.TabIndex = 1;
            this.comboBoxAdminsite.SelectedIndexChanged += new System.EventHandler(this.comboBoxAdminsite_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.checkBoxbib);
            this.panel1.Controls.Add(this.checkBoxlib);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.comboBoxAdress);
            this.panel1.Controls.Add(this.comboBoxAdminsite);
            this.panel1.Location = new System.Drawing.Point(66, 93);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(638, 345);
            this.panel1.TabIndex = 2;
            // 
            // checkBoxbib
            // 
            this.checkBoxbib.AutoSize = true;
            this.checkBoxbib.Location = new System.Drawing.Point(348, 45);
            this.checkBoxbib.Name = "checkBoxbib";
            this.checkBoxbib.Size = new System.Drawing.Size(84, 17);
            this.checkBoxbib.TabIndex = 6;
            this.checkBoxbib.Text = "Bibliothèque";
            this.checkBoxbib.UseVisualStyleBackColor = true;
            // 
            // checkBoxlib
            // 
            this.checkBoxlib.AutoSize = true;
            this.checkBoxlib.Location = new System.Drawing.Point(198, 45);
            this.checkBoxlib.Name = "checkBoxlib";
            this.checkBoxlib.Size = new System.Drawing.Size(62, 17);
            this.checkBoxlib.TabIndex = 5;
            this.checkBoxlib.Text = "Librairie";
            this.checkBoxlib.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(104, 209);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Choisir un gérant";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(104, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Choisir une Adresse";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Location = new System.Drawing.Point(521, 310);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Valider";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(34, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(185, 75);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(314, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Administrateur : ";
            // 
            // Adminlogin4
            // 
            this.Adminlogin4.AutoSize = true;
            this.Adminlogin4.Location = new System.Drawing.Point(470, 47);
            this.Adminlogin4.Name = "Adminlogin4";
            this.Adminlogin4.Size = new System.Drawing.Size(0, 13);
            this.Adminlogin4.TabIndex = 5;
            // 
            // addnewlibBib
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Adminlogin4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "addnewlibBib";
            this.Text = "Nouvel Etablissement";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxAdress;
        private System.Windows.Forms.ComboBox comboBoxAdminsite;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Adminlogin4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox checkBoxbib;
        private System.Windows.Forms.CheckBox checkBoxlib;
    }
}