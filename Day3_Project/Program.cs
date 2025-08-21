// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

using System;

Random random = new Random();
Console.CursorVisible = false;
int height = Console.WindowHeight - 1;
int width = Console.WindowWidth - 5;
bool shouldExit = false;

// Console position of the player
int playerX = 0;
int playerY = 0;

// Console position of the food
int foodX = 0;
int foodY = 0;

// Available player and food strings
string[] states = {">'-'<", ">^-^<", "(X_X)"};
string[] foods = {"@@@@@", "$$$$$", "#####"};

// Current player string displayed in the Console
string player = states[0];

// Index of the current food
int food = 0;

//Debug toggle
bool DEBUG = true;

void Log(string message)
{
    if (DEBUG)
    {
        Console.Title = message;
    }
}

InitializeGame();

bool excitOnUnsupportedInput = true;
bool speedButtonPressed = true;

{
    Console.Clear();
    ShowFood();  // show the food
    Console.SetCursorPosition(0, 0);
    Console.Write(player);
    Log($"Player at  ({playerX},{playerY}) with state  {player}");
}
// while (!shouldExit)
// {
//     Move();

//     if (PlayerAteFood())
//     {
//         ChangePlayer(); // change the plaer

//         if (PlayerShouldFreeze())
//         {
//             FreezePlayer();
//             Console.WriteLine("You are Frozen!");
//             Console.Write(player);
//             Log($"Player froze at ({playerX},{playerY}) with state {player}");
//         }

//         ShowFood(); // show the food
//         Log($"Ate food at ({foodX},{foodY}) with state {player}");
//     }

//         Console.WriteLine("You ate the food!");
//         ShowFood();
// }
//METHODS//

// Returns true if the Terminal was resized 
// bool TerminalResized() 
// {
//     return height != Console.WindowHeight - 1 || width != Console.WindowWidth - 5;
// }

// Displays random food at a random location
void ShowFood() 
{
    // Update food to a random index
    food = random.Next(0, foods.Length);

    // Update food position to a random location
    foodX = random.Next(0, width - player.Length);
    foodY = random.Next(0, height - 1);

    // Display the food at the location
    Console.SetCursorPosition(foodX, foodY);
    Console.Write(foods[food]);
}

// Changes the player to match the food consumed
void ChangePlayer() 
{
    player = states[food];
    Console.SetCursorPosition(playerX, playerY);
    Console.Write(player);
}

// Temporarily stops the player from moving
void FreezePlayer() 
{
    System.Threading.Thread.Sleep(1000);
    player = states[0];
}

// Reads directional input from the Console and moves the player
void Move(bool excitOnUnsupported = false, int horizontalSpeed = 1) 
{
    int lastX = playerX;
    int lastY = playerY;
    
    var key = Console.ReadKey(true).Key;

    switch (key)
    {
        case ConsoleKey.UpArrow:
            playerY--;
            break;
        case ConsoleKey.DownArrow:
            playerY++;
            break;
        case ConsoleKey.LeftArrow:
            playerX -= horizontalSpeed;
            break;
        case ConsoleKey.RightArrow:
            playerX += horizontalSpeed; ;
            break;
        case ConsoleKey.Escape:
            shouldExit = true;
            Console.Clear();
            break;
        default:
            if (excitOnUnsupported)
            {
                shouldExit = true;
                Console.Clear();
                Console.WriteLine("Unsupported key pressed");
            }
            break;
    }

    Log($"Key:{key} Pos:({playerX},{playerY}) Speed:{horizontalSpeed} State:{player}");


    // Clear the characters at the previous position
    Console.SetCursorPosition(lastX, lastY);
    for (int i = 0; i < player.Length; i++) 
    {
        Console.Write(" ");
    }

    // Keep player position within the bounds of the Terminal window
    playerX = (playerX < 0) ? 0 : (playerX >= width ? width : playerX);
    playerY = (playerY < 0) ? 0 : (playerY >= height ? height : playerY);

    // Draw the player at the new location
    Console.SetCursorPosition(playerX, playerY);
    Console.Write(player);
}

// Clears the console, displays the food and player
void InitializeGame()
{
    Console.Clear();
    ShowFood();
    Console.SetCursorPosition(0, 0);
    Console.Write(player);
}

bool PlayerAteFood()
{
    return (playerX == foodX && playerY == foodY);
}

bool PlayerShouldFreeze()
{
    return player == states[2]; // {X_X}
}

bool PlayerShouldSpeed()
{
    return player == states[1];  // (^-^)
}

//DEBUG


