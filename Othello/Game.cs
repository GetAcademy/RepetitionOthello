namespace Othello
{
    internal class Game
    {
        private string _board;

        public Game()
        {
            _board = "  hss".PadRight(64, ' ');
        }

        public void Show()
        {
            Console.WriteLine("   a b c d e f g h ");

            for (int i = 0; i < _board.Length; i++)
            {
                var rowIndex = i / 8;
                var rowNo = rowIndex + 1;
                var colIndex = i % 8;
                if (colIndex == 0 )
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
                Console.Write(_board[i]);
            }
            Console.WriteLine("|");
        }
    }
}
