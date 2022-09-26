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

    public King(string position, string name,
      bool isWhite, bool isCaptured) 
      : base(position, name, isWhite, isCaptured)
    {
      isChecked = false;
      isMated   = false;

      Console.WriteLine((isWhite ? "white" : "black") + " king placed");
    }
    public override bool moveIsValid(string newPosition)
    {
      if(newPosition.Length == 2)
      {
        newPosition = newPosition
                      .Remove(0, 1)
                      .Insert(
                        0, (char.ToUpper(newPosition[0]) - 64).ToString()
                       );
        if (Enumerable.Range(1, 8).Contains((int)newPosition[0])
            && Enumerable.Range(1, 8).Contains((int)newPosition[1])){
          
          //king specific TODO: remove this noob stuff
          if (Math.Abs((int)this.position[0] - (int)newPosition[0]) == 1 
            || Math.Abs((int)this.position[1] - (int)newPosition[1]) == 1)
          {
            return true;
          }

        }
      }
      return false;
      //throw new NotImplementedException();
    }
  }
}
