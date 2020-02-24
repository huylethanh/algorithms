using System;

namespace Algorithms
{
    public abstract class Runable
    {
        protected abstract string ActionName { get; }
        
        public void Run()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(ActionName);
            Console.WriteLine("----------------------------------------------");
            var result = DoAction();

            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.Green;
            Display(result);
            Console.ResetColor();
        }

        protected abstract object DoAction();

        protected abstract void Display(object value);
    }
}