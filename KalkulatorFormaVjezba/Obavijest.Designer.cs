namespace KalkulatorFormaVjezba
{
    partial class Obavijest
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
            this.txUnos = new System.Windows.Forms.TextBox();
            this.btnBroj = new System.Windows.Forms.Button();
            this.lbBroj = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txUnos
            // 
            this.txUnos.Location = new System.Drawing.Point(50, 45);
            this.txUnos.Name = "txUnos";
            this.txUnos.Size = new System.Drawing.Size(100, 22);
            this.txUnos.TabIndex = 0;
            this.txUnos.TextChanged += new System.EventHandler(this.txUnos_TextChanged);
            // 
            // btnBroj
            // 
            this.btnBroj.Location = new System.Drawing.Point(50, 106);
            this.btnBroj.Name = "btnBroj";
            this.btnBroj.Size = new System.Drawing.Size(187, 23);
            this.btnBroj.TabIndex = 1;
            this.btnBroj.Text = "Prebroj Znakove";
            this.btnBroj.UseVisualStyleBackColor = true;
            this.btnBroj.Click += new System.EventHandler(this.btnBroj_Click);
            // 
            // lbBroj
            // 
            this.lbBroj.AutoSize = true;
            this.lbBroj.Location = new System.Drawing.Point(50, 154);
            this.lbBroj.Name = "lbBroj";
            this.lbBroj.Size = new System.Drawing.Size(0, 16);
            this.lbBroj.TabIndex = 2;
            // 
            // Obavijest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbBroj);
            this.Controls.Add(this.btnBroj);
            this.Controls.Add(this.txUnos);
            this.Name = "Obavijest";
            this.Text = "Obavijest";
            this.Load += new System.EventHandler(this.Obavijest_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txUnos;
        private System.Windows.Forms.Button btnBroj;
        private System.Windows.Forms.Label lbBroj;
    }
}