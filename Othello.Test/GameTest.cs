using System.Drawing;

namespace Othello.Test
{
    public class GameTest
    {
        [Test]
        public void AddPiece()
        {
            // arrange
            var game = new Game();
            var expectedBoard = "        " + 
                             "        " + 
                             "        " + 
                             "  shs   " + 
                             "   sh   " + 
                             "        " + 
                             "        " + 
                             "        ";

            // act
            game.AddPiece(Color.Black, 4, 'c');
            var actualBoard = game.GetBoard();

            // assert

            Assert.AreEqual(expectedBoard, actualBoard);
        }

        [Test]
        public void TestStartBoard()
        {
            // arrange
            var startBoard = "        " + 
                             "        " + 
                             "        " + 
                             "   hs   " + 
                             "   sh   " + 
                             "        " + 
                             "        " + 
                             "        ";
            // act
            var game = new Game();
            var board = game.GetBoard();

            // assert
            Assert.AreEqual(startBoard, board);
        }
    }
}