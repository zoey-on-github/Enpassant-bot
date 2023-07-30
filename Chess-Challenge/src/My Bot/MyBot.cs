using System;
using ChessChallenge.API;

//TODO: do random moves, UNLESS there is an oppurtunity for en passant(the only good move)
//TODO: maybe also implement racks kia's idea of only moving pawns furthest??
public class MyBot : IChessBot
{
    public Move Think(Board board, Timer timer)
        //new ChessChallenge.Chess.Move();
    {
        var allMoves = board.GetLegalMoves();
        Random rng = new();
        var moveToPlay = allMoves[rng.Next(allMoves.Length)];

        foreach (var variabMove in board.GetLegalMoves())
        {
            if (variabMove.IsEnPassant)
                Console.WriteLine("holy hell");
            return variabMove;
        }

        return moveToPlay;
    }
}