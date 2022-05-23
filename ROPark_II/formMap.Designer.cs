namespace Proiect_II
{
    partial class formMap
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
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.pannel_menu = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.listView_parkingPlace = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.listView_Regiuni = new System.Windows.Forms.ListView();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.pictureBox_Romania = new System.Windows.Forms.PictureBox();
            this.groupBox_currentCity = new System.Windows.Forms.GroupBox();
            this.label_orasSelectat = new System.Windows.Forms.Label();
            this.pannel_menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Romania)).BeginInit();
            this.groupBox_currentCity.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // pannel_menu
            // 
            this.pannel_menu.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pannel_menu.Controls.Add(this.label2);
            this.pannel_menu.Controls.Add(this.listView_parkingPlace);
            this.pannel_menu.Controls.Add(this.label1);
            this.pannel_menu.Controls.Add(this.listView_Regiuni);
            this.pannel_menu.Controls.Add(this.buttonSearch);
            this.pannel_menu.Location = new System.Drawing.Point(3, 61);
            this.pannel_menu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pannel_menu.Name = "pannel_menu";
            this.pannel_menu.Size = new System.Drawing.Size(236, 550);
            this.pannel_menu.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 195);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Locuri parcare:";
            // 
            // listView_parkingPlace
            // 
            this.listView_parkingPlace.HideSelection = false;
            this.listView_parkingPlace.Location = new System.Drawing.Point(2, 214);
            this.listView_parkingPlace.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listView_parkingPlace.Name = "listView_parkingPlace";
            this.listView_parkingPlace.Size = new System.Drawing.Size(231, 149);
            this.listView_parkingPlace.TabIndex = 5;
            this.listView_parkingPlace.UseCompatibleStateImageBehavior = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Regiuni:";
            // 
            // listView_Regiuni
            // 
            this.listView_Regiuni.HideSelection = false;
            this.listView_Regiuni.Location = new System.Drawing.Point(3, 26);
            this.listView_Regiuni.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listView_Regiuni.Name = "listView_Regiuni";
            this.listView_Regiuni.Size = new System.Drawing.Size(231, 149);
            this.listView_Regiuni.TabIndex = 3;
            this.listView_Regiuni.UseCompatibleStateImageBehavior = false;
            this.listView_Regiuni.SelectedIndexChanged += new System.EventHandler(this.listView_Regiuni_SelectedIndexChanged);
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(1, 367);
            this.buttonSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(235, 38);
            this.buttonSearch.TabIndex = 2;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // pictureBox_Romania
            // 
            this.pictureBox_Romania.Location = new System.Drawing.Point(244, -1);
            this.pictureBox_Romania.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox_Romania.Name = "pictureBox_Romania";
            this.pictureBox_Romania.Size = new System.Drawing.Size(828, 612);
            this.pictureBox_Romania.TabIndex = 2;
            this.pictureBox_Romania.TabStop = false;
            this.pictureBox_Romania.Click += new System.EventHandler(this.pictureBox_Romania_Click);
            this.pictureBox_Romania.Paint += new System.Windows.Forms.PaintEventHandler(this.pbImage_Paint);
            this.pictureBox_Romania.MouseClick += new System.Windows.Forms.MouseEventHandler(this.clickOnImage);
            // 
            // groupBox_currentCity
            // 
            this.groupBox_currentCity.Controls.Add(this.label_orasSelectat);
            this.groupBox_currentCity.Location = new System.Drawing.Point(11, 10);
            this.groupBox_currentCity.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox_currentCity.Name = "groupBox_currentCity";
            this.groupBox_currentCity.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox_currentCity.Size = new System.Drawing.Size(217, 46);
            this.groupBox_currentCity.TabIndex = 4;
            this.groupBox_currentCity.TabStop = false;
            this.groupBox_currentCity.Text = "Oras Selectat:";
            // 
            // label_orasSelectat
            // 
            this.label_orasSelectat.AutoSize = true;
            this.label_orasSelectat.Location = new System.Drawing.Point(49, 28);
            this.label_orasSelectat.Name = "label_orasSelectat";
            this.label_orasSelectat.Size = new System.Drawing.Size(30, 17);
            this.label_orasSelectat.TabIndex = 4;
            this.label_orasSelectat.Text = "- ; -";
            // 
            // formMap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1070, 611);
            this.Controls.Add(this.groupBox_currentCity);
            this.Controls.Add(this.pictureBox_Romania);
            this.Controls.Add(this.pannel_menu);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "formMap";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pannel_menu.ResumeLayout(false);
            this.pannel_menu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Romania)).EndInit();
            this.groupBox_currentCity.ResumeLayout(false);
            this.groupBox_currentCity.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Panel pannel_menu;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.PictureBox pictureBox_Romania;
        private System.Windows.Forms.GroupBox groupBox_currentCity;
        private System.Windows.Forms.Label label_orasSelectat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listView_Regiuni;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView listView_parkingPlace;
    }
}

