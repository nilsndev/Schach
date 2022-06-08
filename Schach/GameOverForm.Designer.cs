namespace Schach
{
    partial class GameOverForm
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
            this.header_label1 = new System.Windows.Forms.Label();
            this.winner_label1 = new System.Windows.Forms.Label();
            this.text_label2 = new System.Windows.Forms.Label();
            this.ok_button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // header_label1
            // 
            this.header_label1.BackColor = System.Drawing.Color.Black;
            this.header_label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.header_label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.header_label1.ForeColor = System.Drawing.Color.White;
            this.header_label1.Location = new System.Drawing.Point(0, 0);
            this.header_label1.Name = "header_label1";
            this.header_label1.Size = new System.Drawing.Size(377, 49);
            this.header_label1.TabIndex = 0;
            this.header_label1.Text = "Game Over!";
            this.header_label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // winner_label1
            // 
            this.winner_label1.BackColor = System.Drawing.Color.Transparent;
            this.winner_label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.winner_label1.ForeColor = System.Drawing.Color.Black;
            this.winner_label1.Location = new System.Drawing.Point(89, 96);
            this.winner_label1.Name = "winner_label1";
            this.winner_label1.Size = new System.Drawing.Size(52, 36);
            this.winner_label1.TabIndex = 1;
            this.winner_label1.Text = "Player";
            this.winner_label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // text_label2
            // 
            this.text_label2.BackColor = System.Drawing.Color.Transparent;
            this.text_label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_label2.ForeColor = System.Drawing.Color.Black;
            this.text_label2.Location = new System.Drawing.Point(137, 96);
            this.text_label2.Name = "text_label2";
            this.text_label2.Size = new System.Drawing.Size(143, 36);
            this.text_label2.TabIndex = 2;
            this.text_label2.Text = "has won the game!";
            this.text_label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ok_button1
            // 
            this.ok_button1.BackColor = System.Drawing.Color.Black;
            this.ok_button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ok_button1.ForeColor = System.Drawing.Color.White;
            this.ok_button1.Location = new System.Drawing.Point(141, 151);
            this.ok_button1.Name = "ok_button1";
            this.ok_button1.Size = new System.Drawing.Size(97, 44);
            this.ok_button1.TabIndex = 5;
            this.ok_button1.Text = "OK";
            this.ok_button1.UseVisualStyleBackColor = false;
            this.ok_button1.Click += new System.EventHandler(this.ok_button1_Click);
            // 
            // GameOverForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(377, 197);
            this.Controls.Add(this.ok_button1);
            this.Controls.Add(this.winner_label1);
            this.Controls.Add(this.text_label2);
            this.Controls.Add(this.header_label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GameOverForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GameOverForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label header_label1;
        private System.Windows.Forms.Label text_label2;
        public System.Windows.Forms.Label winner_label1;
        private System.Windows.Forms.Button ok_button1;
    }
}