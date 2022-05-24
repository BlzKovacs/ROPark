namespace ROPark_II
{
    partial class AdminForm
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
            this.label6 = new System.Windows.Forms.Label();
            this.listBoxHistory = new System.Windows.Forms.ListBox();
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.buttonSignOut = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.listBoxParkPlaces = new System.Windows.Forms.ListBox();
            this.listBoxRegions = new System.Windows.Forms.ListBox();
            this.listBoxCities = new System.Windows.Forms.ListBox();
            this.listBoxUsers = new System.Windows.Forms.ListBox();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonEnter = new System.Windows.Forms.Button();
            this.labelWelcome = new System.Windows.Forms.Label();
            this.panelSecondForm.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelSecondForm
            // 
            this.panelSecondForm.Controls.Add(this.label6);
            this.panelSecondForm.Controls.Add(this.listBoxHistory);
            this.panelSecondForm.Controls.Add(this.buttonRefresh);
            this.panelSecondForm.Controls.Add(this.buttonSignOut);
            this.panelSecondForm.Controls.Add(this.label4);
            this.panelSecondForm.Controls.Add(this.label3);
            this.panelSecondForm.Controls.Add(this.label2);
            this.panelSecondForm.Controls.Add(this.label1);
            this.panelSecondForm.Controls.Add(this.listBoxParkPlaces);
            this.panelSecondForm.Controls.Add(this.listBoxRegions);
            this.panelSecondForm.Controls.Add(this.listBoxCities);
            this.panelSecondForm.Controls.Add(this.listBoxUsers);
            this.panelSecondForm.Controls.Add(this.buttonDelete);
            this.panelSecondForm.Controls.Add(this.buttonEdit);
            this.panelSecondForm.Controls.Add(this.buttonEnter);
            this.panelSecondForm.Controls.Add(this.labelWelcome);
            this.panelSecondForm.Location = new System.Drawing.Point(3, 1);
            this.panelSecondForm.Name = "panelSecondForm";
            this.panelSecondForm.Size = new System.Drawing.Size(1281, 653);
            this.panelSecondForm.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(143, 437);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(129, 20);
            this.label6.TabIndex = 44;
            this.label6.Text = "Parking History:";
            // 
            // listBoxHistory
            // 
            this.listBoxHistory.FormattingEnabled = true;
            this.listBoxHistory.HorizontalScrollbar = true;
            this.listBoxHistory.ItemHeight = 16;
            this.listBoxHistory.Location = new System.Drawing.Point(139, 473);
            this.listBoxHistory.Name = "listBoxHistory";
            this.listBoxHistory.Size = new System.Drawing.Size(940, 116);
            this.listBoxHistory.TabIndex = 42;
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.BackColor = System.Drawing.Color.SteelBlue;
            this.buttonRefresh.Location = new System.Drawing.Point(798, 29);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(104, 40);
            this.buttonRefresh.TabIndex = 41;
            this.buttonRefresh.Text = "Refresh";
            this.buttonRefresh.UseVisualStyleBackColor = false;
            this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
            // 
            // buttonSignOut
            // 
            this.buttonSignOut.BackColor = System.Drawing.Color.SteelBlue;
            this.buttonSignOut.Location = new System.Drawing.Point(948, 29);
            this.buttonSignOut.Name = "buttonSignOut";
            this.buttonSignOut.Size = new System.Drawing.Size(104, 40);
            this.buttonSignOut.TabIndex = 40;
            this.buttonSignOut.Text = "Sign out";
            this.buttonSignOut.UseVisualStyleBackColor = false;
            this.buttonSignOut.Click += new System.EventHandler(this.buttonSignOut_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(421, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 20);
            this.label4.TabIndex = 39;
            this.label4.Text = "Cities entered";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(671, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 20);
            this.label3.TabIndex = 38;
            this.label3.Text = "Regions entered";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(915, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 20);
            this.label2.TabIndex = 37;
            this.label2.Text = "ParkPlaces entered";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(157, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 20);
            this.label1.TabIndex = 36;
            this.label1.Text = "Users entered";
            // 
            // listBoxParkPlaces
            // 
            this.listBoxParkPlaces.FormattingEnabled = true;
            this.listBoxParkPlaces.HorizontalScrollbar = true;
            this.listBoxParkPlaces.ItemHeight = 16;
            this.listBoxParkPlaces.Location = new System.Drawing.Point(909, 137);
            this.listBoxParkPlaces.Name = "listBoxParkPlaces";
            this.listBoxParkPlaces.Size = new System.Drawing.Size(170, 180);
            this.listBoxParkPlaces.TabIndex = 35;
            this.listBoxParkPlaces.SelectedIndexChanged += new System.EventHandler(this.listBoxParkPlaces_SelectedIndexChanged);
            // 
            // listBoxRegions
            // 
            this.listBoxRegions.FormattingEnabled = true;
            this.listBoxRegions.HorizontalScrollbar = true;
            this.listBoxRegions.ItemHeight = 16;
            this.listBoxRegions.Location = new System.Drawing.Point(658, 137);
            this.listBoxRegions.Name = "listBoxRegions";
            this.listBoxRegions.Size = new System.Drawing.Size(170, 180);
            this.listBoxRegions.TabIndex = 34;
            this.listBoxRegions.SelectedIndexChanged += new System.EventHandler(this.listBoxRegions_SelectedIndexChanged);
            // 
            // listBoxCities
            // 
            this.listBoxCities.FormattingEnabled = true;
            this.listBoxCities.HorizontalScrollbar = true;
            this.listBoxCities.ItemHeight = 16;
            this.listBoxCities.Location = new System.Drawing.Point(401, 137);
            this.listBoxCities.Name = "listBoxCities";
            this.listBoxCities.Size = new System.Drawing.Size(170, 180);
            this.listBoxCities.TabIndex = 33;
            this.listBoxCities.SelectedIndexChanged += new System.EventHandler(this.listBoxCities_SelectedIndexChanged);
            // 
            // listBoxUsers
            // 
            this.listBoxUsers.FormattingEnabled = true;
            this.listBoxUsers.HorizontalScrollbar = true;
            this.listBoxUsers.ItemHeight = 16;
            this.listBoxUsers.Location = new System.Drawing.Point(139, 137);
            this.listBoxUsers.Name = "listBoxUsers";
            this.listBoxUsers.Size = new System.Drawing.Size(170, 180);
            this.listBoxUsers.TabIndex = 32;
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackColor = System.Drawing.Color.SteelBlue;
            this.buttonDelete.Location = new System.Drawing.Point(828, 357);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(104, 40);
            this.buttonDelete.TabIndex = 31;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = false;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.BackColor = System.Drawing.Color.SteelBlue;
            this.buttonEdit.Location = new System.Drawing.Point(556, 357);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(108, 40);
            this.buttonEdit.TabIndex = 30;
            this.buttonEdit.Text = "Edit";
            this.buttonEdit.UseVisualStyleBackColor = false;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonEnter
            // 
            this.buttonEnter.BackColor = System.Drawing.Color.SteelBlue;
            this.buttonEnter.Location = new System.Drawing.Point(298, 357);
            this.buttonEnter.Name = "buttonEnter";
            this.buttonEnter.Size = new System.Drawing.Size(113, 40);
            this.buttonEnter.TabIndex = 29;
            this.buttonEnter.Text = "Enter";
            this.buttonEnter.UseVisualStyleBackColor = false;
            this.buttonEnter.Click += new System.EventHandler(this.buttonEnter_Click);
            // 
            // labelWelcome
            // 
            this.labelWelcome.AutoSize = true;
            this.labelWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWelcome.Location = new System.Drawing.Point(121, 34);
            this.labelWelcome.Name = "labelWelcome";
            this.labelWelcome.Size = new System.Drawing.Size(180, 25);
            this.labelWelcome.TabIndex = 28;
            this.labelWelcome.Text = "Admin control room";
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(120)))), ((int)(((byte)(180)))));
            this.ClientSize = new System.Drawing.Size(1263, 606);
            this.Controls.Add(this.panelSecondForm);
            this.Name = "AdminForm";
            this.Text = "adminForm";
            this.Load += new System.EventHandler(this.AdminForm_Load);
            this.panelSecondForm.ResumeLayout(false);
            this.panelSecondForm.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelSecondForm;
        private System.Windows.Forms.Button buttonSignOut;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBoxParkPlaces;
        private System.Windows.Forms.ListBox listBoxRegions;
        private System.Windows.Forms.ListBox listBoxCities;
        private System.Windows.Forms.ListBox listBoxUsers;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonEnter;
        private System.Windows.Forms.Label labelWelcome;
        private System.Windows.Forms.Button buttonRefresh;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox listBoxHistory;
    }
}