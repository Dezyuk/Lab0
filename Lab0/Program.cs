using System;

namespace Lab0
{
    internal class Program
    {
        /// <summary>
        /// Возведение в квадрат произведения двух вещественных чисел
        /// </summary>
        /// <param name="number1">Первое вещественное число</param>
        /// <param name="number2">Второе вещественное число</param>
        /// <returns>Квадрат произведения двух вещественных чисел</returns>
        static double SquareProduct(double number1, double number2)
        {
            return Math.Pow(number1 * number2, 2);
        }

        static void Main()
        {
            Random random = new Random();
            double number1 = (random.NextDouble()) * 20 - 10, number2 = (random.NextDouble()) * 20 - 10; // Первое и второе вещественное число значениями от -10 до 10
            Console.WriteLine($"Сгенерированы числа: {number1}, {number2}");
            Console.WriteLine($"Квадрат произведения чисел {number1} и {number2} равен {SquareProduct(number1, number2)}");
        }
    }
}
