namespace Schach
{
    partial class Schach
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
            this.main_panel1 = new System.Windows.Forms.Panel();
            this.reset_button1 = new System.Windows.Forms.Button();
            this.gameObject_pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.gameObject_pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // main_panel1
            // 
            this.main_panel1.BackColor = System.Drawing.Color.White;
            this.main_panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.main_panel1.ForeColor = System.Drawing.Color.Black;
            this.main_panel1.Location = new System.Drawing.Point(12, 42);
            this.main_panel1.Name = "main_panel1";
            this.main_panel1.Size = new System.Drawing.Size(400, 400);
            this.main_panel1.TabIndex = 0;
            // 
            // reset_button1
            // 
            this.reset_button1.BackColor = System.Drawing.Color.Black;
            this.reset_button1.ForeColor = System.Drawing.Color.White;
            this.reset_button1.Location = new System.Drawing.Point(337, 4);
            this.reset_button1.Name = "reset_button1";
            this.reset_button1.Size = new System.Drawing.Size(75, 36);
            this.reset_button1.TabIndex = 1;
            this.reset_button1.Text = "RESET";
            this.reset_button1.UseVisualStyleBackColor = false;
            this.reset_button1.Click += new System.EventHandler(this.reset_button1_Click);
            // 
            // gameObject_pictureBox1
            // 
            this.gameObject_pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.gameObject_pictureBox1.Location = new System.Drawing.Point(12, -1);
            this.gameObject_pictureBox1.Name = "gameObject_pictureBox1";
            this.gameObject_pictureBox1.Size = new System.Drawing.Size(36, 37);
            this.gameObject_pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.gameObject_pictureBox1.TabIndex = 4;
            this.gameObject_pictureBox1.TabStop = false;
            this.gameObject_pictureBox1.Visible = false;
            // 
            // Schach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(427, 454);
            this.Controls.Add(this.gameObject_pictureBox1);
            this.Controls.Add(this.reset_button1);
            this.Controls.Add(this.main_panel1);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Schach";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Schach";
            this.Load += new System.EventHandler(this.Schach_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.gameObject_pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel main_panel1;
        private System.Windows.Forms.Button reset_button1;
        private System.Windows.Forms.PictureBox gameObject_pictureBox1;
    }
}

