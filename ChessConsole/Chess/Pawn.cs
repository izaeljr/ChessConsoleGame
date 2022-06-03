using ChessConsole.Board;

namespace ChessConsole.Chess
{
    class Pawn : Piece
    {
        public Pawn(Color color, BoardGame boardGame) : base(color, boardGame)
        {
        }

        public override string ToString()
        {
            return "P";
        }
    }
}
