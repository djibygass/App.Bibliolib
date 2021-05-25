
namespace Bibliolib
{
    partial class annonce
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(annonce));
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_titre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_Contenu = new System.Windows.Forms.TextBox();
            this.btn_publier = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(153, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Titre de L\'annonce : ";
            // 
            // textBox_titre
            // 
            this.textBox_titre.Location = new System.Drawing.Point(344, 98);
            this.textBox_titre.Name = "textBox_titre";
            this.textBox_titre.Size = new System.Drawing.Size(292, 20);
            this.textBox_titre.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(205, 220);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Contenu :";
            // 
            // textBox_Contenu
            // 
            this.textBox_Contenu.Location = new System.Drawing.Point(344, 212);
            this.textBox_Contenu.Multiline = true;
            this.textBox_Contenu.Name = "textBox_Contenu";
            this.textBox_Contenu.Size = new System.Drawing.Size(292, 102);
            this.textBox_Contenu.TabIndex = 3;
            // 
            // btn_publier
            // 
            this.btn_publier.Location = new System.Drawing.Point(593, 372);
            this.btn_publier.Name = "btn_publier";
            this.btn_publier.Size = new System.Drawing.Size(75, 23);
            this.btn_publier.TabIndex = 4;
            this.btn_publier.Text = "Publier";
            this.btn_publier.UseVisualStyleBackColor = true;
            this.btn_publier.Click += new System.EventHandler(this.btn_publier_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(199, 76);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // annonce
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_publier);
            this.Controls.Add(this.textBox_Contenu);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_titre);
            this.Controls.Add(this.label1);
            this.Name = "annonce";
            this.Text = "Annonces";
            this.Load += new System.EventHandler(this.annonce_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_titre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_Contenu;
        private System.Windows.Forms.Button btn_publier;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}