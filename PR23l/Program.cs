using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR23l
{/// <summary>
///  с использованием конструктора без параметров и присваивания значений полям объекта;
///  с явной инициализацией;
///  с использованием конструктора с двумя параметрами, введенными с клавиатуры.
/// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            /// <summary>
            /// без параметров и присваивания значений полям объекта
            /// </summary>
            Calculate calculate = new Calculate();

            calculate.Number1 = 5;
            calculate.Number2 = 6;
            Console.WriteLine(calculate.ToString());

            Console.WriteLine();

            /// <summary>
            /// С явной инициализацией
            /// </summary>
            Calculate calculate1 = new Calculate(4.9, 6.5);
            Console.WriteLine(calculate1);
            Console.WriteLine();

            /// <summary>
            /// C использованием конструктора с двумя параметрами, введенными с клавиатуры
            ///</summary>
            Console.Write("Введите число: ");
            double number1 = Check();
            Console.Write("Введите число: ");
            double number2 = Check();
            Calculate calculate2 = new Calculate(number1, number2);
            Console.WriteLine(calculate2);
            Console.ReadLine();

            /// <summary>
            /// Проверка на корректность ввода
            /// </summary>

            double Check()
            {
                double result;
                while (true)
                {
                    Console.Write("введиет число: ");
                    if (double.TryParse(Console.ReadLine(), out result))
                        return result;
                    else
                        Console.WriteLine("Некорректный ввод");
                }
            }

        }
    }
}
