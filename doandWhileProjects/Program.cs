/* Project 1 - write code that validates integer input

Here are the conditions that your first coding project must implement:
Your solution must include either a do-while or while iteration.
Before the iteration block: your solution must use a Console.WriteLine() statement to prompt the user for an integer value between 5 and 10.
Inside the iteration block:
Your solution must use a Console.ReadLine() statement to obtain input from the user.
Your solution must ensure that the input is a valid representation of an integer.
If the integer value isn't between 5 and 10, your code must use a Console.WriteLine() statement to prompt the user for an integer value between 5 and 10.
Your solution must ensure that the integer value is between 5 and 10 before exiting the iteration.
Below (after) the iteration code block: your solution must use a Console.WriteLine() statement to inform the user that their input value has been accepted.

*/

/*
Console.WriteLine("Please enter a number between 5 and 10 inclusive: "); 
string? input; 
bool validInput = false;

do { 
    input = Console.ReadLine();
    int numericValue = 0;
    bool validNumber = false;
    validNumber = int.TryParse(input, out numericValue);
    if(validNumber) {
        if (!(numericValue > 5 && numericValue < 10)) {
            Console.WriteLine($"{numericValue} is not between 5 and 10. Please try again."); 
        } else { 
                    validInput = true;
        }
    } else if (!validNumber) { 
        Console.WriteLine("that was not a valid input please try again");
    }
} while (!validInput);

Console.WriteLine("your input has been accepted. \n \t Thank you");
*/



/*
Code project 2 - write code that validates string input
Here are the conditions that your second coding project must implement:
Your solution must include either a do-while or while iteration.

Before the iteration block: your solution must use a Console.WriteLine() statement to prompt the user for one of three role names: Administrator, Manager, or User.
Inside the iteration block:
Your solution must use a Console.ReadLine() statement to obtain input from the user.
Your solution must ensure that the value entered matches one of the three role options.
Your solution should use the Trim() method on the input value to ignore leading and trailing space characters.
Your solution should use the ToLower() method on the input value to ignore case.
If the value entered isn't a match for one of the role options, your code must use a Console.WriteLine() statement to prompt the user for a valid entry.
Below (after) the iteration code block: Your solution must use a Console.WriteLine() statement to inform the user that their input value has been accepted.
*/
// before - prompt with write line for admin manager or user
// inside - take input 
// matches one of the three roles 
// use Trim and to Lower to ignore leading and trailing and cases
// if not okay consolewrite line to say so
// after iteration if accepted should say it is accepted

/* 
Console.WriteLine("Please enter your title i.e. Admin, Manager or User?: "); 
string? input; 
string role; 
bool validInput = false;

do { 
    input = Console.ReadLine();
    role = input.Trim().ToLower();

switch (role) { 
    case "user" : 
    case "admin" : 
    case "manager" : 
        validInput = true;
        break; 
    default: 
        Console.WriteLine("input was not valid please try again");
        break; 

}

} while (!validInput);

Console.WriteLine("your input has been accepted. \n \t Thank you");

*/

/*
Code project 3 - Write code that processes the contents of a string array

Here are the conditions that your third coding project must implement:
your solution must use the following string array to represent the input to your coding logic:

string[] myStrings = new string[2] { "I like pizza. I like roast chicken. I like salad", "I like all three of the menu choices" };

Your solution must declare an integer variable named periodLocation that can be used to hold the location of the period character within a string.
Your solution must include an outer foreach or for loop that can be used to process each string element in the array. The string variable that you'll process inside the loops should be named myString.
In the outer loop, your solution must use the IndexOf() method of the String class to get the location of the first period character in the myString variable. The method call should be similar to: myString.IndexOf("."). If there's no period character in the string, a value of -1 will be returned.
Your solution must include an inner do-while or while loop that can be used to process the myString variable.
In the inner loop, your solution must extract and display (write to the console) each sentence that is contained in each of the strings that are processed.
In the inner loop, your solution must not display the period character.
In the inner loop, your solution must use the Remove(), Substring(), and TrimStart() methods to process the string information.
*/
// int variable named periodLocation to hold location of period character
// outer loop to process each string element
// inside loop its myString
// outer loop must use .IndexOf()
// in the inner loop solution must extract and display each sentence of the string
// inner loop not display period 
// inner loop must use Remove(), Substring() and TrimStart() methods. 



/* ------!!!!!!! NOT COMPLETE !!!!!

string[] myStrings = new string[2] { "I like pizza. I like roast chicken. I like salad", "I like all three of the menu choices" };
int periodLocation; 
foreach (string myString in myStrings) { 
    myString.IndexOf(".")
}

string s1 = myStrings[0];  
char[] ch = {'.'};  
string s2 = s1.TrimStart(ch);  
Console.WriteLine(s2);  
         
*/