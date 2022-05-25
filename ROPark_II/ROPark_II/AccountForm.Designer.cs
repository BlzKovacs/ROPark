namespace ROPark_II
{
    partial class AccountForm
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
            this.panelSecondForm = new System.Windows.Forms.Panel();
            this.buttonPark = new System.Windows.Forms.Button();
            this.listBoxHistory = new System.Windows.Forms.ListBox();
            this.label7 = new System.Windows.Forms.Label();
            this.buttonSignOut = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelPhone = new System.Windows.Forms.Label();
            this.labelEmail = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.labelUser = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panelSecondForm.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelSecondForm
            // 
            this.panelSecondForm.BackgroundImage = global::ROPark_II.Properties.Resources.background;
            this.panelSecondForm.Controls.Add(this.buttonPark);
            this.panelSecondForm.Controls.Add(this.listBoxHistory);
            this.panelSecondForm.Controls.Add(this.label7);
            this.panelSecondForm.Controls.Add(this.buttonSignOut);
            this.panelSecondForm.Controls.Add(this.label6);
            this.panelSecondForm.Controls.Add(this.label5);
            this.panelSecondForm.Controls.Add(this.label4);
            this.panelSecondForm.Controls.Add(this.label3);
            this.panelSecondForm.Controls.Add(this.labelPhone);
            this.panelSecondForm.Controls.Add(this.labelEmail);
            this.panelSecondForm.Controls.Add(this.labelName);
            this.panelSecondForm.Controls.Add(this.labelUser);
            this.panelSecondForm.Controls.Add(this.label2);
            this.panelSecondForm.Controls.Add(this.label1);
            this.panelSecondForm.Location = new System.Drawing.Point(-2, -1);
            this.panelSecondForm.Name = "panelSecondForm";
            this.panelSecondForm.Size = new System.Drawing.Size(1369, 653);
            this.panelSecondForm.TabIndex = 16;
            // 
            // buttonPark
            // 
            this.buttonPark.BackColor = System.Drawing.Color.SteelBlue;
            this.buttonPark.Location = new System.Drawing.Point(250, 400);
            this.buttonPark.Name = "buttonPark";
            this.buttonPark.Size = new System.Drawing.Size(292, 36);
            this.buttonPark.TabIndex = 29;
            this.buttonPark.Text = "View parking info";
            this.buttonPark.UseVisualStyleBackColor = false;
            this.buttonPark.Click += new System.EventHandler(this.buttonPark_Click);
            // 
            // listBoxHistory
            // 
            this.listBoxHistory.FormattingEnabled = true;
            this.listBoxHistory.HorizontalScrollbar = true;
            this.listBoxHistory.ItemHeight = 16;
            this.listBoxHistory.Location = new System.Drawing.Point(625, 197);
            this.listBoxHistory.Name = "listBoxHistory";
            this.listBoxHistory.Size = new System.Drawing.Size(561, 116);
            this.listBoxHistory.TabIndex = 28;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(622, 164);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(132, 16);
            this.label7.TabIndex = 27;
            this.label7.Text = "Your Parking History:";
            // 
            // buttonSignOut
            // 
            this.buttonSignOut.BackColor = System.Drawing.Color.SteelBlue;
            this.buttonSignOut.FlatAppearance.BorderSize = 0;
            this.buttonSignOut.Location = new System.Drawing.Point(1046, 27);
            this.buttonSignOut.Name = "buttonSignOut";
            this.buttonSignOut.Size = new System.Drawing.Size(107, 33);
            this.buttonSignOut.TabIndex = 26;
            this.buttonSignOut.Text = "Sign out";
            this.buttonSignOut.UseVisualStyleBackColor = false;
            this.buttonSignOut.Click += new System.EventHandler(this.buttonSignOut_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label6.Location = new System.Drawing.Point(239, 339);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 16);
            this.label6.TabIndex = 25;
            this.label6.Text = "Phone number:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Location = new System.Drawing.Point(247, 287);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 16);
            this.label5.TabIndex = 24;
            this.label5.Text = "Email adress:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(289, 241);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 16);
            this.label4.TabIndex = 23;
            this.label4.Text = "Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(266, 193);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 16);
            this.label3.TabIndex = 22;
            this.label3.Text = "Username:";
            // 
            // labelPhone
            // 
            this.labelPhone.AutoSize = true;
            this.labelPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPhone.Location = new System.Drawing.Point(358, 339);
            this.labelPhone.Name = "labelPhone";
            this.labelPhone.Size = new System.Drawing.Size(46, 18);
            this.labelPhone.TabIndex = 21;
            this.labelPhone.Text = "label6";
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEmail.Location = new System.Drawing.Point(358, 287);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(46, 18);
            this.labelEmail.TabIndex = 20;
            this.labelEmail.Text = "label5";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.Location = new System.Drawing.Point(358, 239);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(46, 18);
            this.labelName.TabIndex = 19;
            this.labelName.Text = "label4";
            // 
            // labelUser
            // 
            this.labelUser.AutoSize = true;
            this.labelUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUser.Location = new System.Drawing.Point(358, 193);
            this.labelUser.Name = "labelUser";
            this.labelUser.Size = new System.Drawing.Size(46, 18);
            this.labelUser.TabIndex = 18;
            this.labelUser.Text = "label3";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(56, 186);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 25);
            this.label2.TabIndex = 17;
            this.label2.Text = "Account info:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 25);
            this.label1.TabIndex = 16;
            this.label1.Text = "Welcome back!";
            // 
            // AccountForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(120)))), ((int)(((byte)(180)))));
            this.ClientSize = new System.Drawing.Size(1263, 606);
            this.Controls.Add(this.panelSecondForm);
            this.Name = "AccountForm";
            this.Text = "AccountForm";
            this.panelSecondForm.ResumeLayout(false);
            this.panelSecondForm.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelSecondForm;
        private System.Windows.Forms.Button buttonPark;
        private System.Windows.Forms.ListBox listBoxHistory;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button buttonSignOut;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelPhone;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelUser;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}