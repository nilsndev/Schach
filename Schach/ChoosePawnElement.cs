using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Schach
{
  
    public partial class ChoosePawnElement : Form
    {

       public string imagePath;

        public ChoosePawnElement()
        {
            InitializeComponent();
        }

        private void ChoosePawnElement_Load(object sender, EventArgs e)
        {
            checkColor(this.color_label1.Text);
            
           
        }

        void checkColor(string color)
        {
            Schach s = new Schach();
            if (color == "White")
            {
                this.bishop_pictureBox1.ImageLocation = s.bishopWhitePath;
                this.tower_pictureBox1.ImageLocation = s.towerWhitePath;
                this.horse_pictureBox1.ImageLocation = s.horseWhitePath;
                this.queen_pictureBox1.ImageLocation = s.queenWhitePath;
            }
           else if(color == "Black")
            {
                this.bishop_pictureBox1.ImageLocation = s.bishopBlackPath;
                this.tower_pictureBox1.ImageLocation = s.towerBlackPath;
                this.horse_pictureBox1.ImageLocation = s.horseBlackPath;
                this.queen_pictureBox1.ImageLocation = s.queenBlackPath;
            }
        }

        private void horse_pictureBox1_Click(object sender, EventArgs e)
        {
            PictureBox pb = sender as PictureBox;
            pb.BackColor = Color.Black;
            foreach(Control p in this.Controls)
            {
                if(p is PictureBox)
                {
                    p.Enabled = false;
                }
                
            }
            imagePath = pb.ImageLocation;
           
        }

        private void ok_button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();

        }

        private void header_label1_Click(object sender, EventArgs e)
        {

        }
    }
}
 