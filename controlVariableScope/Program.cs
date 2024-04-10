int[] numbers = { 4, 8, 15, 16, 23, 42 };

int total = 0;
foreach (int number in numbers) { 
    total += number;
}
Console.WriteLine($" Set {(numbers.Contains(42) ? "contains 42": "does not contain 42")} \n Total: {total}");

// intended oucome: 
/*
Set contains 42
Total: 108
*/ 

