// # Return types: 
// ## Void
// void PrintMessage(string message) { 
//     return (this return would just stop the operations)
// }

// void indicates that there is no return and the method is just performing an operation

// ## Data type

// When a data type is used the method performs an operation and returns the specified type upon completion. 

// int PrintMessage(string message) { 
//     return (a value that is an integer)
// }

// # Challenge: 
// Use Methods to calculate the total purchase price: 

// double total = 0;
// double minimumSpend = 30.00;

// double[] items = {15.97, 3.50, 12.25, 22.99, 10.98};
// double[] discounts = {0.30, 0.00, 0.10, 0.20, 0.50};

// for (int i = 0; i < items.Length; i++)
// {
//     total += GetDiscountedPrice(i);
// }

// if (TotalMeetsMinimum())
// {
//     total -= 5.00;
// }

// Console.WriteLine($"Total: ${FormatDecimal(total)}");

// double GetDiscountedPrice(int itemIndex)
// {
//     return result = items[itemIndex] * ( 1 - discounts[itemIndex]);  
//     // Calculate the discounted price of the item
// }

// bool TotalMeetsMinimum()
// {
//     return total >= minimumSpend;
// }

// string FormatDecimal(double input)
// {
//     return input.ToString().Substring(0,5); 
// }

// ## return numbers from methods: 

// double usd = 23.73;
// int vnd = UsdToVnd(usd);
// double vnd2 = UsdToVnd(usd);

// Console.WriteLine($"${usd} USD = ${vnd} VND");
// Console.WriteLine($"${usd} USD = ${vnd2} VND");

// int UsdToVnd(double usd) 
// {
//     int rate = 23500;
//     return (int) (rate * usd);
// }

// double VndToUsd(int vnd) 
// {
//     int rate = 23500;
//     return (rate * usd);
// }

// ## Return strings from methods

// use a loop to target each letter within a word and append it to a result string and then return this final string

// string ReverseWord(string word) 
// {
//     string result = "";
//     for (int i = word.Length - 1; i >= 0; i--) 
//     {
//         result += word[i];
//     }
//     return result;
// }

// Now reverse a sentence: 

// string input = "there are snakes at the zoo";

// Console.WriteLine(input);
// Console.WriteLine(ReverseSentence(input));

// string ReverseSentence(string input) 
// {
//     string result = "";
//     string[] words = input.Split(" ");
//     foreach(string word in words) 
//     {
//         result += ReverseWord(word) + " ";
//     }
//     return result.Trim();
// }

// string ReverseWord(string word) 
// {
//     string result = "";
//     for (int i = word.Length - 1; i >= 0; i--) 
//     {
//         result += word[i];
//     }
//     return result;
// }

// ## return a bool from a method: 

// bool IsPalindrome(string word) 
// {
//     int start = 0;
//     int end = word.Length - 1;

//     while (start < end) 
//     {
//         if (word[start] != word[end]) 
//         {
//             return false;
//         }
//         start++;
//         end--;
//     }

//     return true;
// }

// ## Return arrays from Methods: 

// using an array to find the matching coins to reach the level of change

// int target = 60;
// int[] coins = new int[] {5, 5, 50, 25, 25, 10, 5};
// int[] result = TwoCoins(coins, target);

// if (result.Length == 0) 
// {
//     Console.WriteLine("No two coins make change");
// } 
// else 
// {
//     Console.WriteLine($"Change found at positions {result[0]} and {result[1]}");
// }

// int[] TwoCoins(int[] coins, int target) 
// {
//     for (int curr = 0; curr < coins.Length; curr++) 
//     {
//         for (int next = curr + 1; next < coins.Length; next++) 
//         {
//             if (coins[curr] + coins[next] == target) 
//             {
//             return new int[]{curr, next};
//             }

//     }
// }
// return  new int[0];
// }int target = 30;
// int[] coins = new int[] {5, 5, 50, 25, 25, 10, 5};
// int[,] result = TwoCoins(coins, target);

// if (result.Length == 0) 
// {
//     Console.WriteLine("No two coins make change");
// } 
// else 
// {
//     Console.WriteLine("Change found at positions:");
//     for (int i = 0; i < result.GetLength(0); i++) 
//     {
//         if (result[i,0] == -1) 
//         {
//             break;
//         }
//         Console.WriteLine($"{result[i,0]},{result[i,1]}");
//     }
// }

// int[,] TwoCoins(int[] coins, int target) 
// {
//     int[,] result = {{-1,-1},{-1,-1},{-1,-1},{-1,-1},{-1,-1}};
//     int count = 0;

//     for (int curr = 0; curr < coins.Length; curr++) 
//     {
//         for (int next = curr + 1; next < coins.Length; next++) 
//         {    
//             if (coins[curr] + coins[next] == target) 
//             {
//                 result[count, 0] = curr;
//                 result[count, 1] = next;
//                 count++;
//             }
//             if (count == result.GetLength(0)) 
//             {
//                 return result;
//             }
//         }
//     }
//     return (count == 0) ? new int[0,0] : result;
// }

// ## Alternatively: 

// you can use a 2 dimensional array as a results array and add the values when they match the taretted total and then use a for loop to return the 2 dimensional array: 

// int target = 30;
// int[] coins = new int[] {5, 5, 50, 25, 25, 10, 5};
// int[,] result = TwoCoins(coins, target);

// if (result.Length == 0) 
// {
//     Console.WriteLine("No two coins make change");
// } 
// else 
// {
//     Console.WriteLine("Change found at positions:");
//     for (int i = 0; i < result.GetLength(0); i++) 
//     {
//         if (result[i,0] == -1) 
//         {
//             break;
//         }
//         Console.WriteLine($"{result[i,0]},{result[i,1]}");
//     }
// }

// int[,] TwoCoins(int[] coins, int target) 
// {
//     int[,] result = {{-1,-1},{-1,-1},{-1,-1},{-1,-1},{-1,-1}};
//     int count = 0;

//     for (int curr = 0; curr < coins.Length; curr++) 
//     {
//         for (int next = curr + 1; next < coins.Length; next++) 
//         {    
//             if (coins[curr] + coins[next] == target) 
//             {
//                 result[count, 0] = curr;
//                 result[count, 1] = next;
//                 count++;
//             }
//             if (count == result.GetLength(0)) 
//             {
//                 return result;
//             }
//         }
//     }
//     return (count == 0) ? new int[0,0] : result;
// }


// # Challenge: 
// ## build a role the dice game: 

// starting code: 
// Random random = new Random();

// Console.WriteLine("Would you like to play? (Y/N)");
// if (ShouldPlay()) 
// {
//     PlayGame();
// }

// void PlayGame() 
// {
//     var play = true;

//     while (play) 
//     {
//         var target;
//         var roll;

//         Console.WriteLine($"Roll a number greater than {target} to win!");
//         Console.WriteLine($"You rolled a {roll}");
//         Console.WriteLine(WinOrLose());
//         Console.WriteLine("\nPlay again? (Y/N)");

//         play = ShouldPlay();
//     }
// }

// Random random = new Random();

// Console.WriteLine("Would you like to play? (Y/N)");
// if (ShouldPlay()) 
// {
//     PlayGame();
// }
// bool ShouldPlay() 
// { 
//     // should retrieve user input and determine if the user wants to play again 
//     // Read user input from the console.
//     string readLine = Console.ReadLine();
    
//     // Correctly apply string methods to process input and ensure it's stored back in readLine.
//     readLine = readLine.ToLower().Trim();

//     // Use '==' for comparison, not '=' which is assignment.
//     if (readLine == "y")
//     {
//         return true;
//     }
//     else if (readLine == "n") // Corrected from '=' to '=='
//     {
//         Console.WriteLine("Game over, thank you.");
//         return false;
//     }
//     else
//     {
//         Console.WriteLine("Invalid selection, please enter 'y' or 'n'.");
//         return ShouldPlay(); // Recursive call if input is not valid
//     }
// }


// void PlayGame() 
// {
//     var play = true;

//     while (play) 
//     {
//         var target = getTarget();
//         var roll = rollNumber();

//         Console.WriteLine($"Roll a number greater than {target} to win!");
//         Console.WriteLine($"You rolled a {roll}");
//         Console.WriteLine(WinOrLose(target, roll));
//         Console.WriteLine("\nPlay again? (Y/N)");

//         play = ShouldPlay();
//     }
// }

// int getTarget()
// {
//     return random.Next(1,6);
// }

// int rollNumber()
// { 
//     return random.Next(1,6);
// }

// string WinOrLose(int target, int roll)
// { 
//     if (roll > target) 
//     { 
//             return "Perfect Roll, you win!";        
//     } 
//     else 
//     { 
//             return "Better luck next time, you lose!";        

//     }

//     // determine if the player has won or lost
// }