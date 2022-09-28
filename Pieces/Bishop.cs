﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ugly_chess.Pieces
{
  internal class Bishop : Piece
  {
    public Bishop(string position, string name,
      bool isWhite, bool isCaptured)
        : base(position, name, isWhite, isCaptured)
    {
      // empty???
    }

    public override bool canMove(string position, string newPosition)
    {
      if (moveIsValid(newPosition))
      {
        int pos1 = moveToNum(position)[0] - '0';  // still redundant
        int pos2 = moveToNum(position)[1] - '0';

        int newPos1 = moveToNum(newPosition)[0] - '0';
        int newPos2 = moveToNum(newPosition)[1] - '0';

        if (position != newPosition    // TODO: simplyfy
          && Math.Abs(pos1 - newPos1) == Math.Abs(pos2 - newPos2))
        {
          return true;
        }

      }
      return false;
    }
  }
}
