using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR23l
{/// <summary>
/// Создать класс Calculate с указанными двумя полями (Поле 1: вещественное число, Поле 2: вещественное число) и методами: 
/// конструкторы для инициализации объекта(без параметров, с одним параметром, с двумя параметрами);
/// функция формирования строки с информацией об объекте; функция обработки значений полей: вычислить корень квадратный из произведения чисел.
/// </summary>
    class Calculate
    {
        /// <summary>
        /// Два поля класса
        /// </summary>
        private double number1;
        private double number2;

        public double Number1
        {
            get => number1;
            set
            {
                if (value >= 0)
                {
                    number1 = value;
                }
                else
                {
                    number1 = 0;
                    Console.WriteLine("Ошибка, число не может быть отрицательным");
                }

            }
        }
        public double Number2
        {
            get => number2;
            set
            {
                if (value >= 0)
                {
                    number2 = value;
                }
                else
                {
                    number2 = 0;
                    Console.WriteLine("Ошибка, число не может быть отрицательным");
                }

            }
        }

        /// <summary>
        /// Конструкторы класса без параметров
        /// </summary>
        public Calculate()
        {
            Number1 = 3;
            Number2 = 9;
        }
        /// <summary>
        /// С одним параметром
        /// </summary>
        /// <param name="number1"></param>
        public Calculate(double number1)
        {
            this.Number1 = number1;
            Number2 = 0;
        }
        /// <summary>
        /// с двумя параметроми
        /// </summary>
        /// <param name="number1"></param>
        /// <param name="number2"></param>
        public Calculate(double number1, double number2)
        {
            this.Number1 = number1;
            this.Number2 = number2;
        }
        /// <summary>
        ///  Вычисление квадратного корня из произведения чисел
        /// </summary>
        public double Function()
        {
            return Math.Sqrt(Number1 * Number2);

        }
        public override string ToString()
        {
            return $"число: {Number1}, число: {Number2}, корень: {Function()}";
        }
    }
}
