using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{   
    class Program
    {
        static void Main(string[] args)
        {            
            IGameInitiating gameInitiating = new GameInitiating();
            IFieldDrawer fieldDrawer = new FieldDrawer();
            IMoveChecker moveChecker = new MoveChecker();
            IGameEngine gameEngine = new GameEngine();
            Console.WriteLine("Tic-tac-toe!");
            Console.WriteLine("Input size of field: ");
            var sizeOfField = Int32.Parse(Console.ReadLine());
            while (sizeOfField < 3 || sizeOfField > 9)
            {
                Console.WriteLine("Input size of field: ");
                sizeOfField = Int32.Parse(Console.ReadLine());
            }
            Console.WriteLine("Input your name: ");
            string name = Console.ReadLine();
            Player computer = new Computer(sizeOfField);
            Player human = new Human(sizeOfField);
            int[,] generalField = gameInitiating.generalFieldCreating(sizeOfField);
            fieldDrawer.drawField(generalField, human, computer);
            bool gameOver = false;
            while (!gameOver)
            {
                Console.WriteLine("Your turn, {0}: ", name);
                string turnString = Console.ReadLine();
                var targetLine = 0;
                var targetColumn = 0;
                while (!moveChecker.checkArrayCorrectness(turnString.Split(' ')) ||
                    !Int32.TryParse(turnString.Split(' ')[0], out targetLine) || !Int32.TryParse(turnString.Split(' ')[1], out targetColumn) ||
                    !moveChecker.checkArrayContent(sizeOfField, targetLine, targetColumn) || !moveChecker.checkPosition(generalField, targetLine, targetColumn))
                {
                    Console.WriteLine("Please, again: ");
                    turnString = Console.ReadLine();
                }
                targetLine = targetLine - 1;
                targetColumn = targetColumn - 1;
                gameEngine.processMove(generalField, human, targetLine, targetColumn);
                if (gameEngine.checkWin(human))
                {
                    Console.WriteLine("{0} wins!", name);
                    fieldDrawer.drawField(generalField, human, computer);
                    gameOver = true;
                    continue;
                }
                if (gameEngine.checkDraw(generalField))
                {
                    Console.WriteLine("Draw!");
                    fieldDrawer.drawField(generalField, human, computer);
                    gameOver = true;
                    continue;
                }
                fieldDrawer.drawField(generalField, human, computer);
                Console.WriteLine("My turn. Thanks.");
                int [] computerTarget = gameEngine.makeMove(generalField, human, computer);
                gameEngine.processMove(generalField, computer, computerTarget[0], computerTarget[1]); 
                fieldDrawer.drawField(generalField, human, computer);
                if (gameEngine.checkWin(computer))
                {
                    Console.WriteLine("Computer wins!");
                    fieldDrawer.drawField(generalField, human, computer);
                    gameOver = true;
                    continue;
                }
                if (gameEngine.checkDraw(generalField))
                {
                    Console.WriteLine("Draw!");
                    fieldDrawer.drawField(generalField, human, computer);
                    gameOver = true;
                    continue;
                }
            }
            Console.ReadLine();
        }
    }
}
