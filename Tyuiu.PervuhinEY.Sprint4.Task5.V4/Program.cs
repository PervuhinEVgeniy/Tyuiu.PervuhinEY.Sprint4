
using System.Security.Cryptography;
using Tyuiu.PervuhinEY.Sprint4.Task5.V4.Lib;
using static System.Runtime.InteropServices.JavaScript.JSType;
namespace Tyuiu.PervuhinEY.Sprint4.Task5.V4;

class Program
{
    static void Main(string[] args)
    {
        Random rnd = new Random();
        DataService ds = new DataService();
        Console.Title = "Спринт #4 | Выполнил: Первухин Е. Ю.| АСОиУБ-26-1";
        Console.WriteLine("********************************************************************");
        Console.WriteLine("* Спринт #4                                                        *");
        Console.WriteLine("********************************************************************");
        Console.WriteLine("* Тема: Базовые навыки работы с C#                                 *");
        Console.WriteLine("* Задание #5                                                       *");
        Console.WriteLine("* Вариант #4                                                       *");
        Console.WriteLine("* Выполнил: Первухин Е. Ю.| АСОиУБ-26-1                            *");
        Console.WriteLine("********************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                         *");
        Console.WriteLine("* Дан двумерный целочисленный массив 5 на 5 элементов, заполненный *");
        Console.WriteLine("* случайными значениями в диапазоне от -4 до 6,                    *");
        Console.WriteLine("* Найти количество положительных элементов                        *");
        Console.WriteLine("********************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                 *");
        Console.WriteLine("********************************************************************");
        Console.WriteLine("********************************************************************");
        int[,] mat = new int[5, 5];
        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                mat[i, j] = rnd.Next(-4, 6);
            }
        }
        Console.WriteLine("Массив:");
        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                Console.Write($"{mat[i, j]} \t");
            }
            Console.WriteLine();

        }
        int res = ds.Calculate(mat);
        Console.WriteLine("********************************************************************");
        Console.WriteLine("Ответ = " + res);
        Console.ReadKey();

        
    }
}