namespace Test_form
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.Tbx_Inlogveld = new System.Windows.Forms.TextBox();
            this.Lbl_inlogcode = new System.Windows.Forms.Label();
            this.btn_inloggen = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Tbx_Inlogveld
            // 
            this.Tbx_Inlogveld.Location = new System.Drawing.Point(199, 360);
            this.Tbx_Inlogveld.MaxLength = 10;
            this.Tbx_Inlogveld.Name = "Tbx_Inlogveld";
            this.Tbx_Inlogveld.PasswordChar = '*';
            this.Tbx_Inlogveld.Size = new System.Drawing.Size(100, 20);
            this.Tbx_Inlogveld.TabIndex = 0;
            // 
            // Lbl_inlogcode
            // 
            this.Lbl_inlogcode.AutoSize = true;
            this.Lbl_inlogcode.Location = new System.Drawing.Point(110, 363);
            this.Lbl_inlogcode.Name = "Lbl_inlogcode";
            this.Lbl_inlogcode.Size = new System.Drawing.Size(53, 13);
            this.Lbl_inlogcode.TabIndex = 1;
            this.Lbl_inlogcode.Text = "inlogcode";
            // 
            // btn_inloggen
            // 
            this.btn_inloggen.Location = new System.Drawing.Point(209, 418);
            this.btn_inloggen.Name = "btn_inloggen";
            this.btn_inloggen.Size = new System.Drawing.Size(75, 23);
            this.btn_inloggen.TabIndex = 3;
            this.btn_inloggen.Text = "inloggen";
            this.btn_inloggen.UseVisualStyleBackColor = true;
            this.btn_inloggen.Click += new System.EventHandler(this.btn_inloggen_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(113, 151);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(273, 156);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(494, 611);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_inloggen);
            this.Controls.Add(this.Lbl_inlogcode);
            this.Controls.Add(this.Tbx_Inlogveld);
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inloggen";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Tbx_Inlogveld;
        private System.Windows.Forms.Label Lbl_inlogcode;
        private System.Windows.Forms.Button btn_inloggen;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

