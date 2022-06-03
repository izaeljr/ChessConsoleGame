namespace ChessConsole.Board
{
    class Piece
    {
        public Position Position { get; set; }
        public Color Color { get; protected set; }
        public int QuantityOfMovements { get; protected set; }
        public BoardGame BoardGame { get; protected set; }

        public Piece(Color color, BoardGame boardGame)
        {
            Color = color;
            BoardGame = boardGame;
            QuantityOfMovements = 0;
        }
    }
}
