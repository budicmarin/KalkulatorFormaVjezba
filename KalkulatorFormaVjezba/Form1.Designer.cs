namespace KalkulatorFormaVjezba
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
            this.lbNaslov = new System.Windows.Forms.Label();
            this.btnPromjeniTekst = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbNaslov
            // 
            this.lbNaslov.AutoSize = true;
            this.lbNaslov.Location = new System.Drawing.Point(13, 13);
            this.lbNaslov.Name = "lbNaslov";
            this.lbNaslov.Size = new System.Drawing.Size(157, 16);
            this.lbNaslov.TabIndex = 0;
            this.lbNaslov.Text = "Ovo je moj prvi kalkulator";
            // 
            // btnPromjeniTekst
            // 
            this.btnPromjeniTekst.Location = new System.Drawing.Point(13, 81);
            this.btnPromjeniTekst.Name = "btnPromjeniTekst";
            this.btnPromjeniTekst.Size = new System.Drawing.Size(117, 84);
            this.btnPromjeniTekst.TabIndex = 1;
            this.btnPromjeniTekst.Text = "Promjeni";
            this.btnPromjeniTekst.UseVisualStyleBackColor = true;
            this.btnPromjeniTekst.Click += new System.EventHandler(this.btnPromjeniTekst_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnPromjeniTekst);
            this.Controls.Add(this.lbNaslov);
            this.Name = "Form1";
            this.Text = "Kalkulator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbNaslov;
        private System.Windows.Forms.Button btnPromjeniTekst;
    }
}

