
using System;
using ChessChallenge.API;
using System.Collections;
using System.Diagnostics;
using System.Transactions;

//TODO: do random moves, UNLESS there is an oppurtunity for en passant(the only good move)
//TODO: maybe also implment racks kia's idea of only moving pawns furthest??
public class MyBot : IChessBot
{
    //comment
    public Move Think(Board board, Timer timer)
    {
        Random rng = new();
        Move[] allMoves = board.GetLegalMoves();
        
        
        bool MoveIsGood(Board board, Move move)
        {
            board.GetLegalMoves();
            if (move.IsEnPassant)
            {
                ;
            }
            else

            {
                Random rng = new();
            }
        }
    
    }
}