namespace Ober_beginscherm
{
    partial class OberBestelForm
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
            this.btn_Bestellen = new System.Windows.Forms.Button();
            this.btnReserveren = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_Uitloggen
            // 
            this.btn_Uitloggen.Location = new System.Drawing.Point(197, 12);
            this.btn_Uitloggen.Name = "btn_Uitloggen";
            this.btn_Uitloggen.Size = new System.Drawing.Size(75, 23);
            this.btn_Uitloggen.TabIndex = 0;
            this.btn_Uitloggen.Text = "uitloggen";
            this.btn_Uitloggen.UseVisualStyleBackColor = true;
            this.btn_Uitloggen.Click += new System.EventHandler(this.btn_Uitloggen_Click);
            // 
            // btn_Bestellen
            // 
            this.btn_Bestellen.Location = new System.Drawing.Point(12, 12);
            this.btn_Bestellen.Name = "btn_Bestellen";
            this.btn_Bestellen.Size = new System.Drawing.Size(75, 23);
            this.btn_Bestellen.TabIndex = 1;
            this.btn_Bestellen.Text = "Bestellen";
            this.btn_Bestellen.UseVisualStyleBackColor = true;
            // 
            // btnReserveren
            // 
            this.btnReserveren.Location = new System.Drawing.Point(103, 12);
            this.btnReserveren.Name = "btnReserveren";
            this.btnReserveren.Size = new System.Drawing.Size(75, 23);
            this.btnReserveren.TabIndex = 2;
            this.btnReserveren.Text = "Reserveren";
            this.btnReserveren.UseVisualStyleBackColor = true;
            this.btnReserveren.Click += new System.EventHandler(this.btnReserveren_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(73, 141);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "bestelscherm";
            // 
            // OberBestelForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnReserveren);
            this.Controls.Add(this.btn_Bestellen);
            this.Controls.Add(this.btn_Uitloggen);
            this.Name = "OberBestelForm";
            this.Text = "Ober";
            this.Load += new System.EventHandler(this.Ober_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Uitloggen;
        private System.Windows.Forms.Button btn_Bestellen;
        private System.Windows.Forms.Button btnReserveren;
        private System.Windows.Forms.Label label1;
    }
}

