namespace ROPark_II
{
    partial class EditCityForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxOld = new System.Windows.Forms.TextBox();
            this.textBoxNew = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.listBoxRegions = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonEnter = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.listBoxParkPlaces = new System.Windows.Forms.ListBox();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(122, 163);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Current City name:";
            // 
            // textBoxOld
            // 
            this.textBoxOld.Location = new System.Drawing.Point(242, 157);
            this.textBoxOld.Name = "textBoxOld";
            this.textBoxOld.ReadOnly = true;
            this.textBoxOld.Size = new System.Drawing.Size(134, 22);
            this.textBoxOld.TabIndex = 1;
            // 
            // textBoxNew
            // 
            this.textBoxNew.Location = new System.Drawing.Point(242, 213);
            this.textBoxNew.Name = "textBoxNew";
            this.textBoxNew.Size = new System.Drawing.Size(134, 22);
            this.textBoxNew.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(137, 219);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "New City name:";
            // 
            // listBoxRegions
            // 
            this.listBoxRegions.FormattingEnabled = true;
            this.listBoxRegions.ItemHeight = 16;
            this.listBoxRegions.Location = new System.Drawing.Point(450, 146);
            this.listBoxRegions.Name = "listBoxRegions";
            this.listBoxRegions.Size = new System.Drawing.Size(120, 148);
            this.listBoxRegions.TabIndex = 4;
            this.listBoxRegions.SelectedIndexChanged += new System.EventHandler(this.listBoxRegions_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(461, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Regions of City";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(40, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(176, 22);
            this.label4.TabIndex = 6;
            this.label4.Text = "Enter new City name";
            // 
            // buttonEnter
            // 
            this.buttonEnter.BackColor = System.Drawing.Color.SteelBlue;
            this.buttonEnter.Location = new System.Drawing.Point(308, 276);
            this.buttonEnter.Name = "buttonEnter";
            this.buttonEnter.Size = new System.Drawing.Size(94, 28);
            this.buttonEnter.TabIndex = 7;
            this.buttonEnter.Text = "Enter";
            this.buttonEnter.UseVisualStyleBackColor = false;
            this.buttonEnter.Click += new System.EventHandler(this.buttonEnter_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(597, 127);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(159, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "Parking Places of Region";
            // 
            // listBoxParkPlaces
            // 
            this.listBoxParkPlaces.FormattingEnabled = true;
            this.listBoxParkPlaces.ItemHeight = 16;
            this.listBoxParkPlaces.Location = new System.Drawing.Point(614, 146);
            this.listBoxParkPlaces.Name = "listBoxParkPlaces";
            this.listBoxParkPlaces.Size = new System.Drawing.Size(120, 148);
            this.listBoxParkPlaces.TabIndex = 9;
            // 
            // buttonCancel
            // 
            this.buttonCancel.BackColor = System.Drawing.Color.SteelBlue;
            this.buttonCancel.Location = new System.Drawing.Point(189, 276);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(94, 28);
            this.buttonCancel.TabIndex = 10;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = false;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // EditCityForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(120)))), ((int)(((byte)(180)))));
            this.ClientSize = new System.Drawing.Size(1263, 606);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.listBoxParkPlaces);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.buttonEnter);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.listBoxRegions);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxNew);
            this.Controls.Add(this.textBoxOld);
            this.Controls.Add(this.label1);
            this.Name = "EditCityForm";
            this.Text = "EditCityForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxOld;
        private System.Windows.Forms.TextBox textBoxNew;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listBoxRegions;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonEnter;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox listBoxParkPlaces;
        private System.Windows.Forms.Button buttonCancel;
    }
}