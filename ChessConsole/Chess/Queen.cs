using ChessConsole.Board;

namespace ChessConsole.Chess
{
    class Queen : Piece
    {
        public Queen(Color color, BoardGame boardGame) : base(color, boardGame)
        {
        }

        public override string ToString()
        {
            return "Q";
        }
    }
}
