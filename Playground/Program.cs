using System;
using Playground.Math;

namespace Playground
{
    class Program
    {
        static void Main(string[] args)
        {
            var user1 = new Person();
            user1.FirstName = "Sherifdeen";
            user1.LastName = "Adebayo";
            user1.Introduce();
            
            var result = Calculator.Add(1, 2);
            Console.WriteLine(result);
        }
    }
}