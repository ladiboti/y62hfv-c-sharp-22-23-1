using System;
using System.Collections.Generic;
using System.Text;

namespace ugly_chess
{
  internal abstract class Piece
  {
    protected string position   { get; set; }
    protected string name       { get; }
    protected bool   isWhite    { get; }
    protected bool   isCaptured { get; set; }

    public Piece(string position, string name,
      bool isWhite, bool isCaptured)
    {
      this.position   = position;
      this.name       = name;
      this.isWhite    = isWhite;
      this.isCaptured = isCaptured;
    }

    public abstract bool moveIsValid(string newPosition);
    public void capturePiece(Piece captured)
    {
      captured.isCaptured = true;
    }
  }
}
