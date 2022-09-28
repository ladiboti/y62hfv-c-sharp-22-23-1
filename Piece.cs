using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ugly_chess
{
  internal abstract class Piece
  {
    public string position { get; set; }
    protected string name { get; }
    protected bool isWhite { get; }
    protected bool isCaptured { get; set; }

    public Piece(string position, string name,
      bool isWhite, bool isCaptured)
    {
      this.position = position;
      this.name = name;
      this.isWhite = isWhite;
      this.isCaptured = isCaptured;
    }

    public abstract bool canMove(string position, string newPosition);

    public string moveToNum(string move)
    { 
      return move.Remove(0, 1)
                .Insert(
                  0, (char.ToUpper(move[0]) - 64).ToString()
                  );
    }

    public bool moveIsValid(string newPosition)
    {
      if (newPosition.Length == 2)
      {
        newPosition = moveToNum(newPosition);

        int pos1 = newPosition[0] - '0';
        int pos2 = newPosition[1] - '0';

        if (Enumerable.Range(1, 8).Contains(pos1)
          && Enumerable.Range(1, 8).Contains(pos2))
        {
          return true;
        }
      }
      return false;
    }
    public void capturePiece(Piece captured)
    {
      captured.isCaptured = true;
    }
  }
}
