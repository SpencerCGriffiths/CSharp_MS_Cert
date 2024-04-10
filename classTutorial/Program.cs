// namespace Classes 
// { 
//     public class Person 
//     { 
//         public string Name; 

//         public void Introduce(string to)
//         { 
//             Console.WriteLine("Hi {0} i am {1}", to, Name);
//         }

//         public static Person Parse(string str) 
//         { 
//             var person = new Person(); 
//             person.Name = str;

//             return person;
//         }
//     }
//     class Program
//     { 
//         static void Main(string[] args)
//         { 
//             var person = Person.Parse("John");
//             person.Introduce("Steve");
//         }
//     }
// }

using System;

namespace CSharpIntermediate
{

    class Program
    { 
        static void Main(string[] args)
        { 
            var c = new Customer(1, "John");

            var order = new Order();
            customer.Orders.Add(order);

            Console.WriteLine(customer.Id);
            Console.WriteLine(customer.Name);
        }
    }
}