using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using ugly_chess.Pieces;

namespace ugly_chess
{
  internal class Board
  {
    private Piece[,] pieces = new Piece[8, 8];

    private const int WindowWidth = 400;
    private const int WindowHeight = 400;

    private const ConsoleColor lightColor = ConsoleColor.Gray;
    private const ConsoleColor darkColor = ConsoleColor.Black;
    public Board()
    {

    }
    
    private void initializeBoard()
    {
      King whiteKing = new King("a1", "white king", true, false);
    }

    private void drawBoard()
    {
      throw new NotImplementedException();
    }
  }
}
