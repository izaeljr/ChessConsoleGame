using ChessConsole.Board;
using ChessConsole.Chess;

namespace ChessConsole
{
    public class Program
    {
        static void Main(string[] args)
        {
            try
            {
                BoardGame board = new BoardGame(8, 8);

                board.PutPiece(new Tower(Color.Black, board), new Position(0, 0));
                board.PutPiece(new King(Color.Black, board), new Position(3, 5));

                Screen.PrintBoard(board);
            } 
            catch (BoardException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}