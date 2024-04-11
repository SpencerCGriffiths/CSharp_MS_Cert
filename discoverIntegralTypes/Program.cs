/*
Discover integral types

Signed and Unsigned Integral types: 

A signed integer is a 32-bit datum that encodes an integer in the range [-2147483648 to 2147483647]. An unsigned integer is a 32-bit datum that encodes a nonnegative integer in the range [0 to 4294967295].

*/

// Console.WriteLine("Signed integral types:");

// Console.WriteLine($"sbyte  : {sbyte.MinValue} to {sbyte.MaxValue}");
// Console.WriteLine($"short  : {short.MinValue} to {short.MaxValue}");
// Console.WriteLine($"int    : {int.MinValue} to {int.MaxValue}");
// Console.WriteLine($"long   : {long.MinValue} to {long.MaxValue}");

// Console.WriteLine("");
// Console.WriteLine("Unsigned integral types:");

// Console.WriteLine($"byte   : {byte.MinValue} to {byte.MaxValue}");
// Console.WriteLine($"ushort : {ushort.MinValue} to {ushort.MaxValue}");
// Console.WriteLine($"uint   : {uint.MinValue} to {uint.MaxValue}");
// Console.WriteLine($"ulong  : {ulong.MinValue} to {ulong.MaxValue}");
// Console.WriteLine("");
// Console.WriteLine("Floating point types:");
// Console.WriteLine($"float  : {float.MinValue} to {float.MaxValue} (with ~6-9 digits of precision)");
// Console.WriteLine($"double : {double.MinValue} to {double.MaxValue} (with ~15-17 digits of precision)");
// Console.WriteLine($"decimal: {decimal.MinValue} to {decimal.MaxValue} (with 28-29 digits of precision)");
/*
Discover floating-point types

A floating point is a simple value type that represents numbers to the right of the decimal place. Unlike integral numbers there ar other considerations beyond the Max and Min values you can store in a given floating point type. 

1- digits of precision (number of places after decimal)

2- How values are stored and Acurracy
- Float and Double are stored internally in binary (base 2) vs decimal (base 10). Math in base 10 is more accurate than base 2. If number used to calculate snowball splatter in game being a thousandth off is not a problem and Float/Double uses less memory. However if important financial data you will want to use the memory for decimal. 
*/

// // // Console.WriteLine("");
// // // Console.WriteLine("Floating point types:");
// // // Console.WriteLine($"float  : {float.MinValue} to {float.MaxValue} (with ~6-9 digits of precision)");
// // // Console.WriteLine($"double : {double.MinValue} to {double.MaxValue} (with ~15-17 digits of precision)");
// // // Console.WriteLine($"decimal: {decimal.MinValue} to {decimal.MaxValue} (with 28-29 digits of precision)");

// output
/* 
Floating point types:
float  : -3.402823E+38 to 3.402823E+38 (with ~6-9 digits of precision)
double : -1.79769313486232E+308 to 1.79769313486232E+308 (with ~15-17 digits of precision)
decimal: -79228162514264337593543950335 to 79228162514264337593543950335 (with 28-29 digits of precision)

" E notation " 10 raised to the power off:  
5E+2 = 500 because 5 * 10^2
*/


//Reference tpes
/* 
Value type variable stores values directly in stack. When stack frame finished executing the value in the stack removed. 

Reference type variable stores value in a separate memory region the heap. The heap is a memory area that is ahred across applications runing on the OS at the same time. .NET runtime communicates with OS to determine what memory addresses are available. 
*/

// int[] data;

// This is a variable that can hold the value of an integer array. Data is a variable that could hole a reference (memory address) of a value in the heap. 

// // int[] data;
// // data = new int[3];

// new creates an instance of the integer array and then coordinates with the OS storing an array of size three in memory. .NET runtimes compiles and returns a memory address of the new array. The memory address is stored in the variable. The integer array values default to 0. 

// // int[] data = new int[3];

// This is the shorthand

