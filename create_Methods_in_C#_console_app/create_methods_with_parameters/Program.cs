// ## Variables declared outside a code block are top level or "global" variables. 

// e.g. students is a global variable: 

// ```csharp
// string[] students = {"Jenna", "Ayesha", "Carlos", "Viktor"};

// DisplayStudents(students);
// DisplayStudents(new string[] {"Robert","Vanya"});

// void DisplayStudents(string[] students) 
// {
//     foreach (string student in students) 
//     {
//         Console.Write($"{student}, ");
//     }
//     Console.WriteLine();
// }
// ```


// ## pass by value vs reference: 
// When you pass a value type variable each mathod has a copy of the values so the original is not modified. 

// Reference types are the reference in memory and as such the original can be mutated. 

// value types= int, bool, float, char
// reference types= string, array, obj


// Example - Value

// int a = 3;
// int b = 4;
// int c = 0;

// Multiply(a, b, c);
// Console.WriteLine($"global statement: {a} x {b} = {c}");

// void Multiply(int a, int b, int c) 
// {
//     c = a * b;
//     Console.WriteLine($"inside Multiply method: {a} x {b} = {c}");
// }

// # Output: 
// inside Multiply method: 3 x 4 = 12
// global statement: 3 x 4 = 0

// Globally C is still 0 however within the method it is altered. i.e. the value is not altered in the flobal scope. 

// Example - Reference: 

// int[] array = {1, 2, 3, 4, 5};

// PrintArray(array);
// Clear(array);
// PrintArray(array);

// void PrintArray(int[] array) 
// {
//     foreach (int a in array) 
//     {
//         Console.Write($"{a} ");
//     }
//     Console.WriteLine();
// }

// void Clear(int[] array) 
// {
//     for (int i = 0; i < array.Length; i++) 
//     {
//         array[i] = 0;
//     }
// }

// ### Output: 
// 1 2 3 4 5 
// 0 0 0 0 0

// in this example the second print contains all 0's as the original is altered in the global scope. 


// // ## Methods with optional parameters

// string[] guestList = {"Rebecca", "Nadia", "Noor", "Jonte"};
// string[] rsvps = new string[10];
// int count = 0;

// RSVP("Rebecca", 1, "none", true);
// RSVP("Nadia", 2, "Nuts", true);
// RSVP("Linh", 2, "none", false);
// RSVP("Tony", 1, "Jackfruit", true);
// RSVP("Noor", 4, "none", false);
// RSVP("Jonte", 2, "Stone fruit", false);
// ShowRSVPs();

// void RSVP(string name, int partySize, string allergies, bool inviteOnly) 
// {
//     if (inviteOnly)
//     {
// if (inviteOnly)
// {
//     bool found = false;
//     foreach (string guest in guestList)
//     {
//         if (guest.Equals(name)) {
//             found = true;
//             break;
//         }
//     }
//     if (!found)
//     {
//         Console.WriteLine($"Sorry, {name} is not on the guest list");
//         return;
//     }
// }
//     }

//     rsvps[count] = $"Name: {name}, \tParty Size: {partySize}, \tAllergies: {allergies}";
//     count++;
// }

// void ShowRSVPs()
// {
//     Console.WriteLine("\nTotal RSVPs:");
//     for (int i = 0; i < count; i++)
//     {
//         Console.WriteLine(rsvps[i]);
//     }
// }


// RSVP("Linh", 2, "none", false);

// named arguments: 
// RSVP(name: "Linh", partySize: 2, allergies: "none", inviteOnly: false);

// (name of the parameter : value given to it)

// you do not need to name all parameters: 

// RSVP("Linh", 2, allergies: "none", inviteOnly: false); 

// RSVP("Linh", partySize: 2, "none", false);

// Named arguments are valid as long as they are not followed by any positional arguments: 

// RSVP(allergies: "none", inviteOnly: false, "Linh", 2);


// ## Optional parameters: 

// void RSVP(string name, int partySize = 1, string allergies = "none", bool inviteOnly = true)
// {

// }

// This creates some defaults so they can be used or not used when called.

// # Complete the challenge to display email addresses

// Create a method that displays the correct email address for internal and external employees. 
// List of internal and external names. 
// Employees email consists of their username and company name. 
// Format is first two of the first name followed by complete last name. Internal employees are @contoso.com


// string[,] corporate = 
// {
//     {"Robert", "Bavin"}, {"Simon", "Bright"},
//     {"Kim", "Sinclair"}, {"Aashrita", "Kamath"},
//     {"Sarah", "Delucchi"}, {"Sinan", "Ali"}
// };

// string[,] external = 
// {
//     {"Vinnie", "Ashton"}, {"Cody", "Dysart"},
//     {"Shay", "Lawrence"}, {"Daren", "Valdes"}
// };

// string externalDomain = "hayworth.com";
// displayEmails(corporate, external);


// void displayEmails(string[,] corporate, string[,] external) { 
// for (int i = 0; i < corporate.GetLength(0); i++) 
// {   
//     Console.WriteLine($"{corporate[i,0][0]}{corporate[i,0][1]}{corporate[i,1]}@contoso.com");
// };

// for (int i = 0; i < external.GetLength(0); i++) 
// {
//     Console.WriteLine($"{external[i,0][0]}{external[i,0][1]}{external[i,1]}@{externalDomain}");
// };

// }
