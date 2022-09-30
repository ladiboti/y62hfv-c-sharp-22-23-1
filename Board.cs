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
      /*pieces[0, 0] = new King("--", "white king", true);
      Console.WriteLine(pieces[0, 0].canMove("a1", "a2") ?
        "correct" : "not correct");

      pieces[0, 1] = new Rook("--", "black rook", true);
      Console.WriteLine(pieces[0, 1].canMove("b1", "b3") ?
        "correct" : "not correct"); 

      pieces[0, 2] = new Bishop("--", "black bishop", false);
      Console.WriteLine(pieces[0, 2].canMove("a1", "h8") ?
        "correct" : "not correct");

      pieces[0, 3] = new Rook("--", "black rook", true);
      Console.WriteLine(pieces[0, 3].canMove("b1", "b3") ?
        "correct" : "not correct");

      pieces[0, 4] = new Queen("--", "white queen", true);
      Console.WriteLine(pieces[0, 4].canMove("a1", "h8") ?
        "correct" : "not correct");


      pieces[0, 5] = new Knight("--", "black knight", false);
      Console.WriteLine(pieces[0, 5].canMove("b2", "c3") ?
       "correct" : "not correct");

      pieces[0, 6] = new Knight("--", "black knight", false);
      Console.WriteLine(pieces[0, 6].canMove("b2", "a3") ?
       "correct" : "not correct");

      pieces[0, 7] = new Knight("--", "black knight", false);
      Console.WriteLine(pieces[0, 7].canMove("b2", "b3") ?
       "correct" : "not correct");*/

      Knight k1 = new Knight("a1", "black knight", false);

      /*Console.WriteLine(k1.canMove("d4", "c6") ?
       "correct" : "not correct");

      Console.WriteLine(k1.canMove("d4", "b5") ?
       "correct" : "not correct");

      Console.WriteLine(k1.canMove("d4", "b5") ?
       "correct" : "not correct");

      Console.WriteLine(k1.canMove("d4", "b3") ?
       "correct" : "not correct");

      Console.WriteLine(k1.canMove("d4", "c2") ?
       "correct" : "not correct");

      Console.WriteLine(k1.canMove("d4", "e6") ?
      "correct" : "not correct");

      Console.WriteLine(k1.canMove("d4", "f5") ?
      "correct" : "not correct");

      Console.WriteLine(k1.canMove("d4", "f5") ?
      "correct" : "not correct");

      Console.WriteLine(k1.canMove("d4", "e2") ?
      "correct" : "not correct");

      Console.WriteLine(k1.canMove("d4", "f3") ?
      "correct" : "not correct");

      Console.WriteLine(k1.canMove("d6", "d6") ?
     "correct" : "not correct");

      Console.WriteLine(k1.canMove("d6", "d2") ?
     "correct" : "not correct");

      Console.WriteLine(k1.canMove("d6", "b4") ?    // RETURNS CORRECT!!!
     "correct" : "not correct");

      Console.WriteLine(k1.canMove("d6", "f5") ?   //RETURNS CORRECT!!!
     "correct" : "not correct");*/

      k1.showAllMoves();


      // set isCaptured to false by default!!!!!!!!!!!!
      // TODO: knight, pawn
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
