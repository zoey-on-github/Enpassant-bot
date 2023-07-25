
using System;
using ChessChallenge.API;
//TODO: do random moves, UNLESS there is an oppurtunity for en passant(the only good move)
//TODO: maybe also implment racks kia's idea of only moving pawns furthest??
public class MyBot : IChessBot
{
    //comment
    public Move Think(Board board, Timer timer)
        //new ChessChallenge.Chess.Move();
    {
        /*
        Random rng = new();
        Move[] allMoves = board.GetLegalMoves();
        
        
        Move moveToPlay = allMoves[rng.Next(allMoves.Length)];
        return moveToPlay;
        */

        //Move[] allMoves = board.GetLegalMoves();
    

    //board.GetLegalMoves();
        //public Boolean IsEnPassant => ChessChallenge.Chess.Move.EnPassantCaptureFlag
        //foreach (Move move in allMoves)
       // {

            if (ChessChallenge.Chess.Move.EnPassantCaptureFlag == 0)
            {
                
            }
            else

            {
                    Random rng = new();
                    Move moveToPlay = allMoves[rng.Next(allMoves.Length)];
                    break;
                }


            }
        }
    }

