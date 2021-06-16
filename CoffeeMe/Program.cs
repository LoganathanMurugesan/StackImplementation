using System;

namespace CoffeeMe
{
    class Program
    {
        static void Main(string[] args)
        {
            double sum = 0.0;
            var simpleStack = new SimpleStack();
            simpleStack.Push(8.7);
            simpleStack.Push(3.4);
            simpleStack.Push(6.2);

            while(simpleStack.Count > 0)
            {
                var item = simpleStack.Pop();
                Console.WriteLine($"Item: {item}");
                sum += item;
            }

            Console.WriteLine($"Sum: {sum}");
            Console.ReadLine();
        }
    }
}
