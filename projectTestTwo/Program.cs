// Console.WriteLine("a" == "a");
// Console.WriteLine("a" == "A");
// Console.WriteLine(1 == 2);

// string myValue = "a";
// Console.WriteLine(myValue == "a");

// using Ternary Operator:

// Random coin = new Random();
// int flip = coin.Next(0, 2);
// Console.WriteLine( $"The coin flip is {(flip == 0 ? "Heads" : "Tails")}");


/* 
Coding Challenge: 

string permission = "Manager";
int level = 19;

// Admin / level > 55 
// Welcome, Super Admin user.

// Admin / Level <= 55 
// Welcome, Admin user.

// Manager Level >= 20 
// Contact an Admin for access.

// Manager Level < 20 
// You do not have sufficient privileges.

// !Admin || !Manager 
// You do not have sufficient privileges.


if (permission.Contains("Admin")) { 
Console.WriteLine(level > 55 ? "Welcome, Super Admin user." : "Welcome, Admin user.");
} else if (permission.Contains("Manager")) { 
Console.WriteLine(level >= 20 ? "Contact an Admin for access." : "You do not have sufficient privileges.");
} else { 
Console.WriteLine("You do not have sufficient privileges.");
}

*/ 



// FizzBuzz coding Challenge - for loops

// Here are the FizzBuzz rules that you need to implement in your code project:

// Output values from 1 to 100, one number per line, inside the code block of an iteration statement.
// When the current value is divisible by 3, print the term Fizz next to the number.
// When the current value is divisible by 5, print the term Buzz next to the number.
// When the current value is divisible by both 3 and 5, print the term FizzBuzz next to the number.

// for (int i = 0; i <= 100; i++) { 
//     string result = i.ToString(); 
    
//     if( i % 3 == 0 && i % 5 == 0) { 
//         result += " FizzBuzz"; 
//     } else if (i % 3 == 0) { 
//         result += " Fizz"; 
//     } else if (i % 5 == 0) { 
//         result += " Buzz"; 
//     }

//     Console.WriteLine(result);
// }