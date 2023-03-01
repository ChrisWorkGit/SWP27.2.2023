namespace Rechner
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.l_Zahl1 = new System.Windows.Forms.Label();
            this.txt_zahl1 = new System.Windows.Forms.TextBox();
            this.txt_Zahl2 = new System.Windows.Forms.TextBox();
            this.t_Zahl2 = new System.Windows.Forms.Label();
            this.txt_Summe = new System.Windows.Forms.TextBox();
            this.l_Summe = new System.Windows.Forms.Label();
            this.cmd_Addieren = new System.Windows.Forms.Button();
            this.cmd_Lesen = new System.Windows.Forms.Button();
            this.cmd_Schreiben = new System.Windows.Forms.Button();
            this.shz_test = new Funktionen.SollHaben();
            this.SuspendLayout();
            // 
            // l_Zahl1
            // 
            this.l_Zahl1.AutoSize = true;
            this.l_Zahl1.Location = new System.Drawing.Point(13, 23);
            this.l_Zahl1.Name = "l_Zahl1";
            this.l_Zahl1.Size = new System.Drawing.Size(40, 13);
            this.l_Zahl1.TabIndex = 0;
            this.l_Zahl1.Text = "Zahl 1:";
            // 
            // txt_zahl1
            // 
            this.txt_zahl1.Location = new System.Drawing.Point(69, 20);
            this.txt_zahl1.Name = "txt_zahl1";
            this.txt_zahl1.Size = new System.Drawing.Size(100, 20);
            this.txt_zahl1.TabIndex = 1;
            // 
            // txt_Zahl2
            // 
            this.txt_Zahl2.Location = new System.Drawing.Point(69, 46);
            this.txt_Zahl2.Name = "txt_Zahl2";
            this.txt_Zahl2.Size = new System.Drawing.Size(100, 20);
            this.txt_Zahl2.TabIndex = 3;
            // 
            // t_Zahl2
            // 
            this.t_Zahl2.AutoSize = true;
            this.t_Zahl2.Location = new System.Drawing.Point(13, 49);
            this.t_Zahl2.Name = "t_Zahl2";
            this.t_Zahl2.Size = new System.Drawing.Size(40, 13);
            this.t_Zahl2.TabIndex = 2;
            this.t_Zahl2.Text = "Zahl 2:";
            // 
            // txt_Summe
            // 
            this.txt_Summe.Location = new System.Drawing.Point(69, 90);
            this.txt_Summe.Name = "txt_Summe";
            this.txt_Summe.Size = new System.Drawing.Size(100, 20);
            this.txt_Summe.TabIndex = 5;
            // 
            // l_Summe
            // 
            this.l_Summe.AutoSize = true;
            this.l_Summe.Location = new System.Drawing.Point(11, 90);
            this.l_Summe.Name = "l_Summe";
            this.l_Summe.Size = new System.Drawing.Size(42, 13);
            this.l_Summe.TabIndex = 4;
            this.l_Summe.Text = "Summe";
            // 
            // cmd_Addieren
            // 
            this.cmd_Addieren.Location = new System.Drawing.Point(69, 116);
            this.cmd_Addieren.Name = "cmd_Addieren";
            this.cmd_Addieren.Size = new System.Drawing.Size(100, 23);
            this.cmd_Addieren.TabIndex = 6;
            this.cmd_Addieren.Text = "Addieren";
            this.cmd_Addieren.UseVisualStyleBackColor = true;
            this.cmd_Addieren.Click += new System.EventHandler(this.cmd_Addieren_Click);
            // 
            // cmd_Lesen
            // 
            this.cmd_Lesen.Location = new System.Drawing.Point(214, 116);
            this.cmd_Lesen.Name = "cmd_Lesen";
            this.cmd_Lesen.Size = new System.Drawing.Size(100, 23);
            this.cmd_Lesen.TabIndex = 8;
            this.cmd_Lesen.Text = "Lesen";
            this.cmd_Lesen.UseVisualStyleBackColor = true;
            this.cmd_Lesen.Click += new System.EventHandler(this.cmd_Lesen_Click);
            // 
            // cmd_Schreiben
            // 
            this.cmd_Schreiben.Location = new System.Drawing.Point(368, 116);
            this.cmd_Schreiben.Name = "cmd_Schreiben";
            this.cmd_Schreiben.Size = new System.Drawing.Size(100, 23);
            this.cmd_Schreiben.TabIndex = 9;
            this.cmd_Schreiben.Text = "Schreiben";
            this.cmd_Schreiben.UseVisualStyleBackColor = true;
            this.cmd_Schreiben.Click += new System.EventHandler(this.cmd_Schreiben_Click);
            // 
            // shz_test
            // 
            this.shz_test.betrag = 0D;
            this.shz_test.Location = new System.Drawing.Point(214, 20);
            this.shz_test.Name = "shz_test";
            this.shz_test.Size = new System.Drawing.Size(254, 78);
            this.shz_test.TabIndex = 7;

            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 181);
            this.Controls.Add(this.cmd_Schreiben);
            this.Controls.Add(this.cmd_Lesen);
            this.Controls.Add(this.shz_test);
            this.Controls.Add(this.cmd_Addieren);
            this.Controls.Add(this.txt_Summe);
            this.Controls.Add(this.l_Summe);
            this.Controls.Add(this.txt_Zahl2);
            this.Controls.Add(this.t_Zahl2);
            this.Controls.Add(this.txt_zahl1);
            this.Controls.Add(this.l_Zahl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label l_Zahl1;
        private System.Windows.Forms.TextBox txt_zahl1;
        private System.Windows.Forms.TextBox txt_Zahl2;
        private System.Windows.Forms.Label t_Zahl2;
        private System.Windows.Forms.TextBox txt_Summe;
        private System.Windows.Forms.Label l_Summe;
        private System.Windows.Forms.Button cmd_Addieren;
        private Funktionen.SollHaben shz_test;
        private System.Windows.Forms.Button cmd_Lesen;
        private System.Windows.Forms.Button cmd_Schreiben;
    }
}

