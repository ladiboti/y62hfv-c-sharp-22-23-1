using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ugly_chess.Pieces
{
  internal class King : Piece
  {
    public static bool isChecked { get; set; }
    public static bool isMated   { get; set; }

    public King(string position, string name, bool isWhite) 
      : base(position, name, isWhite)
    {
      isChecked = false;
      isMated   = false;
    }
    public override bool canMove(
      string position, string newPosition)
    {
      if (moveIsValid(newPosition))
      {
        int pos1 = moveToNum(position)[0] - '0';  // redundant
        int pos2 = moveToNum(position)[1] - '0';

        int newPos1 = moveToNum(newPosition)[0] - '0';
        int newPos2 = moveToNum(newPosition)[1] - '0';

        if (position != newPosition
            && (Math.Abs(pos1 - newPos1) <= 1 
            && Math.Abs(pos2 - newPos2) <= 1))
        {
          return true;
        }
      }
      return false;
    }

  }
}
