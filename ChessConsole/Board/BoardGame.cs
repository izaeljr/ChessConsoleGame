namespace ChessConsole.Board
{
    class BoardGame
    {
        public int Rows { get; set; }
        public int Columns { get; set; }
        private Piece[,] Pieces;

        public BoardGame(int rows, int columns)
        {
            Rows = rows;
            Columns = columns;
            Pieces = new Piece[Rows, Columns];
        }

        public Piece GetPiece(int row, int column)
        {
            return Pieces[row, column];
        }

        public Piece GetPiece(Position pos)
        {
            return Pieces[pos.Row, pos.Column];
        }

        public bool IsPiece(Position pos)
        {
            ValidPosition(pos);
            return GetPiece(pos) != null;
        }

        public void PutPiece(Piece p, Position pos)
        {
            if (IsPiece(pos))
            {
                throw new BoardException("Position already has a piece.");
            }
            Pieces[pos.Row, pos.Column] = p;
            p.Position = pos;
        }

        public bool IsValidPosition(Position pos)
        {
            if (pos.Row < 0 || pos.Column < 0 || pos.Row > Rows || pos.Column > Columns)
            {
                return false;
            }
            return true;
        }

        public void ValidPosition(Position pos)
        {
            if (!IsValidPosition(pos))
            {
                throw new BoardException("Invalid position.");
            }
        }
    }
}
