namespace Othello
{
    internal class Game
    {
        private List<Piece> _pieces;

        public Game()
        {
            _pieces = new List<Piece>();
            _pieces.Add(new Piece(Color.White, 4, 'd'));
            _pieces.Add(new Piece(Color.Black, 4, 'e'));
            _pieces.Add(new Piece(Color.Black, 5, 'd'));
            _pieces.Add(new Piece(Color.White, 5, 'e'));
        }

        public void Show()
        {
            ShowBoard();
            foreach (var piece in _pieces)
            {
                piece.Show();
            }
            Console.SetCursorPosition(1,12);
        }

        private static void ShowBoard()
        {
            Console.WriteLine("   a b c d e f g h ");
            for (int i = 0; i < 64; i++)
            {
                var rowIndex = i / 8;
                var rowNo = rowIndex + 1;
                var colIndex = i % 8;
                if (colIndex == 0)
                {
                    if (i > 0)
                    {
                        Console.Write("|");
                        Console.WriteLine();
                    }

                    Console.Write(rowNo);
                    Console.Write(' ');
                }

                Console.Write("|");
                Console.Write(' ');
            }

            Console.WriteLine("|");
        }
    }
}
