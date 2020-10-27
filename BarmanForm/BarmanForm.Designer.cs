namespace BarmanForm
{
    partial class BarmanForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BarmanForm));
            this.BTN_Uitloggen = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.BTN_GereedMelden = new System.Windows.Forms.Button();
            this.LV_Orders = new System.Windows.Forms.ListView();
            this.Aantal = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Gerechten = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Tijd = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.BTN_Undo = new System.Windows.Forms.Button();
            this.LV_Gereed = new System.Windows.Forms.ListView();
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // BTN_Uitloggen
            // 
            this.BTN_Uitloggen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BTN_Uitloggen.Location = new System.Drawing.Point(1244, 19);
            this.BTN_Uitloggen.Name = "BTN_Uitloggen";
            this.BTN_Uitloggen.Size = new System.Drawing.Size(75, 23);
            this.BTN_Uitloggen.TabIndex = 1;
            this.BTN_Uitloggen.Text = "Uitloggen";
            this.BTN_Uitloggen.UseVisualStyleBackColor = true;
            this.BTN_Uitloggen.Click += new System.EventHandler(this.BTN_Uitloggen_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.ItemSize = new System.Drawing.Size(300, 50);
            this.tabControl1.Location = new System.Drawing.Point(19, 48);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1316, 625);
            this.tabControl1.TabIndex = 2;
            this.tabControl1.Tag = "";
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.BTN_GereedMelden);
            this.tabPage1.Controls.Add(this.LV_Orders);
            this.tabPage1.Location = new System.Drawing.Point(4, 54);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1308, 567);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "      Orders      ";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // BTN_GereedMelden
            // 
            this.BTN_GereedMelden.Location = new System.Drawing.Point(1213, 538);
            this.BTN_GereedMelden.Name = "BTN_GereedMelden";
            this.BTN_GereedMelden.Size = new System.Drawing.Size(92, 23);
            this.BTN_GereedMelden.TabIndex = 2;
            this.BTN_GereedMelden.Text = "Gereed melden";
            this.BTN_GereedMelden.UseVisualStyleBackColor = true;
            this.BTN_GereedMelden.Click += new System.EventHandler(this.BTN_GereedMelden_Click);
            // 
            // LV_Orders
            // 
            this.LV_Orders.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Aantal,
            this.Gerechten,
            this.Tijd,
            this.columnHeader1,
            this.columnHeader2});
            this.LV_Orders.Location = new System.Drawing.Point(3, 6);
            this.LV_Orders.Name = "LV_Orders";
            this.LV_Orders.Size = new System.Drawing.Size(1300, 516);
            this.LV_Orders.TabIndex = 1;
            this.LV_Orders.UseCompatibleStateImageBehavior = false;
            this.LV_Orders.View = System.Windows.Forms.View.Details;
            this.LV_Orders.SelectedIndexChanged += new System.EventHandler(this.LV_Orders_SelectedIndexChanged);
            // 
            // Aantal
            // 
            this.Aantal.Text = "Aantal";
            // 
            // Gerechten
            // 
            this.Gerechten.Text = "Dranken";
            this.Gerechten.Width = 940;
            // 
            // Tijd
            // 
            this.Tijd.Text = "Bestel tijd";
            this.Tijd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Tijd.Width = 110;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Tafel";
            this.columnHeader1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Ober";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 125;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.BTN_Undo);
            this.tabPage2.Controls.Add(this.LV_Gereed);
            this.tabPage2.Location = new System.Drawing.Point(4, 54);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1308, 567);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "      Gereed      ";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // BTN_Undo
            // 
            this.BTN_Undo.Location = new System.Drawing.Point(1200, 538);
            this.BTN_Undo.Name = "BTN_Undo";
            this.BTN_Undo.Size = new System.Drawing.Size(105, 23);
            this.BTN_Undo.TabIndex = 3;
            this.BTN_Undo.Text = "Ongereed melden";
            this.BTN_Undo.UseVisualStyleBackColor = true;
            this.BTN_Undo.Click += new System.EventHandler(this.button1_Click);
            // 
            // LV_Gereed
            // 
            this.LV_Gereed.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8});
            this.LV_Gereed.Location = new System.Drawing.Point(3, 6);
            this.LV_Gereed.Name = "LV_Gereed";
            this.LV_Gereed.Size = new System.Drawing.Size(1300, 516);
            this.LV_Gereed.TabIndex = 2;
            this.LV_Gereed.UseCompatibleStateImageBehavior = false;
            this.LV_Gereed.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Aantal";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Dranken";
            this.columnHeader5.Width = 940;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Bestel tijd";
            this.columnHeader6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader6.Width = 110;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Tafel";
            this.columnHeader7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Ober";
            this.columnHeader8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader8.Width = 125;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(633, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(197, 87);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // BarmanForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1350, 686);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.BTN_Uitloggen);
            this.Name = "BarmanForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BarmanForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.BarmanForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button BTN_Uitloggen;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ListView LV_Orders;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ColumnHeader Aantal;
        private System.Windows.Forms.ColumnHeader Gerechten;
        private System.Windows.Forms.ColumnHeader Tijd;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button BTN_GereedMelden;
        private System.Windows.Forms.Button BTN_Undo;
        private System.Windows.Forms.ListView LV_Gereed;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
    }
}