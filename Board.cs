using System;
using System.Collections.Generic;
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
      initializeBoard();
    }
    
    private void initializeBoard()
    {
      // debug
      pieces[0, 0] = new King("a1", "white king", true, false);
      Console.WriteLine(pieces[0, 0].canMove("a1", "a2") ?
        "correct" : "not correct");

      pieces[0, 1] = new Rook("a1", "black rook", true, false);
      Console.WriteLine(pieces[0, 1].canMove("b1", "b3") ?
        "correct" : "not correct"); 

      pieces[0, 2] = new Bishop("a1", "black bishop", false, false);
      Console.WriteLine(pieces[0, 2].canMove("a1", "h8") ?
        "correct" : "not correct");

      pieces[0, 3] = new Queen("a1", "white queen", true, false);
      Console.WriteLine(pieces[0, 2].canMove("a1", "h8") ?
        "correct" : "not correct");

      pieces[0, 4] = new Rook("a1", "black rook", true, false);
      Console.WriteLine(pieces[0, 1].canMove("b1", "b3") ?
        "correct" : "not correct");

      // set isCaptured to false by default!!!!!!!!!!!!
      // TODO: knight, queen, pawn
    }

    private void getMove()
    {
      throw new NotImplementedException();
    }

    private void drawBoard()
    {
      throw new NotImplementedException();
    }
  }
}
