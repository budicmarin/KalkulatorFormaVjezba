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
            this.btnPlus = new System.Windows.Forms.Button();
            this.lBNas = new System.Windows.Forms.Label();
            this.txPrviBroj = new System.Windows.Forms.TextBox();
            this.lbDrugiBroj = new System.Windows.Forms.Label();
            this.txDrugiBroj = new System.Windows.Forms.TextBox();
            this.lbRezultat = new System.Windows.Forms.Label();
            this.txBoxRezultat = new System.Windows.Forms.TextBox();
            this.btnMinus = new System.Windows.Forms.Button();
            this.buttonMnoz = new System.Windows.Forms.Button();
            this.btnDijeljenje = new System.Windows.Forms.Button();
            this.btnOtvoriNovuFormu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbNaslov
            // 
            this.lbNaslov.AutoSize = true;
            this.lbNaslov.Location = new System.Drawing.Point(255, 9);
            this.lbNaslov.Name = "lbNaslov";
            this.lbNaslov.Size = new System.Drawing.Size(157, 16);
            this.lbNaslov.TabIndex = 0;
            this.lbNaslov.Text = "Ovo je moj prvi kalkulator";
            // 
            // btnPlus
            // 
            this.btnPlus.Location = new System.Drawing.Point(18, 150);
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.Size = new System.Drawing.Size(117, 84);
            this.btnPlus.TabIndex = 1;
            this.btnPlus.Text = "+";
            this.btnPlus.UseVisualStyleBackColor = true;
            this.btnPlus.Click += new System.EventHandler(this.btnPlus_Click);
            // 
            // lBNas
            // 
            this.lBNas.AutoSize = true;
            this.lBNas.Location = new System.Drawing.Point(13, 32);
            this.lBNas.Name = "lBNas";
            this.lBNas.Size = new System.Drawing.Size(122, 16);
            this.lBNas.TabIndex = 2;
            this.lBNas.Text = "Ovo je moj prvi broj";
            // 
            // txPrviBroj
            // 
            this.txPrviBroj.Location = new System.Drawing.Point(212, 32);
            this.txPrviBroj.Name = "txPrviBroj";
            this.txPrviBroj.Size = new System.Drawing.Size(100, 22);
            this.txPrviBroj.TabIndex = 3;
            // 
            // lbDrugiBroj
            // 
            this.lbDrugiBroj.AutoSize = true;
            this.lbDrugiBroj.Location = new System.Drawing.Point(15, 60);
            this.lbDrugiBroj.Name = "lbDrugiBroj";
            this.lbDrugiBroj.Size = new System.Drawing.Size(130, 16);
            this.lbDrugiBroj.TabIndex = 4;
            this.lbDrugiBroj.Text = "Ovo je moj drugi broj";
            // 
            // txDrugiBroj
            // 
            this.txDrugiBroj.Location = new System.Drawing.Point(212, 60);
            this.txDrugiBroj.Name = "txDrugiBroj";
            this.txDrugiBroj.Size = new System.Drawing.Size(100, 22);
            this.txDrugiBroj.TabIndex = 5;
            // 
            // lbRezultat
            // 
            this.lbRezultat.AutoSize = true;
            this.lbRezultat.Location = new System.Drawing.Point(15, 91);
            this.lbRezultat.Name = "lbRezultat";
            this.lbRezultat.Size = new System.Drawing.Size(55, 16);
            this.lbRezultat.TabIndex = 6;
            this.lbRezultat.Text = "Rezultat";
            // 
            // txBoxRezultat
            // 
            this.txBoxRezultat.Enabled = false;
            this.txBoxRezultat.Location = new System.Drawing.Point(212, 89);
            this.txBoxRezultat.Name = "txBoxRezultat";
            this.txBoxRezultat.Size = new System.Drawing.Size(100, 22);
            this.txBoxRezultat.TabIndex = 7;
            // 
            // btnMinus
            // 
            this.btnMinus.Location = new System.Drawing.Point(153, 150);
            this.btnMinus.Name = "btnMinus";
            this.btnMinus.Size = new System.Drawing.Size(117, 84);
            this.btnMinus.TabIndex = 8;
            this.btnMinus.Text = "-";
            this.btnMinus.UseVisualStyleBackColor = true;
            this.btnMinus.Click += new System.EventHandler(this.btnMinus_Click);
            // 
            // buttonMnoz
            // 
            this.buttonMnoz.Location = new System.Drawing.Point(276, 150);
            this.buttonMnoz.Name = "buttonMnoz";
            this.buttonMnoz.Size = new System.Drawing.Size(117, 84);
            this.buttonMnoz.TabIndex = 9;
            this.buttonMnoz.Text = "*";
            this.buttonMnoz.UseVisualStyleBackColor = true;
            this.buttonMnoz.Click += new System.EventHandler(this.buttonMnoz_Click);
            // 
            // btnDijeljenje
            // 
            this.btnDijeljenje.Location = new System.Drawing.Point(408, 150);
            this.btnDijeljenje.Name = "btnDijeljenje";
            this.btnDijeljenje.Size = new System.Drawing.Size(117, 84);
            this.btnDijeljenje.TabIndex = 10;
            this.btnDijeljenje.Text = "/";
            this.btnDijeljenje.UseVisualStyleBackColor = true;
            this.btnDijeljenje.Click += new System.EventHandler(this.btnDijeljenje_Click);
            // 
            // btnOtvoriNovuFormu
            // 
            this.btnOtvoriNovuFormu.Location = new System.Drawing.Point(386, 316);
            this.btnOtvoriNovuFormu.Name = "btnOtvoriNovuFormu";
            this.btnOtvoriNovuFormu.Size = new System.Drawing.Size(239, 99);
            this.btnOtvoriNovuFormu.TabIndex = 11;
            this.btnOtvoriNovuFormu.Text = "Otvori Novu Formu";
            this.btnOtvoriNovuFormu.UseVisualStyleBackColor = true;
            this.btnOtvoriNovuFormu.Click += new System.EventHandler(this.btnOtvoriNovuFormu_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(647, 450);
            this.Controls.Add(this.btnOtvoriNovuFormu);
            this.Controls.Add(this.btnDijeljenje);
            this.Controls.Add(this.buttonMnoz);
            this.Controls.Add(this.btnMinus);
            this.Controls.Add(this.txBoxRezultat);
            this.Controls.Add(this.lbRezultat);
            this.Controls.Add(this.txDrugiBroj);
            this.Controls.Add(this.lbDrugiBroj);
            this.Controls.Add(this.txPrviBroj);
            this.Controls.Add(this.lBNas);
            this.Controls.Add(this.btnPlus);
            this.Controls.Add(this.lbNaslov);
            this.Name = "Form1";
            this.Text = "Kalkulator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbNaslov;
        private System.Windows.Forms.Button btnPlus;
        private System.Windows.Forms.Label lBNas;
        private System.Windows.Forms.TextBox txPrviBroj;
        private System.Windows.Forms.Label lbDrugiBroj;
        private System.Windows.Forms.TextBox txDrugiBroj;
        private System.Windows.Forms.Label lbRezultat;
        private System.Windows.Forms.TextBox txBoxRezultat;
        private System.Windows.Forms.Button btnMinus;
        private System.Windows.Forms.Button buttonMnoz;
        private System.Windows.Forms.Button btnDijeljenje;
        private System.Windows.Forms.Button btnOtvoriNovuFormu;
    }
}

