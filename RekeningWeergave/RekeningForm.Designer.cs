namespace RekeningWeergave
{
    partial class RekeningForm
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblTotaalPrijsTekst = new System.Windows.Forms.Label();
            this.lblTotaalprijs = new System.Windows.Forms.Label();
            this.lblBtwLaag = new System.Windows.Forms.Label();
            this.lblBtw6Tekst = new System.Windows.Forms.Label();
            this.lblBtw21Tekst = new System.Windows.Forms.Label();
            this.lblBtwHoog = new System.Windows.Forms.Label();
            this.cbBetaalwijze = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBetalen = new System.Windows.Forms.Button();
            this.txtFooi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnTerug = new System.Windows.Forms.Button();
            this.lvRekening = new System.Windows.Forms.ListView();
            this.lblTafelnummer = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::RekeningWeergave.Properties.Resources.Logo2;
            this.pictureBox1.Location = new System.Drawing.Point(12, 247);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(270, 154);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // lblTotaalPrijsTekst
            // 
            this.lblTotaalPrijsTekst.AutoSize = true;
            this.lblTotaalPrijsTekst.Location = new System.Drawing.Point(318, 375);
            this.lblTotaalPrijsTekst.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTotaalPrijsTekst.Name = "lblTotaalPrijsTekst";
            this.lblTotaalPrijsTekst.Size = new System.Drawing.Size(58, 13);
            this.lblTotaalPrijsTekst.TabIndex = 2;
            this.lblTotaalPrijsTekst.Text = "Totaalprijs:";
            // 
            // lblTotaalprijs
            // 
            this.lblTotaalprijs.AutoSize = true;
            this.lblTotaalprijs.Location = new System.Drawing.Point(408, 375);
            this.lblTotaalprijs.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTotaalprijs.Name = "lblTotaalprijs";
            this.lblTotaalprijs.Size = new System.Drawing.Size(65, 13);
            this.lblTotaalprijs.TabIndex = 3;
            this.lblTotaalprijs.Text = "lblTotaalprijs";
            // 
            // lblBtwLaag
            // 
            this.lblBtwLaag.AutoSize = true;
            this.lblBtwLaag.Location = new System.Drawing.Point(419, 271);
            this.lblBtwLaag.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBtwLaag.Name = "lblBtwLaag";
            this.lblBtwLaag.Size = new System.Drawing.Size(54, 13);
            this.lblBtwLaag.TabIndex = 4;
            this.lblBtwLaag.Text = "lblBTW06";
            // 
            // lblBtw6Tekst
            // 
            this.lblBtw6Tekst.AutoSize = true;
            this.lblBtw6Tekst.Location = new System.Drawing.Point(302, 271);
            this.lblBtw6Tekst.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBtw6Tekst.Name = "lblBtw6Tekst";
            this.lblBtw6Tekst.Size = new System.Drawing.Size(74, 13);
            this.lblBtw6Tekst.TabIndex = 5;
            this.lblBtw6Tekst.Text = "Btw-tarief(6%):";
            // 
            // lblBtw21Tekst
            // 
            this.lblBtw21Tekst.AutoSize = true;
            this.lblBtw21Tekst.Location = new System.Drawing.Point(296, 325);
            this.lblBtw21Tekst.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBtw21Tekst.Name = "lblBtw21Tekst";
            this.lblBtw21Tekst.Size = new System.Drawing.Size(80, 13);
            this.lblBtw21Tekst.TabIndex = 6;
            this.lblBtw21Tekst.Text = "Btw-tarief(21%):";
            // 
            // lblBtwHoog
            // 
            this.lblBtwHoog.AutoSize = true;
            this.lblBtwHoog.Location = new System.Drawing.Point(419, 325);
            this.lblBtwHoog.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBtwHoog.Name = "lblBtwHoog";
            this.lblBtwHoog.Size = new System.Drawing.Size(54, 13);
            this.lblBtwHoog.TabIndex = 7;
            this.lblBtwHoog.Text = "lblBTW21";
            // 
            // cbBetaalwijze
            // 
            this.cbBetaalwijze.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBetaalwijze.FormattingEnabled = true;
            this.cbBetaalwijze.Location = new System.Drawing.Point(255, 511);
            this.cbBetaalwijze.Margin = new System.Windows.Forms.Padding(2);
            this.cbBetaalwijze.Name = "cbBetaalwijze";
            this.cbBetaalwijze.Size = new System.Drawing.Size(92, 21);
            this.cbBetaalwijze.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(133, 511);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Betaalwijze:";
            // 
            // btnBetalen
            // 
            this.btnBetalen.Location = new System.Drawing.Point(124, 575);
            this.btnBetalen.Margin = new System.Windows.Forms.Padding(2);
            this.btnBetalen.Name = "btnBetalen";
            this.btnBetalen.Size = new System.Drawing.Size(62, 24);
            this.btnBetalen.TabIndex = 10;
            this.btnBetalen.Text = "Betalen";
            this.btnBetalen.UseVisualStyleBackColor = true;
            this.btnBetalen.Click += new System.EventHandler(this.btnBetalen_Click);
            // 
            // txtFooi
            // 
            this.txtFooi.Location = new System.Drawing.Point(255, 448);
            this.txtFooi.Name = "txtFooi";
            this.txtFooi.Size = new System.Drawing.Size(92, 20);
            this.txtFooi.TabIndex = 11;
            this.txtFooi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFooi_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(133, 448);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Fooi:";
            // 
            // btnTerug
            // 
            this.btnTerug.Location = new System.Drawing.Point(272, 576);
            this.btnTerug.Name = "btnTerug";
            this.btnTerug.Size = new System.Drawing.Size(75, 23);
            this.btnTerug.TabIndex = 13;
            this.btnTerug.Text = "Terug";
            this.btnTerug.UseVisualStyleBackColor = true;
            this.btnTerug.Click += new System.EventHandler(this.btnTerug_Click);
            // 
            // lvRekening
            // 
            this.lvRekening.FullRowSelect = true;
            this.lvRekening.GridLines = true;
            this.lvRekening.Location = new System.Drawing.Point(22, 56);
            this.lvRekening.Margin = new System.Windows.Forms.Padding(2);
            this.lvRekening.Name = "lvRekening";
            this.lvRekening.Size = new System.Drawing.Size(451, 155);
            this.lvRekening.TabIndex = 14;
            this.lvRekening.UseCompatibleStateImageBehavior = false;
            this.lvRekening.View = System.Windows.Forms.View.Details;
            // 
            // lblTafelnummer
            // 
            this.lblTafelnummer.AutoSize = true;
            this.lblTafelnummer.Location = new System.Drawing.Point(208, 22);
            this.lblTafelnummer.Name = "lblTafelnummer";
            this.lblTafelnummer.Size = new System.Drawing.Size(43, 13);
            this.lblTafelnummer.TabIndex = 15;
            this.lblTafelnummer.Text = "Tafel: 1";
            // 
            // RekeningForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(494, 611);
            this.Controls.Add(this.lblTafelnummer);
            this.Controls.Add(this.lvRekening);
            this.Controls.Add(this.btnTerug);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtFooi);
            this.Controls.Add(this.btnBetalen);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbBetaalwijze);
            this.Controls.Add(this.lblBtwHoog);
            this.Controls.Add(this.lblBtw21Tekst);
            this.Controls.Add(this.lblBtw6Tekst);
            this.Controls.Add(this.lblBtwLaag);
            this.Controls.Add(this.lblTotaalprijs);
            this.Controls.Add(this.lblTotaalPrijsTekst);
            this.Controls.Add(this.pictureBox1);
            this.Name = "RekeningForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rekening";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblTotaalPrijsTekst;
        private System.Windows.Forms.Label lblTotaalprijs;
        private System.Windows.Forms.Label lblBtwLaag;
        private System.Windows.Forms.Label lblBtw6Tekst;
        private System.Windows.Forms.Label lblBtw21Tekst;
        private System.Windows.Forms.Label lblBtwHoog;
        private System.Windows.Forms.ComboBox cbBetaalwijze;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBetalen;
        private System.Windows.Forms.TextBox txtFooi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnTerug;
        private System.Windows.Forms.ListView lvRekening;
        private System.Windows.Forms.Label lblTafelnummer;
    }
}

