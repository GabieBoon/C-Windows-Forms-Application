namespace OberTafeloverzicht
{
    partial class OberTafelOverzichtForm
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
            this.btn_Uitloggen = new System.Windows.Forms.Button();
            this.TafelOverzichtPanel = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.MeldGereed = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Bestellen = new System.Windows.Forms.TabPage();
            this.BestellenRekeningPanel = new System.Windows.Forms.Panel();
            this.lblTafelnummerMenuScherm = new System.Windows.Forms.Label();
            this.btn_TerugTussenscherm = new System.Windows.Forms.Button();
            this.btn_Afrekenen = new System.Windows.Forms.Button();
            this.btn_Bestellen = new System.Windows.Forms.Button();
            this.GroepklantenAanwijzenPanel = new System.Windows.Forms.Panel();
            this.lbl_TafelnummerToewijzen = new System.Windows.Forms.Label();
            this.lbl_AantalPersonenCijfer = new System.Windows.Forms.Label();
            this.btn_Min = new System.Windows.Forms.Button();
            this.btn_Plus = new System.Windows.Forms.Button();
            this.btn_TafelToewijzen = new System.Windows.Forms.Button();
            this.Lbl_AantalPersonen = new System.Windows.Forms.Label();
            this.btn_Terug = new System.Windows.Forms.Button();
            this.BestellingenKlaar = new System.Windows.Forms.TabPage();
            this.btn_OngedaanMaken = new System.Windows.Forms.Button();
            this.TafelOverzichtPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.Bestellen.SuspendLayout();
            this.BestellenRekeningPanel.SuspendLayout();
            this.GroepklantenAanwijzenPanel.SuspendLayout();
            this.BestellingenKlaar.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Uitloggen
            // 
            this.btn_Uitloggen.Location = new System.Drawing.Point(407, 12);
            this.btn_Uitloggen.Name = "btn_Uitloggen";
            this.btn_Uitloggen.Size = new System.Drawing.Size(75, 23);
            this.btn_Uitloggen.TabIndex = 0;
            this.btn_Uitloggen.Text = "Uitloggen";
            this.btn_Uitloggen.UseVisualStyleBackColor = true;
            this.btn_Uitloggen.Click += new System.EventHandler(this.btn_Uitloggen_Click);
            // 
            // TafelOverzichtPanel
            // 
            this.TafelOverzichtPanel.AutoSize = true;
            this.TafelOverzichtPanel.Controls.Add(this.pictureBox3);
            this.TafelOverzichtPanel.Controls.Add(this.pictureBox2);
            this.TafelOverzichtPanel.Controls.Add(this.pictureBox1);
            this.TafelOverzichtPanel.Controls.Add(this.label3);
            this.TafelOverzichtPanel.Controls.Add(this.label2);
            this.TafelOverzichtPanel.Controls.Add(this.label1);
            this.TafelOverzichtPanel.Location = new System.Drawing.Point(15, 0);
            this.TafelOverzichtPanel.Name = "TafelOverzichtPanel";
            this.TafelOverzichtPanel.Size = new System.Drawing.Size(447, 536);
            this.TafelOverzichtPanel.TabIndex = 1;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Red;
            this.pictureBox3.Location = new System.Drawing.Point(361, 506);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(13, 13);
            this.pictureBox3.TabIndex = 5;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.OrangeRed;
            this.pictureBox2.Location = new System.Drawing.Point(361, 475);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(13, 13);
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Green;
            this.pictureBox1.Location = new System.Drawing.Point(361, 440);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(13, 13);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(380, 506);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "besteld";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(380, 475);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "bezet";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(380, 440);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "vrij";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // MeldGereed
            // 
            this.MeldGereed.AutoSize = true;
            this.MeldGereed.Location = new System.Drawing.Point(217, 503);
            this.MeldGereed.Name = "MeldGereed";
            this.MeldGereed.Size = new System.Drawing.Size(81, 23);
            this.MeldGereed.TabIndex = 0;
            this.MeldGereed.Text = "Meld bezorgd";
            this.MeldGereed.UseVisualStyleBackColor = true;
            this.MeldGereed.Click += new System.EventHandler(this.MeldGereed_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Bestellen);
            this.tabControl1.Controls.Add(this.BestellingenKlaar);
            this.tabControl1.Location = new System.Drawing.Point(12, 41);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(470, 558);
            this.tabControl1.TabIndex = 2;
            // 
            // Bestellen
            // 
            this.Bestellen.Controls.Add(this.BestellenRekeningPanel);
            this.Bestellen.Controls.Add(this.GroepklantenAanwijzenPanel);
            this.Bestellen.Controls.Add(this.TafelOverzichtPanel);
            this.Bestellen.Location = new System.Drawing.Point(4, 22);
            this.Bestellen.Name = "Bestellen";
            this.Bestellen.Padding = new System.Windows.Forms.Padding(3);
            this.Bestellen.Size = new System.Drawing.Size(462, 532);
            this.Bestellen.TabIndex = 0;
            this.Bestellen.Text = "Bestellen";
            this.Bestellen.UseVisualStyleBackColor = true;
            // 
            // BestellenRekeningPanel
            // 
            this.BestellenRekeningPanel.Controls.Add(this.lblTafelnummerMenuScherm);
            this.BestellenRekeningPanel.Controls.Add(this.btn_TerugTussenscherm);
            this.BestellenRekeningPanel.Controls.Add(this.btn_Afrekenen);
            this.BestellenRekeningPanel.Controls.Add(this.btn_Bestellen);
            this.BestellenRekeningPanel.Location = new System.Drawing.Point(6, 6);
            this.BestellenRekeningPanel.Name = "BestellenRekeningPanel";
            this.BestellenRekeningPanel.Size = new System.Drawing.Size(453, 497);
            this.BestellenRekeningPanel.TabIndex = 3;
            this.BestellenRekeningPanel.Visible = false;
            // 
            // lblTafelnummerMenuScherm
            // 
            this.lblTafelnummerMenuScherm.AutoSize = true;
            this.lblTafelnummerMenuScherm.Location = new System.Drawing.Point(193, 77);
            this.lblTafelnummerMenuScherm.Name = "lblTafelnummerMenuScherm";
            this.lblTafelnummerMenuScherm.Size = new System.Drawing.Size(43, 13);
            this.lblTafelnummerMenuScherm.TabIndex = 3;
            this.lblTafelnummerMenuScherm.Text = "Tafel: 1";
            // 
            // btn_TerugTussenscherm
            // 
            this.btn_TerugTussenscherm.Location = new System.Drawing.Point(174, 427);
            this.btn_TerugTussenscherm.Name = "btn_TerugTussenscherm";
            this.btn_TerugTussenscherm.Size = new System.Drawing.Size(75, 23);
            this.btn_TerugTussenscherm.TabIndex = 2;
            this.btn_TerugTussenscherm.Text = "Terug";
            this.btn_TerugTussenscherm.UseVisualStyleBackColor = true;
            this.btn_TerugTussenscherm.Click += new System.EventHandler(this.btn_TerugTussenscherm_Click);
            // 
            // btn_Afrekenen
            // 
            this.btn_Afrekenen.Location = new System.Drawing.Point(174, 290);
            this.btn_Afrekenen.Name = "btn_Afrekenen";
            this.btn_Afrekenen.Size = new System.Drawing.Size(75, 23);
            this.btn_Afrekenen.TabIndex = 1;
            this.btn_Afrekenen.Text = "Afrekenen";
            this.btn_Afrekenen.UseVisualStyleBackColor = true;
            this.btn_Afrekenen.Click += new System.EventHandler(this.btn_Afrekenen_Click);
            // 
            // btn_Bestellen
            // 
            this.btn_Bestellen.Location = new System.Drawing.Point(174, 150);
            this.btn_Bestellen.Name = "btn_Bestellen";
            this.btn_Bestellen.Size = new System.Drawing.Size(75, 23);
            this.btn_Bestellen.TabIndex = 0;
            this.btn_Bestellen.Text = "Bestellen";
            this.btn_Bestellen.UseVisualStyleBackColor = true;
            this.btn_Bestellen.Click += new System.EventHandler(this.btn_Bestellen_Click);
            // 
            // GroepklantenAanwijzenPanel
            // 
            this.GroepklantenAanwijzenPanel.Controls.Add(this.lbl_TafelnummerToewijzen);
            this.GroepklantenAanwijzenPanel.Controls.Add(this.lbl_AantalPersonenCijfer);
            this.GroepklantenAanwijzenPanel.Controls.Add(this.btn_Min);
            this.GroepklantenAanwijzenPanel.Controls.Add(this.btn_Plus);
            this.GroepklantenAanwijzenPanel.Controls.Add(this.btn_TafelToewijzen);
            this.GroepklantenAanwijzenPanel.Controls.Add(this.Lbl_AantalPersonen);
            this.GroepklantenAanwijzenPanel.Controls.Add(this.btn_Terug);
            this.GroepklantenAanwijzenPanel.Location = new System.Drawing.Point(3, 6);
            this.GroepklantenAanwijzenPanel.Name = "GroepklantenAanwijzenPanel";
            this.GroepklantenAanwijzenPanel.Size = new System.Drawing.Size(459, 529);
            this.GroepklantenAanwijzenPanel.TabIndex = 0;
            this.GroepklantenAanwijzenPanel.Visible = false;
            // 
            // lbl_TafelnummerToewijzen
            // 
            this.lbl_TafelnummerToewijzen.AutoSize = true;
            this.lbl_TafelnummerToewijzen.Location = new System.Drawing.Point(193, 76);
            this.lbl_TafelnummerToewijzen.Name = "lbl_TafelnummerToewijzen";
            this.lbl_TafelnummerToewijzen.Size = new System.Drawing.Size(43, 13);
            this.lbl_TafelnummerToewijzen.TabIndex = 6;
            this.lbl_TafelnummerToewijzen.Text = "Tafel: 1";
            // 
            // lbl_AantalPersonenCijfer
            // 
            this.lbl_AantalPersonenCijfer.AutoSize = true;
            this.lbl_AantalPersonenCijfer.Location = new System.Drawing.Point(210, 170);
            this.lbl_AantalPersonenCijfer.Name = "lbl_AantalPersonenCijfer";
            this.lbl_AantalPersonenCijfer.Size = new System.Drawing.Size(13, 13);
            this.lbl_AantalPersonenCijfer.TabIndex = 5;
            this.lbl_AantalPersonenCijfer.Text = "1";
            // 
            // btn_Min
            // 
            this.btn_Min.Location = new System.Drawing.Point(180, 165);
            this.btn_Min.Name = "btn_Min";
            this.btn_Min.Size = new System.Drawing.Size(24, 23);
            this.btn_Min.TabIndex = 4;
            this.btn_Min.Text = "-";
            this.btn_Min.UseVisualStyleBackColor = true;
            this.btn_Min.Click += new System.EventHandler(this.btn_Min_Click);
            // 
            // btn_Plus
            // 
            this.btn_Plus.Location = new System.Drawing.Point(231, 165);
            this.btn_Plus.Name = "btn_Plus";
            this.btn_Plus.Size = new System.Drawing.Size(24, 23);
            this.btn_Plus.TabIndex = 3;
            this.btn_Plus.Text = "+";
            this.btn_Plus.UseVisualStyleBackColor = true;
            this.btn_Plus.Click += new System.EventHandler(this.btn_Plus_Click);
            // 
            // btn_TafelToewijzen
            // 
            this.btn_TafelToewijzen.Location = new System.Drawing.Point(168, 289);
            this.btn_TafelToewijzen.Name = "btn_TafelToewijzen";
            this.btn_TafelToewijzen.Size = new System.Drawing.Size(94, 23);
            this.btn_TafelToewijzen.TabIndex = 2;
            this.btn_TafelToewijzen.Text = "Tafel Toewijzen";
            this.btn_TafelToewijzen.UseVisualStyleBackColor = true;
            this.btn_TafelToewijzen.Click += new System.EventHandler(this.btn_TafelToewijzen_Click);
            // 
            // Lbl_AantalPersonen
            // 
            this.Lbl_AantalPersonen.AutoSize = true;
            this.Lbl_AantalPersonen.Location = new System.Drawing.Point(177, 149);
            this.Lbl_AantalPersonen.Name = "Lbl_AantalPersonen";
            this.Lbl_AantalPersonen.Size = new System.Drawing.Size(85, 13);
            this.Lbl_AantalPersonen.TabIndex = 1;
            this.Lbl_AantalPersonen.Text = "Aantal Personen";
            this.Lbl_AantalPersonen.Click += new System.EventHandler(this.Lbl_AantalPersonen_Click);
            // 
            // btn_Terug
            // 
            this.btn_Terug.Location = new System.Drawing.Point(180, 427);
            this.btn_Terug.Name = "btn_Terug";
            this.btn_Terug.Size = new System.Drawing.Size(75, 23);
            this.btn_Terug.TabIndex = 0;
            this.btn_Terug.Text = "Terug";
            this.btn_Terug.UseVisualStyleBackColor = true;
            this.btn_Terug.Click += new System.EventHandler(this.btn_Terug_Click);
            // 
            // BestellingenKlaar
            // 
            this.BestellingenKlaar.Controls.Add(this.btn_OngedaanMaken);
            this.BestellingenKlaar.Controls.Add(this.MeldGereed);
            this.BestellingenKlaar.Location = new System.Drawing.Point(4, 22);
            this.BestellingenKlaar.Name = "BestellingenKlaar";
            this.BestellingenKlaar.Padding = new System.Windows.Forms.Padding(3);
            this.BestellingenKlaar.Size = new System.Drawing.Size(462, 532);
            this.BestellingenKlaar.TabIndex = 1;
            this.BestellingenKlaar.Text = "Bestellingen klaar";
            this.BestellingenKlaar.UseVisualStyleBackColor = true;
            // 
            // btn_OngedaanMaken
            // 
            this.btn_OngedaanMaken.Location = new System.Drawing.Point(342, 503);
            this.btn_OngedaanMaken.Name = "btn_OngedaanMaken";
            this.btn_OngedaanMaken.Size = new System.Drawing.Size(104, 23);
            this.btn_OngedaanMaken.TabIndex = 1;
            this.btn_OngedaanMaken.Text = "Ongedaan maken";
            this.btn_OngedaanMaken.UseVisualStyleBackColor = true;
            this.btn_OngedaanMaken.Click += new System.EventHandler(this.btn_OngedaanMaken_Click);
            // 
            // OberTafelOverzichtForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(494, 611);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btn_Uitloggen);
            this.Name = "OberTafelOverzichtForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tafeloverzicht";
            this.TafelOverzichtPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.Bestellen.ResumeLayout(false);
            this.Bestellen.PerformLayout();
            this.BestellenRekeningPanel.ResumeLayout(false);
            this.BestellenRekeningPanel.PerformLayout();
            this.GroepklantenAanwijzenPanel.ResumeLayout(false);
            this.GroepklantenAanwijzenPanel.PerformLayout();
            this.BestellingenKlaar.ResumeLayout(false);
            this.BestellingenKlaar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Uitloggen;
        private System.Windows.Forms.Panel TafelOverzichtPanel;
        private System.Windows.Forms.Button MeldGereed;
        private System.Windows.Forms.TabPage Bestellen;
        private System.Windows.Forms.TabPage BestellingenKlaar;
        public System.Windows.Forms.ListView TeBezorgen;
        public System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.Panel GroepklantenAanwijzenPanel;
        private System.Windows.Forms.Button btn_TafelToewijzen;
        private System.Windows.Forms.Label Lbl_AantalPersonen;
        private System.Windows.Forms.Button btn_Terug;
        private System.Windows.Forms.Button btn_Min;
        private System.Windows.Forms.Button btn_Plus;
        private System.Windows.Forms.Label lbl_AantalPersonenCijfer;
        private System.Windows.Forms.Panel BestellenRekeningPanel;
        private System.Windows.Forms.Button btn_Afrekenen;
        private System.Windows.Forms.Button btn_Bestellen;
        private System.Windows.Forms.Button btn_TerugTussenscherm;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbl_TafelnummerToewijzen;
        private System.Windows.Forms.Label lblTafelnummerMenuScherm;
        private System.Windows.Forms.Button btn_OngedaanMaken;
    }
}

