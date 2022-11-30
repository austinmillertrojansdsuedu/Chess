using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess.Model
{
    abstract class Piece
    {
        private bool captured;
        private bool white;

        public Piece(bool white)
        {
            throw new NotImplementedException();
        }

        public bool isWhite()
        {
            return this.white;
        }

        public void setWhite(bool isWhite)
        {
            throw new NotImplementedException();
        }

        public bool isCaptured()
        {
            return this.captured;
        }

        public void setCaptured(bool captured)
        {
            throw new NotImplementedException();
        }

        public bool canMove()
        {
            throw new NotImplementedException();
        }
    }
}
