using System;

namespace Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "1";
            int i = Convert.ToInt32(s);
            int j = int.Parse(s);

            Console.WriteLine("i={0}, j={1}", i, j);
        }
    }
}