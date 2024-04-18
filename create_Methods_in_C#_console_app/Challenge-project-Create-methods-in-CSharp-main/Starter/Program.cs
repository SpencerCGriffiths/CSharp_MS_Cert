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
string[] states = {"('-')", "(^-^)", "(X_X)"};
string[] foods = {"@@@@@", "$$$$$", "#####"};

// Current player string displayed in the Console
string player = states[0];
int playerIndex = 0; 


// Index of the current food
int food = 0;


while (!shouldExit) 
{  
    gamePlay(); 

}

void gamePlay()
{ 
    InitializeGame();
    bool resize = TerminalResized(); 
    bool eaten = foodEaten(); 
    
    while(!resize && !eaten) 
    {
        resize = TerminalResized();
        Move(); 
        eaten = foodEaten();
    }  

    if (resize)
    { 
        Console.WriteLine("Console was resized. Program exiting");
        shouldExit = true;
    }

    if (eaten)
    { 
        if(anotherGame())
        { 
            gamePlay();
        } 
        else if (!anotherGame())
        { 
            shouldExit = true; 
        }
    }

}

bool foodEaten()
{   
        if (playerX == foodX && playerY == foodY)
        { 
            Console.WriteLine("!!!yum!!!");

            Console.WriteLine("next level? Y/N"); 
            return true;
        }
    return false; 
}

bool anotherGame()
{ 
    string result = Console.ReadLine(); 
    result = result.ToLower().Trim();
    if(result == "y") 
    { 
        return true;
    }
    else if (result == "n")
    { 
        return false;
    }
    else
    { 
        Console.WriteLine("That response is not accepted- Game ending"); 
        return false; 
    }

}
// Returns true if the Terminal was resized 
bool TerminalResized() 
{
    return height != Console.WindowHeight - 1 || width != Console.WindowWidth - 5;
}

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
    playerIndex = food;
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
void Move() 
{
    int lastX = playerX;
    int lastY = playerY;
    int value = 1; 
    
    if(playerIndex == 1)
    { 
         value =  3;

    }
    
    if(playerIndex == 2)
    { 
        Console.WriteLine("uh oh... pause!");
        System.Threading.Thread.Sleep(4000);
    }



    switch (Console.ReadKey(true).Key) 
    {
        case ConsoleKey.UpArrow:
            playerY -= value; 
            break;
		case ConsoleKey.DownArrow: 
            playerY += value; 
            break;
		case ConsoleKey.LeftArrow:  
            playerX -= value; 
            break;
		case ConsoleKey.RightArrow: 
            playerX += value; 
            break;
		case ConsoleKey.Escape:     
            shouldExit = true; 
            break;
    }

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
    playerX = 0;
    playerY = 0;
    Console.Clear();
    ChangePlayer(); 
    ShowFood();
    Console.SetCursorPosition(0, 0);
    Console.Write(player);
}