using ChessBoardModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChessGameBoardGUI
{
    public partial class Form1 : Form
    {
        //  this references to the class BoardClass. Which has the values of the board that makes it T or F. 
        static BoardClass myBoard = new BoardClass(8);


        // This will determine the buttons that are linked from BoardClass its a 2D array
        public Button[,] btnGrid = new Button[myBoard.Size, myBoard.Size];


        public Form1()
        {

            InitializeComponent();
            fillGrid();
        }

        private void fillGrid()
        {
            int buttonSize = panel1.Width / myBoard.Size;

            // make the panel a perfect square

            panel1.Height = panel1.Width;

            // nested loop to creat button and then print the into the screen

            for(int i=0; i<myBoard.Size; i++)
            {
                for(int j=0; j<myBoard.Size; j++)
                {
                    btnGrid[i, j] = new Button();

                    btnGrid[i,j].Height= buttonSize;
                    btnGrid[i,j].Width= buttonSize;

                    // add a click events to each button 
                    btnGrid[i, j].Click += Grid_Button_Click;

                    panel1.Controls.Add(btnGrid[i,j]);

                    btnGrid[i,j].Location= new Point(i *buttonSize, j * buttonSize);

                    btnGrid[i, j].Text = i + "|" + j;
                    btnGrid[i, j].Tag = new Point(i, j);
                }
            }
        }

        private void Grid_Button_Click(object sender, EventArgs e)
        {
            // get the row and colum number of the button that is clicked 
            Button clickedButton = (Button)sender;
            Point location = (Point)clickedButton.Tag;

            int x= location.X;
            int y= location.Y;  

            Cell currentCell = myBoard.theGride[x,y];


            //determine if the move is legal


            myBoard.MarkNexLegalMove(currentCell, "Queen");


            // update the next move on the board button
            for(int i =0; i < myBoard.Size; i++)
            {
                for(int j =0; j < myBoard.Size; j++)
                {
                    // this will update the board after you move the piece
                    btnGrid[i, j].Text = "";
                    if (myBoard.theGride[i, j].LegalNextMove == true)
                    {
                        btnGrid[i, j].Text = "Legal";       
                    }
                    else if (myBoard.theGride[i,j].CurrentOccupided== true)
                    {
                        btnGrid[i, j].Text = "Legal";
                    }
                }
            }
        }

        private void panel1_Resize(object sender, EventArgs e)
        {
            
        }
    }
}
