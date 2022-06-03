using ChessConsole.Board;

namespace ChessConsole.Chess
{
    class Knight : Piece
    {
        public Knight(Color color, BoardGame boardGame) : base(color, boardGame)
        {
        }

        public override string ToString()
        {
            return "H";
        }
    }
}
