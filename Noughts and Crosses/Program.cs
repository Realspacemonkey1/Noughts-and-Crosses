bool playerTurn = false; //playerTurn false == player 1 turn, playerTurn ture == player 2 turn
bool game = true; //Used to determine if the game is being won
string playerInput;
int x = 0;
int y = 0;


string[,] gameBoard = { { "0-0", "0-1", "0-2" }, 
                        { "1-0", "1-1", "1-2" }, 
                        { "2-0", "2-1", "2-2" } }; //Game board is stored as an 2d array


do //The main game loop.
   //Will run until game == false
{
    GameBoardDisplay();

    //Allows the player to input where they would like to place their X/O
    Console.WriteLine("Player {0}, please enter the coordinates where you would like to place your {0}.", PlayerTurnCheck(playerTurn));

    //Put input validation
    playerInput = Console.ReadLine(); 
    x = int.Parse(playerInput.Substring(0, 0));
    y = int.Parse(playerInput.Substring(1, 0));
    gameBoard[x, y] = PlayerTurnCheck(playerTurn);

} while(game == true);


void GameBoardDisplay()
{
    for (int i = 0; i < gameBoard.GetLength(0); i++) //Displays the y values
    {
        for (int j = 0; j < gameBoard.GetLength(1); j++) //Display the x values
        {
            Console.Write(gameBoard[i, j]);
        }
        Console.WriteLine();
    }
}

string PlayerTurnCheck(bool playerTurn)
{
    if (playerTurn == true) { return "X"; }
    else { return "O"; }
}