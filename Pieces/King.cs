using System;
using System.Collections.Generic;
using System.Text;

namespace ugly_chess.Pieces
{
  internal class King : Piece
  {
    private bool isChecked { get; set; }
    private bool isMated   { get; set; }

    public King(string position, string name,
      bool isWhite, bool isCaptured) 
      : base(position, name, isWhite, isCaptured)
    {
      this.isChecked = false;
      this.isMated   = false;
    }
    public override bool moveIsValid(string newPosition)
    {
      throw new NotImplementedException();
    }
  }
}
