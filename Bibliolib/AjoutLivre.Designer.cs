
namespace Bibliolib
{
    partial class AjoutLivre
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AjoutLivre));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ajouterLivre_btn = new System.Windows.Forms.Button();
            this.selectedBook = new System.Windows.Forms.Label();
            this.quantite = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.idbookhiden = new System.Windows.Forms.Label();
            this.listBooks = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(46, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(251, 102);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // ajouterLivre_btn
            // 
            this.ajouterLivre_btn.Location = new System.Drawing.Point(664, 402);
            this.ajouterLivre_btn.Name = "ajouterLivre_btn";
            this.ajouterLivre_btn.Size = new System.Drawing.Size(75, 23);
            this.ajouterLivre_btn.TabIndex = 2;
            this.ajouterLivre_btn.Text = "Valider";
            this.ajouterLivre_btn.UseVisualStyleBackColor = true;
            this.ajouterLivre_btn.Click += new System.EventHandler(this.ajouterLivre_btn_Click);
            // 
            // selectedBook
            // 
            this.selectedBook.AutoSize = true;
            this.selectedBook.Location = new System.Drawing.Point(445, 176);
            this.selectedBook.Name = "selectedBook";
            this.selectedBook.Size = new System.Drawing.Size(37, 13);
            this.selectedBook.TabIndex = 3;
            this.selectedBook.Text = "HERE";
            this.selectedBook.Click += new System.EventHandler(this.selectedBook_Click);
            // 
            // quantite
            // 
            this.quantite.Location = new System.Drawing.Point(435, 295);
            this.quantite.Name = "quantite";
            this.quantite.Size = new System.Drawing.Size(261, 20);
            this.quantite.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(347, 302);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Quantité";
            // 
            // idbookhiden
            // 
            this.idbookhiden.AutoSize = true;
            this.idbookhiden.Location = new System.Drawing.Point(408, 175);
            this.idbookhiden.Name = "idbookhiden";
            this.idbookhiden.Size = new System.Drawing.Size(0, 13);
            this.idbookhiden.TabIndex = 6;
            // 
            // listBooks
            // 
            this.listBooks.FormattingEnabled = true;
            this.listBooks.Location = new System.Drawing.Point(33, 185);
            this.listBooks.Name = "listBooks";
            this.listBooks.Size = new System.Drawing.Size(274, 238);
            this.listBooks.TabIndex = 7;
            this.listBooks.SelectedIndexChanged += new System.EventHandler(this.listBooks_SelectedIndexChanged_1);
            // 
            // AjoutLivre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listBooks);
            this.Controls.Add(this.idbookhiden);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.quantite);
            this.Controls.Add(this.selectedBook);
            this.Controls.Add(this.ajouterLivre_btn);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AjoutLivre";
            this.Text = "AjoutLivre";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button ajouterLivre_btn;
        private System.Windows.Forms.Label selectedBook;
        private System.Windows.Forms.TextBox quantite;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label idbookhiden;
        private System.Windows.Forms.ListBox listBooks;
    }
}