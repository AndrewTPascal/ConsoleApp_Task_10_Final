using System;
using System.Collections.Generic;
using System.Text;

namespace task1
{
    interface ICalculator
    {
        public double Calculate();
    }

    class Sum : ICalculator
    {
        public double number1;
        public double number2;
        ILogger logger { get; }

        public Sum(ILogger logger) 
        {
            this.logger = logger;
        }

        // Вычисление суммы двух чисел
        public double Calculate()
        {
            number1 = CheckValue(1);
            logger.Event("Значение №1 присвоено");
            
            number2 = CheckValue(2);
            logger.Event("Значение №2 присвоено");

            return number1 + number2;
        }

        // Проверка корректности введенных значений
        double CheckValue(int index)
        {
            double number;

            while (true)
            {
                Console.Write("Введите число №{0}: ", index);

                try
                {
                    number = Convert.ToDouble(Console.ReadLine());
                    return number;
                }
                catch
                {
                    logger.Error("Введены некорекные данные!");
                }
            }
        }
    }
}
