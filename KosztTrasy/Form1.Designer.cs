namespace KosztTrasy
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lbl1 = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.lbl3 = new System.Windows.Forms.Label();
            this.lbl4 = new System.Windows.Forms.Label();
            this.lbl5 = new System.Windows.Forms.Label();
            this.answer = new System.Windows.Forms.Label();
            this.dlugoscTrasy = new System.Windows.Forms.TextBox();
            this.srednieSpalanie = new System.Windows.Forms.TextBox();
            this.cena = new System.Windows.Forms.TextBox();
            this.Wynik = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl1
            // 
            this.lbl1.BackColor = System.Drawing.Color.LightSeaGreen;
            this.lbl1.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl1.ForeColor = System.Drawing.SystemColors.Window;
            this.lbl1.Location = new System.Drawing.Point(12, 18);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(443, 86);
            this.lbl1.TabIndex = 0;
            this.lbl1.Text = "PROGRAM OBLICZA KOSZT PRZEJECHANIA TRASY";
            this.lbl1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl2
            // 
            this.lbl2.BackColor = System.Drawing.Color.LightSeaGreen;
            this.lbl2.Font = new System.Drawing.Font("Georgia Pro Cond", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl2.ForeColor = System.Drawing.Color.Red;
            this.lbl2.Location = new System.Drawing.Point(12, 104);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(443, 51);
            this.lbl2.TabIndex = 1;
            this.lbl2.Text = "ZAKŁADAJĄC, ŻE PORUSZAMY SIĘ POJAZDEM OSOBOWYM, W KTÓRYM ZNAJDUJĄ SIĘ DWIE OSOBY " +
    "O WADZE OKOŁO 70 KG.\r\n";
            this.lbl2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl3
            // 
            this.lbl3.Font = new System.Drawing.Font("Georgia Pro Cond Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl3.Location = new System.Drawing.Point(79, 167);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(304, 23);
            this.lbl3.TabIndex = 2;
            this.lbl3.Text = "Ile kilometrów liczy Twoja trasa ?";
            this.lbl3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl4
            // 
            this.lbl4.Font = new System.Drawing.Font("Georgia Pro Cond Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl4.Location = new System.Drawing.Point(-1, 236);
            this.lbl4.Name = "lbl4";
            this.lbl4.Size = new System.Drawing.Size(468, 20);
            this.lbl4.TabIndex = 3;
            this.lbl4.Text = "Ile wynosi średnie spalanie Twojego pojazdu na 100 km ?\r\n";
            this.lbl4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl5
            // 
            this.lbl5.Font = new System.Drawing.Font("Georgia Pro Cond Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl5.Location = new System.Drawing.Point(117, 302);
            this.lbl5.Name = "lbl5";
            this.lbl5.Size = new System.Drawing.Size(233, 23);
            this.lbl5.TabIndex = 4;
            this.lbl5.Text = "Podaj cenę paliwa (1 litr)";
            this.lbl5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // answer
            // 
            this.answer.Font = new System.Drawing.Font("Georgia Pro Cond Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.answer.ForeColor = System.Drawing.Color.Red;
            this.answer.Location = new System.Drawing.Point(27, 420);
            this.answer.Name = "answer";
            this.answer.Size = new System.Drawing.Size(420, 72);
            this.answer.TabIndex = 5;
            this.answer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dlugoscTrasy
            // 
            this.dlugoscTrasy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dlugoscTrasy.Location = new System.Drawing.Point(155, 193);
            this.dlugoscTrasy.Multiline = true;
            this.dlugoscTrasy.Name = "dlugoscTrasy";
            this.dlugoscTrasy.Size = new System.Drawing.Size(137, 28);
            this.dlugoscTrasy.TabIndex = 6;
            this.dlugoscTrasy.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.dlugoscTrasy.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dlugoscTrasyEnter);
            // 
            // srednieSpalanie
            // 
            this.srednieSpalanie.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.srednieSpalanie.Location = new System.Drawing.Point(155, 259);
            this.srednieSpalanie.Multiline = true;
            this.srednieSpalanie.Name = "srednieSpalanie";
            this.srednieSpalanie.Size = new System.Drawing.Size(137, 28);
            this.srednieSpalanie.TabIndex = 7;
            this.srednieSpalanie.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.srednieSpalanie.KeyDown += new System.Windows.Forms.KeyEventHandler(this.srednieSpalanieEnter);
            // 
            // cena
            // 
            this.cena.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cena.Location = new System.Drawing.Point(155, 328);
            this.cena.Multiline = true;
            this.cena.Name = "cena";
            this.cena.Size = new System.Drawing.Size(137, 28);
            this.cena.TabIndex = 8;
            this.cena.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.cena.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cenaEnter);
            // 
            // Wynik
            // 
            this.Wynik.Font = new System.Drawing.Font("Georgia Pro Cond Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Wynik.Location = new System.Drawing.Point(155, 382);
            this.Wynik.Name = "Wynik";
            this.Wynik.Size = new System.Drawing.Size(137, 35);
            this.Wynik.TabIndex = 9;
            this.Wynik.Text = "Oblicz";
            this.Wynik.UseVisualStyleBackColor = true;
            this.Wynik.Click += new System.EventHandler(this.Wynik_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Turquoise;
            this.label1.Font = new System.Drawing.Font("SimSun", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Teal;
            this.label1.Location = new System.Drawing.Point(43, 506);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(404, 14);
            this.label1.TabIndex = 10;
            this.label1.Text = "PROGRAMOWANIE TO STYL ŻYCIA      ~własność ImaTTey\r\n\r\n\r\n";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Turquoise;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(467, 517);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Wynik);
            this.Controls.Add(this.cena);
            this.Controls.Add(this.srednieSpalanie);
            this.Controls.Add(this.dlugoscTrasy);
            this.Controls.Add(this.answer);
            this.Controls.Add(this.lbl5);
            this.Controls.Add(this.lbl4);
            this.Controls.Add(this.lbl3);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.lbl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Koszt Trasy";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.Label lbl4;
        private System.Windows.Forms.Label lbl5;
        private System.Windows.Forms.Label answer;
        private System.Windows.Forms.TextBox dlugoscTrasy;
        private System.Windows.Forms.TextBox srednieSpalanie;
        private System.Windows.Forms.TextBox cena;
        private System.Windows.Forms.Button Wynik;
        private System.Windows.Forms.Label label1;
    }
}

