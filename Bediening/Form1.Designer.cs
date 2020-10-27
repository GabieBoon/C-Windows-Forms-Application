namespace Bediening
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
            this.DrankenPanel = new System.Windows.Forms.TabControl();
            this.Lunch = new System.Windows.Forms.TabPage();
            this.LunchPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.Diner = new System.Windows.Forms.TabPage();
            this.DinerPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.Dranken = new System.Windows.Forms.TabPage();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel4 = new System.Windows.Forms.FlowLayoutPanel();
            this.Alcohol = new System.Windows.Forms.TabPage();
            this.AlcoholPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel6 = new System.Windows.Forms.FlowLayoutPanel();
            this.Bevestig_Button = new System.Windows.Forms.Button();
            this.tafel_nummer = new System.Windows.Forms.Label();
            this.Terug = new System.Windows.Forms.Button();
            this.Uitloggen = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.DrankenPanel.SuspendLayout();
            this.Lunch.SuspendLayout();
            this.Diner.SuspendLayout();
            this.Dranken.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            this.Alcohol.SuspendLayout();
            this.AlcoholPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // DrankenPanel
            // 
            this.DrankenPanel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.DrankenPanel.Controls.Add(this.Lunch);
            this.DrankenPanel.Controls.Add(this.Diner);
            this.DrankenPanel.Controls.Add(this.Dranken);
            this.DrankenPanel.Controls.Add(this.Alcohol);
            this.DrankenPanel.ItemSize = new System.Drawing.Size(110, 60);
            this.DrankenPanel.Location = new System.Drawing.Point(0, 39);
            this.DrankenPanel.Multiline = true;
            this.DrankenPanel.Name = "DrankenPanel";
            this.DrankenPanel.SelectedIndex = 0;
            this.DrankenPanel.Size = new System.Drawing.Size(494, 511);
            this.DrankenPanel.TabIndex = 4;
            this.DrankenPanel.Tag = "";
            // 
            // Lunch
            // 
            this.Lunch.AutoScroll = true;
            this.Lunch.Controls.Add(this.LunchPanel);
            this.Lunch.Location = new System.Drawing.Point(4, 64);
            this.Lunch.Name = "Lunch";
            this.Lunch.Padding = new System.Windows.Forms.Padding(3);
            this.Lunch.Size = new System.Drawing.Size(486, 443);
            this.Lunch.TabIndex = 0;
            this.Lunch.Tag = "lunch";
            this.Lunch.Text = "  Lunch  ";
            this.Lunch.UseVisualStyleBackColor = true;
            // 
            // LunchPanel
            // 
            this.LunchPanel.AutoScroll = true;
            this.LunchPanel.AutoSize = true;
            this.LunchPanel.BackColor = System.Drawing.Color.Transparent;
            this.LunchPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.LunchPanel.Location = new System.Drawing.Point(-4, 0);
            this.LunchPanel.Name = "LunchPanel";
            this.LunchPanel.Size = new System.Drawing.Size(473, 511);
            this.LunchPanel.TabIndex = 45;
            // 
            // Diner
            // 
            this.Diner.AutoScroll = true;
            this.Diner.Controls.Add(this.DinerPanel);
            this.Diner.Location = new System.Drawing.Point(4, 64);
            this.Diner.Name = "Diner";
            this.Diner.Padding = new System.Windows.Forms.Padding(3);
            this.Diner.Size = new System.Drawing.Size(486, 443);
            this.Diner.TabIndex = 1;
            this.Diner.Tag = "diner";
            this.Diner.Text = "  Diner  ";
            this.Diner.UseVisualStyleBackColor = true;
            // 
            // DinerPanel
            // 
            this.DinerPanel.AutoScroll = true;
            this.DinerPanel.AutoSize = true;
            this.DinerPanel.BackColor = System.Drawing.Color.Transparent;
            this.DinerPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.DinerPanel.Location = new System.Drawing.Point(0, 0);
            this.DinerPanel.Name = "DinerPanel";
            this.DinerPanel.Size = new System.Drawing.Size(464, 655);
            this.DinerPanel.TabIndex = 46;
            // 
            // Dranken
            // 
            this.Dranken.AutoScroll = true;
            this.Dranken.Controls.Add(this.flowLayoutPanel3);
            this.Dranken.Location = new System.Drawing.Point(4, 64);
            this.Dranken.Name = "Dranken";
            this.Dranken.Padding = new System.Windows.Forms.Padding(3);
            this.Dranken.Size = new System.Drawing.Size(486, 443);
            this.Dranken.TabIndex = 2;
            this.Dranken.Tag = "dranken";
            this.Dranken.Text = "  Dranken  ";
            this.Dranken.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.AutoScroll = true;
            this.flowLayoutPanel3.AutoSize = true;
            this.flowLayoutPanel3.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanel3.Controls.Add(this.flowLayoutPanel4);
            this.flowLayoutPanel3.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel3.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(455, 503);
            this.flowLayoutPanel3.TabIndex = 47;
            // 
            // flowLayoutPanel4
            // 
            this.flowLayoutPanel4.AutoScroll = true;
            this.flowLayoutPanel4.AutoSize = true;
            this.flowLayoutPanel4.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanel4.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel4.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel4.Name = "flowLayoutPanel4";
            this.flowLayoutPanel4.Size = new System.Drawing.Size(0, 0);
            this.flowLayoutPanel4.TabIndex = 48;
            // 
            // Alcohol
            // 
            this.Alcohol.AutoScroll = true;
            this.Alcohol.Controls.Add(this.AlcoholPanel);
            this.Alcohol.Location = new System.Drawing.Point(4, 64);
            this.Alcohol.Name = "Alcohol";
            this.Alcohol.Padding = new System.Windows.Forms.Padding(3);
            this.Alcohol.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Alcohol.Size = new System.Drawing.Size(486, 443);
            this.Alcohol.TabIndex = 3;
            this.Alcohol.Tag = "alcohol";
            this.Alcohol.Text = "  Alcohol  ";
            this.Alcohol.UseVisualStyleBackColor = true;
            // 
            // AlcoholPanel
            // 
            this.AlcoholPanel.AutoScroll = true;
            this.AlcoholPanel.AutoSize = true;
            this.AlcoholPanel.BackColor = System.Drawing.Color.Transparent;
            this.AlcoholPanel.Controls.Add(this.flowLayoutPanel6);
            this.AlcoholPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.AlcoholPanel.Location = new System.Drawing.Point(3, 1);
            this.AlcoholPanel.Name = "AlcoholPanel";
            this.AlcoholPanel.Size = new System.Drawing.Size(466, 734);
            this.AlcoholPanel.TabIndex = 48;
            // 
            // flowLayoutPanel6
            // 
            this.flowLayoutPanel6.AutoScroll = true;
            this.flowLayoutPanel6.AutoSize = true;
            this.flowLayoutPanel6.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanel6.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel6.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel6.Name = "flowLayoutPanel6";
            this.flowLayoutPanel6.Size = new System.Drawing.Size(0, 0);
            this.flowLayoutPanel6.TabIndex = 48;
            // 
            // Bevestig_Button
            // 
            this.Bevestig_Button.Location = new System.Drawing.Point(221, 565);
            this.Bevestig_Button.Name = "Bevestig_Button";
            this.Bevestig_Button.Size = new System.Drawing.Size(100, 34);
            this.Bevestig_Button.TabIndex = 0;
            this.Bevestig_Button.Text = "Naar Bevestigen";
            this.Bevestig_Button.UseVisualStyleBackColor = true;
            this.Bevestig_Button.Click += new System.EventHandler(this.Bevestig_Button_Click);
            // 
            // tafel_nummer
            // 
            this.tafel_nummer.AutoSize = true;
            this.tafel_nummer.BackColor = System.Drawing.Color.Transparent;
            this.tafel_nummer.Location = new System.Drawing.Point(199, 12);
            this.tafel_nummer.Name = "tafel_nummer";
            this.tafel_nummer.Size = new System.Drawing.Size(35, 13);
            this.tafel_nummer.TabIndex = 5;
            this.tafel_nummer.Text = "label1";
            this.tafel_nummer.Click += new System.EventHandler(this.tafel_nummer_Click);
            // 
            // Terug
            // 
            this.Terug.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Terug.Location = new System.Drawing.Point(390, 565);
            this.Terug.Name = "Terug";
            this.Terug.Size = new System.Drawing.Size(74, 34);
            this.Terug.TabIndex = 6;
            this.Terug.Text = "Terug";
            this.Terug.UseVisualStyleBackColor = false;
            this.Terug.Click += new System.EventHandler(this.Terug_Click);
            // 
            // Uitloggen
            // 
            this.Uitloggen.Location = new System.Drawing.Point(407, 12);
            this.Uitloggen.Name = "Uitloggen";
            this.Uitloggen.Size = new System.Drawing.Size(74, 34);
            this.Uitloggen.TabIndex = 7;
            this.Uitloggen.Text = "Uitloggen";
            this.Uitloggen.UseVisualStyleBackColor = true;
            this.Uitloggen.Click += new System.EventHandler(this.Uitloggen_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 553);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(133, 553);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 586);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "label3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(133, 586);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "label4";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 553);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(13, 13);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(114, 552);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(13, 13);
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Location = new System.Drawing.Point(12, 586);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(13, 13);
            this.pictureBox3.TabIndex = 9;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Location = new System.Drawing.Point(114, 586);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(13, 13);
            this.pictureBox4.TabIndex = 10;
            this.pictureBox4.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(494, 611);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Terug);
            this.Controls.Add(this.Bevestig_Button);
            this.Controls.Add(this.Uitloggen);
            this.Controls.Add(this.tafel_nummer);
            this.Controls.Add(this.DrankenPanel);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bestellen";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.DrankenPanel.ResumeLayout(false);
            this.Lunch.ResumeLayout(false);
            this.Lunch.PerformLayout();
            this.Diner.ResumeLayout(false);
            this.Diner.PerformLayout();
            this.Dranken.ResumeLayout(false);
            this.Dranken.PerformLayout();
            this.flowLayoutPanel3.ResumeLayout(false);
            this.flowLayoutPanel3.PerformLayout();
            this.Alcohol.ResumeLayout(false);
            this.Alcohol.PerformLayout();
            this.AlcoholPanel.ResumeLayout(false);
            this.AlcoholPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TabControl DrankenPanel;
        private System.Windows.Forms.TabPage Lunch;
        private System.Windows.Forms.TabPage Diner;
        private System.Windows.Forms.FlowLayoutPanel LunchPanel;
        private System.Windows.Forms.TabPage Dranken;
        private System.Windows.Forms.FlowLayoutPanel DinerPanel;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.Button Bevestig_Button;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel4;
        private System.Windows.Forms.Label tafel_nummer;
        private System.Windows.Forms.Button Terug;
        private System.Windows.Forms.Button Uitloggen;
        private System.Windows.Forms.TabPage Alcohol;
        private System.Windows.Forms.FlowLayoutPanel AlcoholPanel;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
    }
}

