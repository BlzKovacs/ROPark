namespace ROPark_II
{
    partial class MenuForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuForm));
            this.buttonHome = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonAccount = new System.Windows.Forms.Button();
            this.buttonSignUp = new System.Windows.Forms.Button();
            this.buttonSignIn = new System.Windows.Forms.Button();
            this.buttonPark = new System.Windows.Forms.Button();
            this.labelTime = new System.Windows.Forms.Label();
            this.labelClock = new System.Windows.Forms.Label();
            this.panelSecondForm = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.panelSecondForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonHome
            // 
            this.buttonHome.BackColor = System.Drawing.Color.SteelBlue;
            this.buttonHome.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonHome.Location = new System.Drawing.Point(0, 0);
            this.buttonHome.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonHome.Name = "buttonHome";
            this.buttonHome.Size = new System.Drawing.Size(195, 74);
            this.buttonHome.TabIndex = 0;
            this.buttonHome.UseVisualStyleBackColor = false;
            this.buttonHome.Click += new System.EventHandler(this.buttonHome_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.buttonExit);
            this.panel1.Controls.Add(this.buttonAccount);
            this.panel1.Controls.Add(this.buttonSignUp);
            this.panel1.Controls.Add(this.buttonSignIn);
            this.panel1.Controls.Add(this.buttonPark);
            this.panel1.Controls.Add(this.buttonHome);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(195, 675);
            this.panel1.TabIndex = 2;
            // 
            // buttonExit
            // 
            this.buttonExit.BackColor = System.Drawing.Color.SteelBlue;
            this.buttonExit.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonExit.Image = global::ROPark_II.Properties.Resources.exit;
            this.buttonExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonExit.Location = new System.Drawing.Point(0, 534);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(195, 70);
            this.buttonExit.TabIndex = 6;
            this.buttonExit.Text = " Exit";
            this.buttonExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonExit.UseVisualStyleBackColor = false;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // buttonAccount
            // 
            this.buttonAccount.BackColor = System.Drawing.Color.SteelBlue;
            this.buttonAccount.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonAccount.Image = ((System.Drawing.Image)(resources.GetObject("buttonAccount.Image")));
            this.buttonAccount.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAccount.Location = new System.Drawing.Point(0, 604);
            this.buttonAccount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonAccount.Name = "buttonAccount";
            this.buttonAccount.Size = new System.Drawing.Size(195, 71);
            this.buttonAccount.TabIndex = 5;
            this.buttonAccount.Text = "Your account";
            this.buttonAccount.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonAccount.UseVisualStyleBackColor = false;
            this.buttonAccount.Click += new System.EventHandler(this.buttonAccount_Click);
            // 
            // buttonSignUp
            // 
            this.buttonSignUp.BackColor = System.Drawing.Color.SteelBlue;
            this.buttonSignUp.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonSignUp.Image = global::ROPark_II.Properties.Resources.signup;
            this.buttonSignUp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSignUp.Location = new System.Drawing.Point(0, 230);
            this.buttonSignUp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonSignUp.Name = "buttonSignUp";
            this.buttonSignUp.Size = new System.Drawing.Size(195, 78);
            this.buttonSignUp.TabIndex = 4;
            this.buttonSignUp.Text = " Sign up";
            this.buttonSignUp.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonSignUp.UseVisualStyleBackColor = false;
            this.buttonSignUp.Click += new System.EventHandler(this.buttonSignUp_Click);
            // 
            // buttonSignIn
            // 
            this.buttonSignIn.BackColor = System.Drawing.Color.SteelBlue;
            this.buttonSignIn.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonSignIn.Image = global::ROPark_II.Properties.Resources.login1;
            this.buttonSignIn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSignIn.Location = new System.Drawing.Point(0, 156);
            this.buttonSignIn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonSignIn.Name = "buttonSignIn";
            this.buttonSignIn.Size = new System.Drawing.Size(195, 74);
            this.buttonSignIn.TabIndex = 3;
            this.buttonSignIn.Text = " Sign in";
            this.buttonSignIn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonSignIn.UseVisualStyleBackColor = false;
            this.buttonSignIn.Click += new System.EventHandler(this.buttonSignIn_Click);
            // 
            // buttonPark
            // 
            this.buttonPark.BackColor = System.Drawing.Color.SteelBlue;
            this.buttonPark.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonPark.Image = global::ROPark_II.Properties.Resources.startPark;
            this.buttonPark.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonPark.Location = new System.Drawing.Point(0, 74);
            this.buttonPark.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonPark.Name = "buttonPark";
            this.buttonPark.Size = new System.Drawing.Size(195, 82);
            this.buttonPark.TabIndex = 1;
            this.buttonPark.Text = " Start Parking";
            this.buttonPark.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonPark.UseVisualStyleBackColor = false;
            this.buttonPark.Click += new System.EventHandler(this.buttonPark_Click);
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.labelTime.Location = new System.Drawing.Point(228, 54);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(0, 28);
            this.labelTime.TabIndex = 1;
            // 
            // labelClock
            // 
            this.labelClock.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelClock.AutoSize = true;
            this.labelClock.BackColor = System.Drawing.Color.Transparent;
            this.labelClock.Font = new System.Drawing.Font("Impact", 13.8F);
            this.labelClock.ForeColor = System.Drawing.Color.Black;
            this.labelClock.Location = new System.Drawing.Point(485, 54);
            this.labelClock.Name = "labelClock";
            this.labelClock.Size = new System.Drawing.Size(69, 28);
            this.labelClock.TabIndex = 2;
            this.labelClock.Text = "label1";
            // 
            // panelSecondForm
            // 
            this.panelSecondForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(120)))), ((int)(((byte)(180)))));
            this.panelSecondForm.Controls.Add(this.labelClock);
            this.panelSecondForm.Controls.Add(this.labelTime);
            this.panelSecondForm.Controls.Add(this.pictureBox1);
            this.panelSecondForm.Location = new System.Drawing.Point(201, 11);
            this.panelSecondForm.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelSecondForm.Name = "panelSecondForm";
            this.panelSecondForm.Size = new System.Drawing.Size(1281, 653);
            this.panelSecondForm.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(83, 101);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1068, 469);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(1494, 675);
            this.Controls.Add(this.panelSecondForm);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MenuForm";
            this.Text = "ROPark";
            this.panel1.ResumeLayout(false);
            this.panelSecondForm.ResumeLayout(false);
            this.panelSecondForm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonHome;
        private System.Windows.Forms.Button buttonPark;
        private System.Windows.Forms.Button buttonSignIn;
        private System.Windows.Forms.Button buttonSignUp;
        private System.Windows.Forms.Button buttonAccount;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.Label labelClock;
        private System.Windows.Forms.Panel panelSecondForm;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button buttonExit;
    }
}