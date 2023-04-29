namespace OOP_Cinephile.Net
{
    partial class Form2
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
            this.NameTB1 = new System.Windows.Forms.TextBox();
            this.AgeTB1 = new System.Windows.Forms.TextBox();
            this.MailTB1 = new System.Windows.Forms.TextBox();
            this.PasswordTB1 = new System.Windows.Forms.TextBox();
            this.RePassTB = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SignUp = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // NameTB1
            // 
            this.NameTB1.Location = new System.Drawing.Point(330, 35);
            this.NameTB1.Name = "NameTB1";
            this.NameTB1.Size = new System.Drawing.Size(151, 22);
            this.NameTB1.TabIndex = 35;
            // 
            // AgeTB1
            // 
            this.AgeTB1.Location = new System.Drawing.Point(330, 87);
            this.AgeTB1.Name = "AgeTB1";
            this.AgeTB1.Size = new System.Drawing.Size(151, 22);
            this.AgeTB1.TabIndex = 34;
            // 
            // MailTB1
            // 
            this.MailTB1.Location = new System.Drawing.Point(330, 137);
            this.MailTB1.Name = "MailTB1";
            this.MailTB1.Size = new System.Drawing.Size(151, 22);
            this.MailTB1.TabIndex = 33;
            // 
            // PasswordTB1
            // 
            this.PasswordTB1.Location = new System.Drawing.Point(330, 187);
            this.PasswordTB1.Name = "PasswordTB1";
            this.PasswordTB1.Size = new System.Drawing.Size(151, 22);
            this.PasswordTB1.TabIndex = 32;
            // 
            // RePassTB
            // 
            this.RePassTB.Location = new System.Drawing.Point(330, 229);
            this.RePassTB.Name = "RePassTB";
            this.RePassTB.Size = new System.Drawing.Size(151, 22);
            this.RePassTB.TabIndex = 31;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(705, 382);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(83, 33);
            this.button3.TabIndex = 30;
            this.button3.Text = "Next";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 382);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(83, 33);
            this.button2.TabIndex = 29;
            this.button2.Text = "Back";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Private",
            "Public"});
            this.comboBox1.Location = new System.Drawing.Point(330, 280);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(151, 24);
            this.comboBox1.TabIndex = 28;
            // 
            // SignUp
            // 
            this.SignUp.Location = new System.Drawing.Point(199, 280);
            this.SignUp.Name = "SignUp";
            this.SignUp.Size = new System.Drawing.Size(83, 33);
            this.SignUp.TabIndex = 27;
            this.SignUp.Text = "Sign Up!";
            this.SignUp.UseVisualStyleBackColor = true;
            this.SignUp.Click += new System.EventHandler(this.SignUp_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(196, 235);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 16);
            this.label5.TabIndex = 26;
            this.label5.Text = "Re-Type Password:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(196, 187);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 16);
            this.label4.TabIndex = 25;
            this.label4.Text = "Password:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(196, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 16);
            this.label3.TabIndex = 24;
            this.label3.Text = "E-Mail:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(197, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 16);
            this.label2.TabIndex = 23;
            this.label2.Text = "Age:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(197, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 16);
            this.label1.TabIndex = 22;
            this.label1.Text = "Name:";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(833, 450);
            this.Controls.Add(this.NameTB1);
            this.Controls.Add(this.AgeTB1);
            this.Controls.Add(this.MailTB1);
            this.Controls.Add(this.PasswordTB1);
            this.Controls.Add(this.RePassTB);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.SignUp);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox NameTB1;
        private System.Windows.Forms.TextBox AgeTB1;
        private System.Windows.Forms.TextBox MailTB1;
        private System.Windows.Forms.TextBox PasswordTB1;
        private System.Windows.Forms.TextBox RePassTB;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button SignUp;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}