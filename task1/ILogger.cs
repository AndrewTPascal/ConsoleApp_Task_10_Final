using System;
using System.Collections.Generic;
using System.Text;

namespace task1
{
    interface ILogger 
    {
        void Event(string message);
        void Error(string message);
    }
    class Logger : ILogger
    {
        // Выводим сообщение об ошибке
        public void Error(string message)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(message);
            Console.ResetColor();
        }

        // Выводим сообщение о событии
        public void Event(string message)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(message);
            Console.ResetColor();
        }
    }
}
