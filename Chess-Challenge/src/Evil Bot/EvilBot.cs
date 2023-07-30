using System;
using ChessChallenge.API;

namespace ChessChallenge.Example;

// A simple bot that can spot mate in one, and always captures the most valuable piece it can.
// Plays randomly otherwise.
public class EvilBot : IChessBot
{
    // Piece values: null, pawn, knight, bishop, rook, queen, king
    private readonly int[] pieceValues = { 0, 100, 300, 300, 500, 900, 10000 };

    public Move Think(Board board, Timer timer)
    {
        var allMoves = board.GetLegalMoves();

        // Pick a random move to play if nothing better is found
        Random rng = new();
        var moveToPlay = allMoves[rng.Next(allMoves.Length)];
        var highestValueCapture = 0;

        foreach (var move in allMoves)
        {
            // Always play checkmate in one
            if (MoveIsCheckmate(board, move))
            {
                moveToPlay = move;
                break;
            }

            // Find highest value capture
            var capturedPiece = board.GetPiece(move.TargetSquare);
            var capturedPieceValue = pieceValues[(int)capturedPiece.PieceType];

            if (capturedPieceValue > highestValueCapture)
            {
                moveToPlay = move;
                highestValueCapture = capturedPieceValue;
            }
        }

        return moveToPlay;
    }

    // Test if this move gives checkmate
    private bool MoveIsCheckmate(Board board, Move move)
    {
        board.MakeMove(move);
        var isMate = board.IsInCheckmate();
        board.UndoMove(move);
        return isMate;
    }
}