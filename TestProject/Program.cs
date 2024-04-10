// Random dice = new Random();
// int roll = dice.Next(1, 7);
// Console.WriteLine(roll);


// overloaded class: 

// Random dice = new Random();
// int roll1 = dice.Next();
// int roll2 = dice.Next(101);
// int roll3 = dice.Next(50, 101);

// Console.WriteLine($"First roll: {roll1}");
// Console.WriteLine($"Second roll: {roll2}");
// Console.WriteLine($"Third roll: {roll3}");

// Random dice = new Random();

// int roll1 = dice.Next(1, 7);
// int roll2 = dice.Next(1, 7);
// int roll3 = dice.Next(1, 7);

// int total = roll1 + roll2 + roll3;

// Console.WriteLine($"Dice roll: {roll1} + {roll2} + {roll3} = {total}");

// if ((roll1 == roll2) || (roll2 == roll3) || (roll1 == roll3))
// {
//     Console.WriteLine("You rolled doubles! +2 bonus to total!");
//     total += 2;
// }

// if (total >= 15)
// {
//     Console.WriteLine("You win!");
// }

// if (total < 15)
// {
//     Console.WriteLine("Sorry, you lose.");
// }



// working with if else:  

// Random random = new Random();
// int daysUntilExpiration = random.Next(12);
// int discountPercentage = 0;




// if (daysUntilExpiration <= 0) { 
//     Console.WriteLine("Your subscription has expired."); 
// } else if (daysUntilExpiration == 1) { 
//     Console.WriteLine("Your subscription expires within a day! \nRenew now and save 20%!");
// } else if (daysUntilExpiration <= 5 ) {
//     Console.WriteLine($"Your subscription expires in {daysUntilExpiration} days.\n Renew now and save 10%!" );
// } else if (daysUntilExpiration <= 10) { 
//     Console.WriteLine("Your subscription will expire soon. Renew now!");
// }
// // Your code goes here


// using Arrays and For Each:

// string[] orderNums = {"B123", "C234", "A345", "C15", "B177", "G3003", "C235", "B179"};
// foreach (string order in orderNums) { 
// if (order.StartsWith('B')) { 
// Console.WriteLine(order);
// }
// }

