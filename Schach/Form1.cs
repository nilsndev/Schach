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
    public partial class Schach : Form
    {
        bool blackAlive;
        bool whiteAlive;
     
        bool white = true;
      public  string kingWhitePath = Application.StartupPath + @"\Images\w_king_png_128px.png";
      public  string towerWhitePath = Application.StartupPath + @"\Images\w_rook_png_128px.png";
      public string pawnWhitePath = Application.StartupPath + @"\Images\w_pawn_png_128px.png";
      public string horseWhitePath = Application.StartupPath + @"\Images\w_knight_png_128px.png";
        public string bishopWhitePath = Application.StartupPath + @"\Images\w_bishop_png_128px.png";
        public string queenWhitePath = Application.StartupPath + @"\Images\w_queen_png_128px.png";

        public string kingBlackPath = Application.StartupPath + @"\Images\b_king_png_128px.png";
        public string towerBlackPath = Application.StartupPath + @"\Images\b_rook_png_128px.png";
        public string pawnBlackPath = Application.StartupPath + @"\Images\b_pawn_png_128px.png";
        public string horseBlackPath = Application.StartupPath + @"\Images\b_knight_png_128px.png";
        public string bishopBlackPath = Application.StartupPath + @"\Images\b_bishop_png_128px.png";
        public string queenBlackPath = Application.StartupPath + @"\Images\b_queen_png_128px.png";

        PictureBox[,] buttonField = new PictureBox[8, 8];
        Cell[,] cellField = new Cell[8, 8];
        Point chessObjectLocation;
        Color color = Color.SaddleBrown;

        public Schach()
        {

            InitializeComponent();
        }

        void resetField()
        {
            for (int i = 0; i < 8; i++)
            {



           if (color == Color.SandyBrown)
                    color = Color.SaddleBrown;
                else if (color == Color.SaddleBrown)
                    color = Color.SandyBrown;
          
                for (int j = 0; j < 8; j++)
                {

                    cellField[i, j].nextLegalMove = false;


                    buttonField[i, j].BackColor = color;
                     if (color == Color.SandyBrown)
                           color = Color.SaddleBrown;
                       else if (color == Color.SaddleBrown)
                           color = Color.SandyBrown;
                 
                }
            }
        }

        void printField()
        {
           
            int buttonsize = main_panel1.Width / 8;
            for (int i = 0; i < 8; i++)
            {
                if (color == Color.SandyBrown)
                    color = Color.SaddleBrown;
                else if (color == Color.SaddleBrown)
                    color = Color.SandyBrown;


                for (int j = 0; j < 8; j++)
                {

                    buttonField[i, j] = new PictureBox();
                    cellField[i, j] = new Cell();
                    buttonField[i, j].BorderStyle = BorderStyle.FixedSingle;
                    buttonField[i, j].Width = buttonsize;
                    buttonField[i, j].Height = buttonsize;
                    buttonField[i, j].BackColor = color;
                    buttonField[i, j].SizeMode = PictureBoxSizeMode.Zoom;

                    buttonField[i, j].Click += chess_button_click;
                    buttonField[i, j].Tag = new Point(i, j);

                    this.main_panel1.Controls.Add(buttonField[i, j]);
                    buttonField[i, j].Location = new Point(buttonsize * i, buttonsize * j);
                    if (color == Color.SandyBrown)
                        color = Color.SaddleBrown;
                    else if (color == Color.SaddleBrown)
                        color = Color.SandyBrown;

                    placeAutoObjects(i, j, buttonField[i, j]);
                }
            }
        }

     
        void placeAutoObjects(int i, int j, PictureBox b)
        {   //Place Auto Black Images-----
            if (j == 0)
            {
                if (i == 0 || i == 7)
                {

                    b.ImageLocation = towerBlackPath;

                }
                if (i == 1 || i == 6)
                {

                    b.ImageLocation = horseBlackPath;
                }
                if (i == 2 || i == 5)
                {

                    b.ImageLocation = bishopBlackPath;
                }
                if (i == 3)
                {

                    b.ImageLocation = queenBlackPath;
                }
                if (i == 4)
                {

                    b.ImageLocation = kingBlackPath;
                }

                cellField[i, j].objectColor = "Black";

            }
            //============================

            //Place Black Pawn------------
            if (j == 1)
            {

                b.ImageLocation = pawnBlackPath;
                cellField[i, j].objectColor = "Black";
            }
            //============================

            //Place White Pawn------------
            if (j == 6)
            {

                b.ImageLocation = pawnWhitePath;
                cellField[i, j].objectColor = "White";

            }
            //============================

            //Place Auto White Images-----
            if (j == 7)
            {
                if (i == 0 || i == 7)
                {

                    b.ImageLocation = towerWhitePath;

                }
                if (i == 1 || i == 6)
                {
                    b.ImageLocation = horseWhitePath;

                }
                if (i == 2 || i == 5)
                {
                    b.ImageLocation = bishopWhitePath;

                }
                if (i == 3)
                {
                    b.ImageLocation = kingWhitePath;


                }
                if (i == 4)
                {


                    b.ImageLocation = queenWhitePath;


                }


                cellField[i, j].objectColor = "White";
            }
            //============================
        }

        private void chess_button_click(object sender, EventArgs e)
        {


            PictureBox clickedButton = sender as PictureBox;
            Point location = (Point)clickedButton.Tag;


            if ((cellField[location.X, location.Y].objectColor == "White" && !white) && clickedButton.BackColor != Color.LightBlue || (cellField[location.X, location.Y].objectColor == "Black" && white) && clickedButton.BackColor != Color.LightBlue)
            {
                return;
            }
            gameObject_pictureBox1.BackColor = clickedButton.BackColor;


            if (clickedButton.ImageLocation == null && clickedButton.BackColor != Color.LightBlue)
            {
                return;
            }


            if (clickedButton.BackColor == Color.LightBlue)
            {

                clickedButton.ImageLocation = null;
                clickedButton.ImageLocation = gameObject_pictureBox1.ImageLocation;
                buttonField[chessObjectLocation.X, chessObjectLocation.Y].ImageLocation = null;
                buttonField[chessObjectLocation.X, chessObjectLocation.Y].Text = "";
                cellField[location.X, location.Y].objectColor = cellField[chessObjectLocation.X, chessObjectLocation.Y].objectColor;
                cellField[chessObjectLocation.X, chessObjectLocation.Y].objectColor = "";

               

                resetField();
                if (white)
                {
                    white = false;
                }
                else if (!white)
                {
                    white = true;
                }

                checkWinner();


                upgradePawn(location);
                return;
            }

            gameObject_pictureBox1.ImageLocation = clickedButton.ImageLocation;
            chessObjectLocation = (Point)clickedButton.Tag;
            resetField();
            checkImage(clickedButton.ImageLocation, location);


            LoadLegalMoves();
           
            checkWinner();

        }

    

        private void Schach_Load_1(object sender, EventArgs e)
        {
            
            printField();

        }

        private void reset_button1_Click(object sender, EventArgs e)
        {

            removeButtons();
            printField();
        }

        #region Methods
        void LoadLegalMoves()
        {
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    if (cellField[i, j].nextLegalMove)
                    {
                        buttonField[i, j].BackColor = Color.LightBlue;
                    }
                }
            }

        }
        void checkKingLegalMoves(Point location, string color)
        {
            if (!checkImagefRangeBool(location.X, location.Y + 1, "King", color))
            {
                checkOutOfRange(location.X, location.Y + 1, "King", color);
            }
            if (!checkImagefRangeBool(location.X, location.Y -1, "King", color))
            {
                checkOutOfRange(location.X, location.Y - 1, "King", color);
            }
            if (!checkImagefRangeBool(location.X + 1, location.Y, "King", color))
            {
                checkOutOfRange(location.X + 1, location.Y, "King", color);
            }
            if (!checkImagefRangeBool(location.X -1, location.Y, "King", color))
            {
                checkOutOfRange(location.X - 1, location.Y, "King", color);
            }
            if (!checkImagefRangeBool(location.X - 1, location.Y +1, "King", color))
            {
                checkOutOfRange(location.X - 1, location.Y +1, "King", color);
            }
            if (!checkImagefRangeBool(location.X + 1, location.Y + 1, "King", color))
            {
                checkOutOfRange(location.X + 1, location.Y + 1, "King", color);
            }
            if (!checkImagefRangeBool(location.X + 1, location.Y - 1, "King", color))
            {
                checkOutOfRange(location.X + 1, location.Y - 1, "King", color);
            }
            if (!checkImagefRangeBool(location.X - 1, location.Y - 1, "King", color))
            {
                checkOutOfRange(location.X - 1, location.Y - 1, "King", color);
            }


           
            

        }
        void checkHorseLegalMoves(Point location, string color)
        {

            checkOutOfRange(location.X + 2, location.Y - 1, "Horse", color);
            checkOutOfRange(location.X + 2, location.Y + 1, "Horse", color);
            checkOutOfRange(location.X + 1, location.Y + 2, "Horse", color);
            checkOutOfRange(location.X - 1, location.Y + 2, "Horse", color);
            checkOutOfRange(location.X + 1, location.Y - 2, "Horse", color);
            checkOutOfRange(location.X - 1, location.Y - 2, "Horse", color);
            checkOutOfRange(location.X - 2, location.Y - 1, "Horse", color);
            checkOutOfRange(location.X - 2, location.Y + 1, "Horse", color);

        }
        void checkBishopLegalMoves(Point location, string color)
        {

            for (int i = 1; i < 8; i++)
            {
                if (checkImagefRangeBool(location.X+i, location.Y + i, "Tower", color))
                {
                    break;
                }
                checkOutOfRange(location.X +i, location.Y + i, "Tower", color);
            }

            //==========================================================

            //-----------------------Y-1--------------------------------
            for (int i = 1; i < 8; i++)
            {
                if (checkImagefRangeBool(location.X -i, location.Y - i, "Tower", color))
                {
                    break;
                }
                checkOutOfRange(location.X-i, location.Y - i, "Tower", color);
            }

            //==========================================================
            //X+1
            for (int i = 1; i < 8; i++)
            {
                if (checkImagefRangeBool(location.X -i, location.Y + i, "Tower", color))
                {
                    break;
                }
                checkOutOfRange(location.X - i, location.Y + i, "Tower", color);
            }
            //==========================================================
            // Y - 1------------------------------------------------------

            for (int i = 1; i < 8; i++)
            {
                if (checkImagefRangeBool(location.X + i, location.Y - i, "Tower", color))
                {
                    break;
                }
                checkOutOfRange(location.X + i, location.Y - i, "Tower", color);
            }
            
        }
        void checkTowerLegalMoves(Point location, string color)
        {   //Y+1------------------------------------------------------

            for (int i = 1; i < 8; i++)
            {
                if (checkImagefRangeBool(location.X,location.Y + i,"Tower",color))
                {
                    break;
                }
                checkOutOfRange(location.X, location.Y + i, "Tower", color);
            }

            //==========================================================

            //-----------------------Y-1--------------------------------
            for (int i = 1; i < 8; i++)
            {
                if (checkImagefRangeBool(location.X, location.Y - i, "Tower", color))
                {
                    break;
                }
                checkOutOfRange(location.X, location.Y - i, "Tower", color);
            }

            //==========================================================
            //X+1
            for (int i = 1; i < 8; i++)
            {
                if (checkImagefRangeBool(location.X + i, location.Y, "Tower", color))
                {
                    break;
                }
                checkOutOfRange(location.X + i, location.Y, "Tower", color);
            }
            //==========================================================
            // Y - 1------------------------------------------------------

            for (int i = 1; i < 8; i++)
            {
                if (checkImagefRangeBool(location.X - i, location.Y, "Tower", color))
                {
                    break;
                }
                checkOutOfRange(location.X -i, location.Y, "Tower", color);
            }

            //============
        }
        void checkPawnLegalMoves(Point location, string color)
        {
            if (color == "White")
            {


                checkOutOfRange(location.X, location.Y - 1, "Pawn", color);

                if (location.Y == 6 && cellField[location.X, location.Y - 1].nextLegalMove)
                {

                    checkOutOfRange(location.X, location.Y - 2, "Pawn", color);
                }

              

                //Pawn Diagonal-----------------------------------------------------------------------------------------------------------------------------------
                try
                {
                    if (buttonField[location.X + 1, location.Y - 1].ImageLocation != null && cellField[location.X + 1, location.Y - 1].objectColor != color)
                    {
                        cellField[location.X + 1, location.Y - 1].nextLegalMove = true;
                       
                    }
                }
                catch
                {
                }

                
                try
                {
                    
                    if (buttonField[location.X - 1, location.Y - 1].ImageLocation != null && cellField[location.X - 1, location.Y - 1].objectColor != color)
                    {
                        cellField[location.X - 1, location.Y - 1].nextLegalMove = true;
                    }
                }
                catch { }
                //================================================================================================================================================
            }
            if (color == "Black")
            {
                checkOutOfRange(location.X, location.Y + 1, "Pawn", color);
                if (location.Y == 1 && cellField[location.X, location.Y + 1].nextLegalMove)
                {


                    checkOutOfRange(location.X, location.Y + 2, "Pawn", color);



                }
            
                //Pawn Diagonal-----------------------------------------------------------------------------------------------------------------------------------
                try
                {
                    if (buttonField[location.X + 1, location.Y + 1].ImageLocation != null && cellField[location.X + 1, location.Y + 1].objectColor != color)
                    {
                        cellField[location.X + 1, location.Y + 1].nextLegalMove = true;
                    }
                }
                catch
                {
                }
                try
                {
                    if (buttonField[location.X - 1, location.Y + 1].ImageLocation != null && cellField[location.X - 1, location.Y + 1].objectColor != color)
                    {
                        cellField[location.X - 1, location.Y + 1].nextLegalMove = true;
                    }
                }

                catch { }
                //================================================================================================================================================
            }


        }
        void checkImage(string imgLocation, Point location)
        {
            if (imgLocation == pawnWhitePath)
            {
                checkPawnLegalMoves(location, "White");
            }
            if (imgLocation == pawnBlackPath)
            {
                checkPawnLegalMoves(location, "Black");
            }
            if (imgLocation == towerWhitePath)
            {
                checkTowerLegalMoves(location, "White");
            }

            if (imgLocation == towerBlackPath)
            {
                checkTowerLegalMoves(location, "Black");
            }
            if (imgLocation == horseWhitePath)
            {
                checkHorseLegalMoves(location, "White");
            }
            if (imgLocation == horseBlackPath)
            {
                checkHorseLegalMoves(location, "Black");
            }
            if (imgLocation == bishopWhitePath)
            {
                checkBishopLegalMoves(location, "White");
            }
            if (imgLocation == bishopBlackPath)
            {
                checkBishopLegalMoves(location, "Black");

            }
            if (imgLocation == kingWhitePath)
            {
                checkKingLegalMoves(location, "White");
            }
            if (imgLocation == kingBlackPath)
            {
                checkKingLegalMoves(location, "Black");
            }
            if (imgLocation == queenWhitePath)
            {
                checkTowerLegalMoves(location, "White");
                checkBishopLegalMoves(location, "White");
            }
            if (imgLocation == queenBlackPath)
            {
                checkTowerLegalMoves(location, "Black");
                checkBishopLegalMoves(location, "Black");
            }

        }
         

        bool checkInFontOf(int x, int y, string chessGameObject, string color)
        {
            if (chessGameObject == "Pawn")
            {

                if (buttonField[x, y].ImageLocation != null)
                {
                    return false;
                }

            }
            if (chessGameObject == "Horse")
            {
                if (cellField[x, y].objectColor == color)
                {
                    return false;
                }
            }
            
            return true;
        }
        void checkOutOfRange(int x, int y, string chessGameObject, string color)
        {
            try
            {

                cellField[x, y].nextLegalMove = checkInFontOf(x, y, chessGameObject, color);
             
            }
            catch
            {

            }

        }
        bool checkImagefRangeBool(int x, int y, string chessGameObject, string color)
        {
            try
            {
                if (buttonField[x, y].ImageLocation != null && cellField[x, y].objectColor != color)
                {
                   
                    cellField[x, y].nextLegalMove = true;
                    buttonField[x, y].BackColor = Color.LightBlue;
                  
                }

                if (buttonField[x, y].ImageLocation != null)
                {
                    return true;
                }
               
                return false;
            }
            catch
            {
                return false;
            }

        }
        void checkWinner()
        {
            GameOverForm gmf = new GameOverForm();
            whiteAlive = false;
            blackAlive = false;
            for (int x = 0; x < 8; x++)
            {
                for (int y = 0; y < 8; y++)
                {
                   
                    if (buttonField[x,y].ImageLocation == kingBlackPath)
                    {
                        blackAlive = true;
                    }
                    if (buttonField[x, y].ImageLocation == kingWhitePath)
                    {
                         whiteAlive = true;
                    }

                }
                if (blackAlive && whiteAlive)
                {
                    return;
                }
            }
           
          
           if(whiteAlive && !blackAlive)
            {
                gmf.winner_label1.Text = "White";

                
            }
            if (!whiteAlive && blackAlive)
            {
                gmf.winner_label1.Text = "Black";
               
            }

             gmf.ShowDialog();

            if(gmf.DialogResult == DialogResult.OK)
            {
                removeButtons();
                printField();
            }
            
          
        }

        void removeButtons()
        {
            for(int i = 0; i < 8; i++)
            {
                for(int j= 0; j < 8; j++)
                {
                    this.main_panel1.Controls.Remove(buttonField[i,j]);
                }
            }
           
        }
        void upgradePawn(Point location)
        {
            if ((location.Y == 0 || location.Y == 7) && (buttonField[location.X, location.Y].ImageLocation == pawnWhitePath || buttonField[location.X, location.Y].ImageLocation == pawnBlackPath))
            {
                string fieldColor = "";
                if (buttonField[location.X, location.Y].ImageLocation == pawnWhitePath)
                {
                    fieldColor = "White";
                }
                else
                {
                    fieldColor = "Black";
                }
                ChoosePawnElement f = new ChoosePawnElement();
                f.color_label1.Text = fieldColor;
                f.ShowDialog();
                f.Dispose();
                if (f.DialogResult == DialogResult.OK)
                {
                    buttonField[location.X, location.Y].ImageLocation = f.imagePath;
                }
            }
        }
        #endregion

    }


}
