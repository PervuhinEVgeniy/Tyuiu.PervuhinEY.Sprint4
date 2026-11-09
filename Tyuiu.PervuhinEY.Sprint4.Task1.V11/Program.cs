
using Tyuiu.PervuhinEY.Sprint4.Task1.V11.Lib;
using static System.Runtime.InteropServices.JavaScript.JSType;
namespace Tyuiu.PervuhinEY.Sprint4.Task1.V11;

class Program
{
    static void Main(string[] args)
    {

        int[] arr = new int[17];
        DataService ds = new DataService();
        Console.Title = "Спринт #4 | Выполнил: Первухин Е. Ю.| АСОиУБ-26-1";
        Console.WriteLine("********************************************************************");
        Console.WriteLine("* Спринт #4                                                        *");
        Console.WriteLine("********************************************************************");
        Console.WriteLine("* Тема: Базовые навыки работы с C#                                 *");
        Console.WriteLine("* Задание #1                                                       *");
        Console.WriteLine("* Вариант #11                                                      *");
        Console.WriteLine("* Выполнил: Первухин Е. Ю.| АСОиУБ-26-1                            *");
        Console.WriteLine("********************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                         *");
        Console.WriteLine("* Дан одномерный целочисленный массив на 17 элементов заполненный  *");
        Console.WriteLine("* с клавиатуры в диапазоне от 1 до 6 подсчитать сумму              *");
        Console.WriteLine("* четных элементов массива.                                        *");
        Console.WriteLine("********************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                 *");
        Console.WriteLine("********************************************************************");
        Console.WriteLine("********************************************************************");
        Console.WriteLine("* Результат                                                        *");
        Console.WriteLine("Введите 17 чисел (от 1 до 6):");

        for (int i = 0; i < 17; i++)
        {
            bool isCorrect = false;

            while (isCorrect == false)
            {
                Console.Write($"Элемент {i + 1}: ");
                int number = int.Parse(Console.ReadLine());

                if (number >= 1 && number <= 6)
                {
                    arr[i] = number;
                    isCorrect = true;
                }
                else
                {
                    Console.WriteLine("Ошибка! Нужно число от 1 до 6.");
                }
            }
        }
        DataService ds1 = new DataService();
        int res = ds1.Calculate(arr);
        Console.WriteLine("********************************************************************");
        Console.WriteLine("Сумма четных эдементов = " + res);
        Console.ReadKey();

    }
}
