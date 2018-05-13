using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    class GameEngine : IGameEngine
    {
        public void processMove (int [,]generalField, Player player, int targetLine, int targetColum)
        {
            int numberOfLines = player.gameField.GetLength(0);
            int numberOfColumns = player.gameField.GetLength(1) - 1;
            player.gameField[0, targetLine] += 1;
            player.gameField[1, targetColum] += 1;
            generalField[targetLine, targetColum] = player.getSign();
            if (targetLine == targetColum)
                player.gameField[0, numberOfColumns] += 1;
            for (int i = 0; i < numberOfColumns; i++)
            {
                if (targetLine == i && targetColum == numberOfColumns - i - 1)
                    player.gameField[1, numberOfColumns] += 1;
            }
        }
        public int [] makeMove (int[,] generalField, Player human, Player computer)
        {
            int[] targetLineAndColumn = new int[2];
            Random random = new Random();
            int numberOfLines = computer.gameField.GetLength(0);
            int numberOfColumns = computer.gameField.GetLength(1) - 1;
            for (int i = 0; i < numberOfLines; i++)
            {
                for (int j = 0; j < numberOfColumns; j++)
                {
                    if (computer.gameField[i, j] == numberOfColumns - 1 && human.gameField[i, j] == 0)
                    {     
                            if (i == 0)
                            {
                                for (int z = 0; z < numberOfColumns; z++)
                                {
                                    if (generalField[j, z] == 0)
                                    {
                                        targetLineAndColumn[0] = j;
                                        targetLineAndColumn[1] = z;
                                        return targetLineAndColumn;
                                    }
                                }
                            }
                            if (i == 1)
                            {
                                for (int z = 0; z < numberOfColumns; z++)
                                {
                                    if (generalField[z, j] == 0)
                                    {
                                        targetLineAndColumn[0] = z;
                                        targetLineAndColumn[1] = j;
                                        return targetLineAndColumn;
                                    }
                                }
                            }
                    }
                }
                if (computer.gameField[i, numberOfColumns] == numberOfColumns - 1 && human.gameField[i, numberOfColumns] == 0)
                {
                        if (i == 0)
                        {
                            for (int z = 0; z < numberOfColumns; z++)
                            {
                                if (generalField[z, z] == 0)
                                {
                                    targetLineAndColumn[0] = z;
                                    targetLineAndColumn[1] = z;
                                    return targetLineAndColumn;
                                }
                            }
                        }
                        else
                        {
                            for (int z = 0; z < numberOfColumns; z++)
                            {
                                if (generalField[z, numberOfColumns - z - 1] == 0)
                                {
                                    targetLineAndColumn[0] = z;
                                    targetLineAndColumn[1] = numberOfColumns - z - 1;
                                    return targetLineAndColumn;
                                }
                            }
                        }
                }
            }


                for (int i = 0; i < numberOfLines; i++)
                {
                    for (int j = 0; j < numberOfColumns; j++)
                    {
                        if (human.gameField[i, j] == numberOfColumns - 1 && computer.gameField[i, j] == 0)
                        {
                                if (i == 0)
                                {
                                    for (int z = 0; z < numberOfColumns; z++)
                                    {
                                        if (generalField[j, z] == 0)
                                        {
                                            targetLineAndColumn[0] = j;
                                            targetLineAndColumn[1] = z;
                                            return targetLineAndColumn;
                                        }
                                    }
                                }
                                if (i == 1)
                                {
                                    for (int z = 0; z < numberOfColumns; z++)
                                    {
                                        if (generalField[z, j] == 0)
                                        {
                                            targetLineAndColumn[0] = z;
                                            targetLineAndColumn[1] = j;
                                            return targetLineAndColumn;
                                        }
                                    }
                                }
                        }
                    }
                    if (human.gameField[i, numberOfColumns] == numberOfColumns - 1 && computer.gameField[i, numberOfColumns] == 0)
                    {
                            if (i == 0)
                            {
                                for (int z = 0; z < numberOfColumns; z++)
                                {
                                    if (generalField[z, z] == 0)
                                    {
                                        targetLineAndColumn[0] = z;
                                        targetLineAndColumn[1] = z;
                                        return targetLineAndColumn;
                                    }
                                }
                            }
                            else
                            {
                                for (int z = 0; z < numberOfColumns; z++)
                                {
                                    if (generalField[z, numberOfColumns - z - 1] == 0)
                                    {
                                        targetLineAndColumn[0] = z;
                                        targetLineAndColumn[1] = numberOfColumns - z - 1;
                                        return targetLineAndColumn;
                                    }
                                }
                            }
                    }
                }
                for (int i = 0; i < numberOfLines; i++)
                {
                    for (int j = 0; j < numberOfColumns; j++)
                    {
                        if (human.gameField[i, j] != 0 && human.gameField[i, j] + computer.gameField[i, j] != numberOfColumns)
                        {
                            
                                if (i == 0)
                                {
                                    targetLineAndColumn[0] = j;
                                    targetLineAndColumn[1] = random.Next(0, numberOfColumns);
                                    while (generalField[targetLineAndColumn[0], targetLineAndColumn[1]] != 0)
                                        targetLineAndColumn[1] = random.Next(0, numberOfColumns);
                                    return targetLineAndColumn;
                                }
                                else
                                {
                                    targetLineAndColumn[1] = j;
                                    targetLineAndColumn[0] = random.Next(0, numberOfColumns);
                                    while (generalField[targetLineAndColumn[0], targetLineAndColumn[1]] != 0)
                                        targetLineAndColumn[0] = random.Next(0, numberOfColumns);
                                    return targetLineAndColumn;
                                }
                        }
                    }
                }
                return targetLineAndColumn;
        }
        public bool checkWin (Player player)
        {
            for (int i = 0; i < player.gameField.GetLength(0); i++)
            {
                for (int j = 0; j < player.gameField.GetLength(1); j++)
                    if (player.gameField[i, j] == player.gameField.GetLength(1) - 1)
                        return true;
            }
            return false;
        }
        public bool checkDraw(int [,] generalField)
        {
            for (int i = 0; i < generalField.GetLength(0); i++)
            {
                for (int j = 0; j < generalField.GetLength(1); j++)
                {
                    if (generalField[i, j] == 0)
                        return false;
                }                   
            }
            return true;
        }
    }
}

