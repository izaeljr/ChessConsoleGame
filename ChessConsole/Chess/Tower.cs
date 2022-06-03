using ChessConsole.Board;

namespace ChessConsole.Chess
{
    class Tower : Piece
    {
        public Tower(Color color, BoardGame boardGame) : base(color, boardGame)
        {
        }

        public override string ToString()
        {
            return "T";
        }
    }
}
