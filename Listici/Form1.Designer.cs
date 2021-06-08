
namespace Listici
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
            this.napraviNoviListic = new System.Windows.Forms.Button();
            this.pogledajPostojeciListic = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // napraviNoviListic
            // 
            this.napraviNoviListic.Location = new System.Drawing.Point(120, 93);
            this.napraviNoviListic.Name = "napraviNoviListic";
            this.napraviNoviListic.Size = new System.Drawing.Size(134, 23);
            this.napraviNoviListic.TabIndex = 0;
            this.napraviNoviListic.Text = "Napravi novi listic";
            this.napraviNoviListic.UseVisualStyleBackColor = true;
            this.napraviNoviListic.Click += new System.EventHandler(this.napraviNoviListic_Click);
            // 
            // pogledajPostojeciListic
            // 
            this.pogledajPostojeciListic.Location = new System.Drawing.Point(120, 176);
            this.pogledajPostojeciListic.Name = "pogledajPostojeciListic";
            this.pogledajPostojeciListic.Size = new System.Drawing.Size(134, 23);
            this.pogledajPostojeciListic.TabIndex = 1;
            this.pogledajPostojeciListic.Text = "Pogledaj postojeci listic";
            this.pogledajPostojeciListic.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(411, 348);
            this.Controls.Add(this.pogledajPostojeciListic);
            this.Controls.Add(this.napraviNoviListic);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button napraviNoviListic;
        private System.Windows.Forms.Button pogledajPostojeciListic;
    }
}

