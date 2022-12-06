using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessBoardModel
{
     public class BoardClass
    {
        // the spixe of the board is 8x8
        public int Size { get; set; }
        // 2 day array of type cell for board
        public Cell[, ] theGride { get; set; }

        // constructor for BoardClass

        public BoardClass (int s)
        {

            // inital size of the board is defined by s its a consturutor 
            Size = s;
            theGride = new Cell[Size, Size];

            // this will create cells for each index of the board which is 2D array x and y corrdiantion
            for(int i = 0;i < Size; i++)
            {
                for (int j = 0; j < Size; j++) 
                {
                    theGride[i,j] = new Cell(i, j);
                }   
            }
        }

        public void MarkNexLegalMove(Cell currentCell, string chessPiece)
        {
            // step 1 clear all previous legal moves
            // visit all the cells and set the index for each as false using for loop
            for (int i = 0; i < Size; i++)
            {
                for (int j = 0; j < Size; j++)
                {
                    theGride[i, j].LegalNextMove = false;
                    theGride[i, j].CurrentOccupided = false;
                }
            }


            // step 2 find all legal moves and mark the cells as legal
            // using switch statment
            switch (chessPiece)
            {
                case "Knight":
                    theGride[currentCell.RowNumber + 2, currentCell.ColumnNuber + 1].LegalNextMove = true;
                    theGride[currentCell.RowNumber + 2, currentCell.ColumnNuber - 1].LegalNextMove = true;
                    theGride[currentCell.RowNumber - 2, currentCell.ColumnNuber + 1].LegalNextMove = true;
                    theGride[currentCell.RowNumber - 2, currentCell.ColumnNuber - 1].LegalNextMove = true;
                    theGride[currentCell.RowNumber + 1, currentCell.ColumnNuber + 2].LegalNextMove = true;
                    theGride[currentCell.RowNumber + 1, currentCell.ColumnNuber - 2].LegalNextMove = true;
                    theGride[currentCell.RowNumber - 1, currentCell.ColumnNuber + 2].LegalNextMove = true;
                    theGride[currentCell.RowNumber - 1, currentCell.ColumnNuber - 2].LegalNextMove = true;

                    break;
                case "King":
                    break;
                case "Rook":
                    break;
                case "Bishop":
                    break;
                case "Queen":
                    break;

            }
            theGride[currentCell.RowNumber, currentCell.ColumnNuber].CurrentOccupided = true ;
        }
    }
}
