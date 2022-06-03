using ChessConsole.Board;

namespace ChessConsole.Chess
{
    class King : Piece
    {
        public King(Color color, BoardGame boardGame) : base(color, boardGame)
        {
        }

        public override string ToString()
        {
            return "K";
        }
    }
}
