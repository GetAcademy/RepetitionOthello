namespace Othello
{
    internal class Piece
    {
        private Color _color;
        private int _row;
        private int _col;

        public Piece(Color color, int row, char col)
        {
            _color = color;
            _row = row;
            _col = (col - 'a') + 1;
        }

        public void Show()
        {
            Console.SetCursorPosition(_col * 2 + 1, _row);
            Console.Write(_color == Color.White ? 'h' : 's');
        }
    }
}
