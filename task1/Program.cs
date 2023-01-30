using System;

namespace task1
{
   
    class Program
    {
        static ILogger Logger;
        static void Main(string[] args)
        {
            Logger = new Logger();
            Sum sum = new Sum(Logger);
 
            Console.WriteLine("Сумма чисел равна: " + sum.Calculate());
            
        }
    }
}
