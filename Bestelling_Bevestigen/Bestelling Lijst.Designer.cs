namespace Bestelling_Bevestigen
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Bestel_Lijst = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.Bevestig_Update_button = new System.Windows.Forms.Button();
            this.Bestellingen_lijst = new System.Windows.Forms.ListView();
            this.Naam_Gerecht = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Aantal = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.BTN_Uitloggen = new System.Windows.Forms.Button();
            this.tafel_nummer = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.Bestel_Lijst.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(135, 48);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.Bestel_Lijst);
            this.tabControl1.Location = new System.Drawing.Point(7, 85);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(464, 524);
            this.tabControl1.TabIndex = 5;
            this.tabControl1.Tag = "";
            // 
            // Bestel_Lijst
            // 
            this.Bestel_Lijst.Controls.Add(this.button1);
            this.Bestel_Lijst.Controls.Add(this.Bevestig_Update_button);
            this.Bestel_Lijst.Controls.Add(this.Bestellingen_lijst);
            this.Bestel_Lijst.Location = new System.Drawing.Point(4, 22);
            this.Bestel_Lijst.Name = "Bestel_Lijst";
            this.Bestel_Lijst.Padding = new System.Windows.Forms.Padding(3);
            this.Bestel_Lijst.Size = new System.Drawing.Size(456, 498);
            this.Bestel_Lijst.TabIndex = 0;
            this.Bestel_Lijst.Text = "Bestel Lijst";
            this.Bestel_Lijst.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(379, 458);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(74, 34);
            this.button1.TabIndex = 3;
            this.button1.Text = "Terug";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Bevestig_Update_button
            // 
            this.Bevestig_Update_button.Location = new System.Drawing.Point(235, 458);
            this.Bevestig_Update_button.Name = "Bevestig_Update_button";
            this.Bevestig_Update_button.Size = new System.Drawing.Size(74, 34);
            this.Bevestig_Update_button.TabIndex = 2;
            this.Bevestig_Update_button.Text = "Bevestigen";
            this.Bevestig_Update_button.UseVisualStyleBackColor = true;
            this.Bevestig_Update_button.Click += new System.EventHandler(this.Bevestig_button_Click);
            // 
            // Bestellingen_lijst
            // 
            this.Bestellingen_lijst.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Naam_Gerecht,
            this.Aantal});
            this.Bestellingen_lijst.Location = new System.Drawing.Point(1, 0);
            this.Bestellingen_lijst.Name = "Bestellingen_lijst";
            this.Bestellingen_lijst.Size = new System.Drawing.Size(457, 440);
            this.Bestellingen_lijst.TabIndex = 1;
            this.Bestellingen_lijst.UseCompatibleStateImageBehavior = false;
            this.Bestellingen_lijst.View = System.Windows.Forms.View.Details;
            // 
            // Naam_Gerecht
            // 
            this.Naam_Gerecht.Text = "Gerecht";
            this.Naam_Gerecht.Width = 353;
            // 
            // Aantal
            // 
            this.Aantal.Text = "Aantal";
            this.Aantal.Width = 100;
            // 
            // BTN_Uitloggen
            // 
            this.BTN_Uitloggen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BTN_Uitloggen.Location = new System.Drawing.Point(397, 12);
            this.BTN_Uitloggen.Name = "BTN_Uitloggen";
            this.BTN_Uitloggen.Size = new System.Drawing.Size(74, 34);
            this.BTN_Uitloggen.TabIndex = 4;
            this.BTN_Uitloggen.Text = "Uitloggen";
            this.BTN_Uitloggen.UseVisualStyleBackColor = true;
            // 
            // tafel_nummer
            // 
            this.tafel_nummer.AutoSize = true;
            this.tafel_nummer.BackColor = System.Drawing.Color.Transparent;
            this.tafel_nummer.Location = new System.Drawing.Point(199, 23);
            this.tafel_nummer.Name = "tafel_nummer";
            this.tafel_nummer.Size = new System.Drawing.Size(35, 13);
            this.tafel_nummer.TabIndex = 7;
            this.tafel_nummer.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(494, 611);
            this.Controls.Add(this.tafel_nummer);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.BTN_Uitloggen);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Besteling Overzicht";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.Bestel_Lijst.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Bestel_Lijst;
        private System.Windows.Forms.Button Bevestig_Update_button;
        private System.Windows.Forms.ListView Bestellingen_lijst;
        private System.Windows.Forms.ColumnHeader Naam_Gerecht;
        private System.Windows.Forms.ColumnHeader Aantal;
        private System.Windows.Forms.Button BTN_Uitloggen;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label tafel_nummer;
    }
}

