
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
        Move[] allMoves = board.GetLegalMoves();
        Random rng = new();
        Move moveToPlay = allMoves[rng.Next(allMoves.Length)];
        
        foreach (var variabMove in board.GetLegalMoves())
        {
            if (variabMove.IsEnPassant)
            {
                moveToPlay = move;
                break;
            }

            
              
            
        }
     
    }
}
     
                
            
            


            
        
    

