
using System;
using ChessChallenge.API;
using System.Collections;
using System.Diagnostics;
//TODO: add the ability to en passant whenever possible, for teh lulz 
public class MyBot : IChessBot
{
    //comment
    public Move Think(Board board, Timer timer)
    {
        bool MoveIsGood(Board board, Move move)
        {
            board.GetLegalMoves();
            if (move.IsEnPassant)
            {
                MakeMove(Move move);
                return 
            }
        }
    
    }
}