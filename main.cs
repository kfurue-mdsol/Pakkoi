using System;

namespace Pakkoi
{
    class main
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Hello Pakkoi!{Environment.NewLine}Would you like to enjoy with Pakkoi?");

            var current = GetValue();
            Console.WriteLine($"{current.name} is {current.value}");
        }

        static (string name, int value) GetValue()
        {
            return ("Member", 1);
        }
    }
}
