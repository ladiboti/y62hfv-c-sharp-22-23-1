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
      initializeBoard();
    }
    
    private void initializeBoard()
    {
      pieces[0, 0] = new King("a1", "white king", true, false);
      getMove();
    }

    private void getMove()
    {
      string move = Console.ReadLine();
      bool possibleMove = false;
      for(int i = 0; i < 8; i++)
      {
        for (int j = 0; j < 8; j++)
        {
          if (pieces[i, j] != null)
          {
            if (String.Concat(move[0], move[1]).Equals(pieces[i, j].position)
              && pieces[i, j].moveIsValid(String.Concat(move[2], move[4])))
            {
              pieces[i, j].position = move;
              possibleMove = true;
              break;
            }
          }
        }
      }
      Console.WriteLine(possibleMove ? "good move" : "incorrect move");
    }

    private void drawBoard()
    {
      throw new NotImplementedException();
    }
  }
}
