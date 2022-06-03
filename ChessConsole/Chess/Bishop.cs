using ChessConsole.Board;

namespace ChessConsole.Chess
{
    class Bishop : Piece
    {
        public Bishop(Color color, BoardGame boardGame) : base(color, boardGame)
        {
        }

        public override string ToString()
        {
            return "B";
        }
    }
}
