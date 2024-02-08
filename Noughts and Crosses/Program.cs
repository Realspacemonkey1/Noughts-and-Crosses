bool playerTurn = false; //playerTurn false == player 1 turn, playerTurn ture == player 2 turn
string[,] gameBoard = { { "-", "-", "-" }, { "-", "-", "-" }, { "-", "-", "-" } }; //Game board is stored as an 2d array

GameBoardDisplay();


void GameBoardDisplay()
{
    for (int i = 0; i < gameBoard.GetLength(0); i++)
    {
        for (int j = 0; j < gameBoard.GetLength(1); j++)
        {
            Console.Write(gameBoard[i, j]);
        }
        Console.WriteLine();
    }
}