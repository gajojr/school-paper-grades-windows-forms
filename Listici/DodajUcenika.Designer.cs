
namespace Listici
{
    partial class DodajUcenika
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
            this.ime = new System.Windows.Forms.Label();
            this.imeUnos = new System.Windows.Forms.TextBox();
            this.prezimeUnos = new System.Windows.Forms.TextBox();
            this.prezime = new System.Windows.Forms.Label();
            this.emailUnos = new System.Windows.Forms.TextBox();
            this.email = new System.Windows.Forms.Label();
            this.odeljenjeUnos = new System.Windows.Forms.TextBox();
            this.odeljenje = new System.Windows.Forms.Label();
            this.telefonUnos = new System.Windows.Forms.TextBox();
            this.telefon = new System.Windows.Forms.Label();
            this.posalji = new System.Windows.Forms.Button();
            this.ponisti = new System.Windows.Forms.Button();
            this.poruka = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ime
            // 
            this.ime.AutoSize = true;
            this.ime.Location = new System.Drawing.Point(13, 13);
            this.ime.Name = "ime";
            this.ime.Size = new System.Drawing.Size(30, 16);
            this.ime.TabIndex = 0;
            this.ime.Text = "ime";
            // 
            // imeUnos
            // 
            this.imeUnos.Location = new System.Drawing.Point(73, 10);
            this.imeUnos.Name = "imeUnos";
            this.imeUnos.Size = new System.Drawing.Size(100, 22);
            this.imeUnos.TabIndex = 1;
            // 
            // prezimeUnos
            // 
            this.prezimeUnos.Location = new System.Drawing.Point(73, 38);
            this.prezimeUnos.Name = "prezimeUnos";
            this.prezimeUnos.Size = new System.Drawing.Size(100, 22);
            this.prezimeUnos.TabIndex = 3;
            // 
            // prezime
            // 
            this.prezime.AutoSize = true;
            this.prezime.Location = new System.Drawing.Point(13, 41);
            this.prezime.Name = "prezime";
            this.prezime.Size = new System.Drawing.Size(56, 16);
            this.prezime.TabIndex = 2;
            this.prezime.Text = "prezime";
            // 
            // emailUnos
            // 
            this.emailUnos.Location = new System.Drawing.Point(73, 74);
            this.emailUnos.Name = "emailUnos";
            this.emailUnos.Size = new System.Drawing.Size(100, 22);
            this.emailUnos.TabIndex = 5;
            // 
            // email
            // 
            this.email.AutoSize = true;
            this.email.Location = new System.Drawing.Point(13, 74);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(41, 16);
            this.email.TabIndex = 4;
            this.email.Text = "email";
            // 
            // odeljenjeUnos
            // 
            this.odeljenjeUnos.Location = new System.Drawing.Point(73, 139);
            this.odeljenjeUnos.Name = "odeljenjeUnos";
            this.odeljenjeUnos.Size = new System.Drawing.Size(100, 22);
            this.odeljenjeUnos.TabIndex = 9;
            // 
            // odeljenje
            // 
            this.odeljenje.AutoSize = true;
            this.odeljenje.Location = new System.Drawing.Point(5, 139);
            this.odeljenje.Name = "odeljenje";
            this.odeljenje.Size = new System.Drawing.Size(64, 16);
            this.odeljenje.TabIndex = 8;
            this.odeljenje.Text = "odeljenje";
            // 
            // telefonUnos
            // 
            this.telefonUnos.Location = new System.Drawing.Point(73, 105);
            this.telefonUnos.Name = "telefonUnos";
            this.telefonUnos.Size = new System.Drawing.Size(100, 22);
            this.telefonUnos.TabIndex = 7;
            // 
            // telefon
            // 
            this.telefon.AutoSize = true;
            this.telefon.Location = new System.Drawing.Point(13, 105);
            this.telefon.Name = "telefon";
            this.telefon.Size = new System.Drawing.Size(48, 16);
            this.telefon.TabIndex = 6;
            this.telefon.Text = "telefon";
            // 
            // posalji
            // 
            this.posalji.Location = new System.Drawing.Point(205, 171);
            this.posalji.Name = "posalji";
            this.posalji.Size = new System.Drawing.Size(75, 23);
            this.posalji.TabIndex = 12;
            this.posalji.Text = "Potvrdi";
            this.posalji.UseVisualStyleBackColor = true;
            this.posalji.Click += new System.EventHandler(this.posalji_Click);
            // 
            // ponisti
            // 
            this.ponisti.Location = new System.Drawing.Point(205, 207);
            this.ponisti.Name = "ponisti";
            this.ponisti.Size = new System.Drawing.Size(75, 23);
            this.ponisti.TabIndex = 13;
            this.ponisti.Text = "Ponisti";
            this.ponisti.UseVisualStyleBackColor = true;
            this.ponisti.Click += new System.EventHandler(this.ponisti_Click);
            // 
            // poruka
            // 
            this.poruka.AutoSize = true;
            this.poruka.Location = new System.Drawing.Point(13, 171);
            this.poruka.Name = "poruka";
            this.poruka.Size = new System.Drawing.Size(0, 16);
            this.poruka.TabIndex = 14;
            // 
            // DodajUcenika
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 249);
            this.Controls.Add(this.poruka);
            this.Controls.Add(this.ponisti);
            this.Controls.Add(this.posalji);
            this.Controls.Add(this.odeljenjeUnos);
            this.Controls.Add(this.odeljenje);
            this.Controls.Add(this.telefonUnos);
            this.Controls.Add(this.telefon);
            this.Controls.Add(this.emailUnos);
            this.Controls.Add(this.email);
            this.Controls.Add(this.prezimeUnos);
            this.Controls.Add(this.prezime);
            this.Controls.Add(this.imeUnos);
            this.Controls.Add(this.ime);
            this.Name = "DodajUcenika";
            this.Text = "DodajUcenika";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ime;
        private System.Windows.Forms.TextBox imeUnos;
        private System.Windows.Forms.TextBox prezimeUnos;
        private System.Windows.Forms.Label prezime;
        private System.Windows.Forms.TextBox emailUnos;
        private System.Windows.Forms.Label email;
        private System.Windows.Forms.TextBox odeljenjeUnos;
        private System.Windows.Forms.Label odeljenje;
        private System.Windows.Forms.TextBox telefonUnos;
        private System.Windows.Forms.Label telefon;
        private System.Windows.Forms.Button posalji;
        private System.Windows.Forms.Button ponisti;
        private System.Windows.Forms.Label poruka;
    }
}