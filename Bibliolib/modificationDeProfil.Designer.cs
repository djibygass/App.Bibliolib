
namespace Bibliolib
{
    partial class modificationDeProfil
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(modificationDeProfil));
            this.changePassword = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.newPassword = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.ChangeLogin = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.confirmPassword = new System.Windows.Forms.TextBox();
            this.actualPassword = new System.Windows.Forms.TextBox();
            this.newLogin = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.labelAdmin1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // changePassword
            // 
            this.changePassword.Enabled = false;
            this.changePassword.Location = new System.Drawing.Point(464, 475);
            this.changePassword.Name = "changePassword";
            this.changePassword.Size = new System.Drawing.Size(75, 23);
            this.changePassword.TabIndex = 0;
            this.changePassword.Text = "Valider";
            this.changePassword.UseVisualStyleBackColor = true;
            this.changePassword.Click += new System.EventHandler(this.changePassword_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.newPassword);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.ChangeLogin);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.confirmPassword);
            this.panel1.Controls.Add(this.actualPassword);
            this.panel1.Controls.Add(this.newLogin);
            this.panel1.Controls.Add(this.changePassword);
            this.panel1.Location = new System.Drawing.Point(251, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(595, 511);
            this.panel1.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(58, 48);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Nouveau login";
            // 
            // newPassword
            // 
            this.newPassword.Location = new System.Drawing.Point(116, 344);
            this.newPassword.Name = "newPassword";
            this.newPassword.PasswordChar = '•';
            this.newPassword.Size = new System.Drawing.Size(210, 20);
            this.newPassword.TabIndex = 10;
            this.newPassword.TextChanged += new System.EventHandler(this.newPassword_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(55, 312);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(117, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Nouveau mot de passe";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(58, 246);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Ancien mot de passe";
            // 
            // ChangeLogin
            // 
            this.ChangeLogin.Enabled = false;
            this.ChangeLogin.Location = new System.Drawing.Point(464, 147);
            this.ChangeLogin.Name = "ChangeLogin";
            this.ChangeLogin.Size = new System.Drawing.Size(75, 23);
            this.ChangeLogin.TabIndex = 7;
            this.ChangeLogin.Text = "Valider";
            this.ChangeLogin.UseVisualStyleBackColor = true;
            this.ChangeLogin.Click += new System.EventHandler(this.ChangeLogin_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(55, 386);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Confirmer le mot de passe";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(183, 207);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(190, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "changement le mot de passe";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(183, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "changer le login";
            // 
            // confirmPassword
            // 
            this.confirmPassword.Location = new System.Drawing.Point(116, 422);
            this.confirmPassword.Name = "confirmPassword";
            this.confirmPassword.PasswordChar = '•';
            this.confirmPassword.Size = new System.Drawing.Size(210, 20);
            this.confirmPassword.TabIndex = 3;
            this.confirmPassword.TextChanged += new System.EventHandler(this.confirmPassword_TextChanged);
            // 
            // actualPassword
            // 
            this.actualPassword.Location = new System.Drawing.Point(116, 277);
            this.actualPassword.Name = "actualPassword";
            this.actualPassword.PasswordChar = '•';
            this.actualPassword.Size = new System.Drawing.Size(210, 20);
            this.actualPassword.TabIndex = 2;
            this.actualPassword.TextChanged += new System.EventHandler(this.actualPassword_TextChanged);
            // 
            // newLogin
            // 
            this.newLogin.Location = new System.Drawing.Point(116, 110);
            this.newLogin.Name = "newLogin";
            this.newLogin.Size = new System.Drawing.Size(210, 20);
            this.newLogin.TabIndex = 1;
            this.newLogin.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(15, 42);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(219, 91);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 258);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Administrateur : ";
            // 
            // labelAdmin1
            // 
            this.labelAdmin1.AutoSize = true;
            this.labelAdmin1.Location = new System.Drawing.Point(119, 258);
            this.labelAdmin1.Name = "labelAdmin1";
            this.labelAdmin1.Size = new System.Drawing.Size(0, 13);
            this.labelAdmin1.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(81, 77);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(183, 12);
            this.label8.TabIndex = 12;
            this.label8.Text = "*Les espaces ne seront pas tenu en compte";
            // 
            // modificationDeProfil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(873, 538);
            this.Controls.Add(this.labelAdmin1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "modificationDeProfil";
            this.Text = "modification";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button changePassword;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox confirmPassword;
        private System.Windows.Forms.TextBox actualPassword;
        private System.Windows.Forms.TextBox newLogin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button ChangeLogin;
        private System.Windows.Forms.Label labelAdmin1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox newPassword;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}