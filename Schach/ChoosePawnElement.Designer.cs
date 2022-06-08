namespace Schach
{
    partial class ChoosePawnElement
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
            this.tower_pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bishop_pictureBox1 = new System.Windows.Forms.PictureBox();
            this.color_label1 = new System.Windows.Forms.Label();
            this.queen_pictureBox1 = new System.Windows.Forms.PictureBox();
            this.horse_pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ok_button1 = new System.Windows.Forms.Button();
            this.header_label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tower_pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bishop_pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.queen_pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.horse_pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tower_pictureBox1
            // 
            this.tower_pictureBox1.Location = new System.Drawing.Point(48, 53);
            this.tower_pictureBox1.Name = "tower_pictureBox1";
            this.tower_pictureBox1.Size = new System.Drawing.Size(50, 50);
            this.tower_pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.tower_pictureBox1.TabIndex = 0;
            this.tower_pictureBox1.TabStop = false;
            this.tower_pictureBox1.Click += new System.EventHandler(this.horse_pictureBox1_Click);
            // 
            // bishop_pictureBox1
            // 
            this.bishop_pictureBox1.Location = new System.Drawing.Point(135, 53);
            this.bishop_pictureBox1.Name = "bishop_pictureBox1";
            this.bishop_pictureBox1.Size = new System.Drawing.Size(50, 50);
            this.bishop_pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bishop_pictureBox1.TabIndex = 0;
            this.bishop_pictureBox1.TabStop = false;
            this.bishop_pictureBox1.Click += new System.EventHandler(this.horse_pictureBox1_Click);
            // 
            // color_label1
            // 
            this.color_label1.Location = new System.Drawing.Point(143, 118);
            this.color_label1.Name = "color_label1";
            this.color_label1.Size = new System.Drawing.Size(89, 20);
            this.color_label1.TabIndex = 1;
            this.color_label1.Text = "label1";
            this.color_label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // queen_pictureBox1
            // 
            this.queen_pictureBox1.Location = new System.Drawing.Point(213, 53);
            this.queen_pictureBox1.Name = "queen_pictureBox1";
            this.queen_pictureBox1.Size = new System.Drawing.Size(50, 50);
            this.queen_pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.queen_pictureBox1.TabIndex = 2;
            this.queen_pictureBox1.TabStop = false;
            this.queen_pictureBox1.Click += new System.EventHandler(this.horse_pictureBox1_Click);
            // 
            // horse_pictureBox1
            // 
            this.horse_pictureBox1.Location = new System.Drawing.Point(295, 53);
            this.horse_pictureBox1.Name = "horse_pictureBox1";
            this.horse_pictureBox1.Size = new System.Drawing.Size(50, 50);
            this.horse_pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.horse_pictureBox1.TabIndex = 3;
            this.horse_pictureBox1.TabStop = false;
            this.horse_pictureBox1.Click += new System.EventHandler(this.horse_pictureBox1_Click);
            // 
            // ok_button1
            // 
            this.ok_button1.BackColor = System.Drawing.Color.Black;
            this.ok_button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ok_button1.ForeColor = System.Drawing.Color.White;
            this.ok_button1.Location = new System.Drawing.Point(135, 151);
            this.ok_button1.Name = "ok_button1";
            this.ok_button1.Size = new System.Drawing.Size(97, 44);
            this.ok_button1.TabIndex = 4;
            this.ok_button1.Text = "OK";
            this.ok_button1.UseVisualStyleBackColor = false;
            this.ok_button1.Click += new System.EventHandler(this.ok_button1_Click);
            // 
            // header_label1
            // 
            this.header_label1.BackColor = System.Drawing.Color.Black;
            this.header_label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.header_label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.header_label1.ForeColor = System.Drawing.Color.White;
            this.header_label1.Location = new System.Drawing.Point(0, 0);
            this.header_label1.Name = "header_label1";
            this.header_label1.Size = new System.Drawing.Size(377, 41);
            this.header_label1.TabIndex = 5;
            this.header_label1.Text = "Choose a object";
            this.header_label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.header_label1.Click += new System.EventHandler(this.header_label1_Click);
            // 
            // ChoosePawnElement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(377, 197);
            this.Controls.Add(this.header_label1);
            this.Controls.Add(this.ok_button1);
            this.Controls.Add(this.horse_pictureBox1);
            this.Controls.Add(this.queen_pictureBox1);
            this.Controls.Add(this.color_label1);
            this.Controls.Add(this.bishop_pictureBox1);
            this.Controls.Add(this.tower_pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ChoosePawnElement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ChoosePawnElement";
            this.Load += new System.EventHandler(this.ChoosePawnElement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tower_pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bishop_pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.queen_pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.horse_pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox tower_pictureBox1;
        private System.Windows.Forms.PictureBox bishop_pictureBox1;
        private System.Windows.Forms.PictureBox queen_pictureBox1;
        private System.Windows.Forms.PictureBox horse_pictureBox1;
        public System.Windows.Forms.Label color_label1;
        private System.Windows.Forms.Button ok_button1;
        private System.Windows.Forms.Label header_label1;
    }
}