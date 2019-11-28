namespace Sensori_Calcetto
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.LR = new System.Windows.Forms.Label();
            this.NoGiocatori = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.GMB = new System.Windows.Forms.Button();
            this.GMR = new System.Windows.Forms.Button();
            this.G1B = new System.Windows.Forms.TextBox();
            this.G1R = new System.Windows.Forms.TextBox();
            this.G2B = new System.Windows.Forms.TextBox();
            this.G2R = new System.Windows.Forms.TextBox();
            this.inizio = new System.Windows.Forms.Button();
            this.fine = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(463, 192);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(268, 75);
            this.button1.TabIndex = 0;
            this.button1.Text = "Goal SQ Rossa";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.GR);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 192);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(268, 75);
            this.button2.TabIndex = 1;
            this.button2.Text = "Goal SQ Blu";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.GB);
            // 
            // checkBox1
            // 
            this.checkBox1.Location = new System.Drawing.Point(0, 0);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(104, 24);
            this.checkBox1.TabIndex = 21;
            // 
            // checkBox2
            // 
            this.checkBox2.Location = new System.Drawing.Point(0, 0);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(104, 24);
            this.checkBox2.TabIndex = 20;
            // 
            // checkBox3
            // 
            this.checkBox3.Location = new System.Drawing.Point(0, 0);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(104, 24);
            this.checkBox3.TabIndex = 19;
            // 
            // checkBox4
            // 
            this.checkBox4.Location = new System.Drawing.Point(0, 0);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(104, 24);
            this.checkBox4.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 10;
            // 
            // LR
            // 
            this.LR.AutoSize = true;
            this.LR.Location = new System.Drawing.Point(124, 320);
            this.LR.Name = "LR";
            this.LR.Size = new System.Drawing.Size(64, 17);
            this.LR.TabIndex = 7;
            this.LR.Text = "Punti Blu";
            // 
            // NoGiocatori
            // 
            this.NoGiocatori.AutoSize = true;
            this.NoGiocatori.Location = new System.Drawing.Point(302, 221);
            this.NoGiocatori.Name = "NoGiocatori";
            this.NoGiocatori.Size = new System.Drawing.Size(136, 17);
            this.NoGiocatori.TabIndex = 8;
            this.NoGiocatori.Text = "GIocatori Non Pronti";
            this.NoGiocatori.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(567, 320);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 17);
            this.label2.TabIndex = 11;
            this.label2.Text = "Punti Rossi";
            // 
            // GMB
            // 
            this.GMB.Location = new System.Drawing.Point(105, 283);
            this.GMB.Name = "GMB";
            this.GMB.Size = new System.Drawing.Size(106, 23);
            this.GMB.TabIndex = 12;
            this.GMB.Text = "GoalManBlu";
            this.GMB.UseVisualStyleBackColor = true;
            this.GMB.Click += new System.EventHandler(this.GMB_Click);
            // 
            // GMR
            // 
            this.GMR.Location = new System.Drawing.Point(560, 283);
            this.GMR.Name = "GMR";
            this.GMR.Size = new System.Drawing.Size(91, 23);
            this.GMR.TabIndex = 13;
            this.GMR.Text = "GolaMaR";
            this.GMR.UseVisualStyleBackColor = true;
            this.GMR.Click += new System.EventHandler(this.GMR_Click);
            // 
            // G1B
            // 
            this.G1B.Location = new System.Drawing.Point(111, 67);
            this.G1B.Name = "G1B";
            this.G1B.Size = new System.Drawing.Size(100, 22);
            this.G1B.TabIndex = 14;
            this.G1B.TextChanged += new System.EventHandler(this.G1B_TextChanged);
            // 
            // G1R
            // 
            this.G1R.Location = new System.Drawing.Point(570, 67);
            this.G1R.Name = "G1R";
            this.G1R.Size = new System.Drawing.Size(100, 22);
            this.G1R.TabIndex = 15;
            this.G1R.TextChanged += new System.EventHandler(this.G1R_TextChanged);
            // 
            // G2B
            // 
            this.G2B.Location = new System.Drawing.Point(111, 128);
            this.G2B.Name = "G2B";
            this.G2B.Size = new System.Drawing.Size(100, 22);
            this.G2B.TabIndex = 16;
            this.G2B.TextChanged += new System.EventHandler(this.G2B_TextChanged);
            // 
            // G2R
            // 
            this.G2R.Location = new System.Drawing.Point(570, 146);
            this.G2R.Name = "G2R";
            this.G2R.Size = new System.Drawing.Size(100, 22);
            this.G2R.TabIndex = 17;
            this.G2R.TextChanged += new System.EventHandler(this.G2R_TextChanged);
            // 
            // inizio
            // 
            this.inizio.Location = new System.Drawing.Point(358, 57);
            this.inizio.Name = "inizio";
            this.inizio.Size = new System.Drawing.Size(75, 23);
            this.inizio.TabIndex = 22;
            this.inizio.Text = "INIZIO";
            this.inizio.UseVisualStyleBackColor = true;
            this.inizio.Click += new System.EventHandler(this.inizio_Click);
            // 
            // fine
            // 
            this.fine.Location = new System.Drawing.Point(358, 128);
            this.fine.Name = "fine";
            this.fine.Size = new System.Drawing.Size(75, 23);
            this.fine.TabIndex = 23;
            this.fine.Text = "FINE";
            this.fine.UseVisualStyleBackColor = true;
            this.fine.Click += new System.EventHandler(this.fine_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(771, 427);
            this.Controls.Add(this.fine);
            this.Controls.Add(this.inizio);
            this.Controls.Add(this.G2R);
            this.Controls.Add(this.G2B);
            this.Controls.Add(this.G1R);
            this.Controls.Add(this.G1B);
            this.Controls.Add(this.GMR);
            this.Controls.Add(this.GMB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.NoGiocatori);
            this.Controls.Add(this.LR);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkBox4);
            this.Controls.Add(this.checkBox3);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LR;
        private System.Windows.Forms.Label NoGiocatori;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button GMB;
        private System.Windows.Forms.Button GMR;
        private System.Windows.Forms.TextBox G1B;
        private System.Windows.Forms.TextBox G1R;
        private System.Windows.Forms.TextBox G2B;
        private System.Windows.Forms.TextBox G2R;
        private System.Windows.Forms.Button inizio;
        private System.Windows.Forms.Button fine;
    }
}

