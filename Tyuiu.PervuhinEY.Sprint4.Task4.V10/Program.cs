
using System.Security.Cryptography;
using Tyuiu.PervuhinEY.Sprint4.Task4.V10.Lib;
using static System.Runtime.InteropServices.JavaScript.JSType;
namespace Tyuiu.PervuhinEY.Sprint4.Task4.V10;

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
        Console.WriteLine("* Задание #3                                                       *");
        Console.WriteLine("* Вариант #2                                                       *");
        Console.WriteLine("* Выполнил: Первухин Е. Ю.| АСОиУБ-26-1                            *");
        Console.WriteLine("********************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                         *");
        Console.WriteLine("* Дан двумерный целочисленный массив 5 на 5 элементов, заполненный *");
        Console.WriteLine("* статическими значениями в диапазоне от 1 до 7.                   *");
        Console.WriteLine("* Заменить нечетные элементы массива на 0                          *");
        Console.WriteLine("********************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                 *");
        Console.WriteLine("********************************************************************");
        Console.WriteLine("********************************************************************");

        int[,] matrix = new int[5, 5];

        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                bool isCorrect = false; 

                while (!isCorrect)
                {
                    Console.Write($"Введите [{i},{j}] элемент массива: ");
                    string input = Console.ReadLine();


                    if (int.TryParse(input, out int number) && number >= 1 && number <= 7)
                    {
                        matrix[i, j] = number;
                        isCorrect = true;
                    }
                    else
                    {
                        Console.WriteLine("Ошибка! Нужно целое число от 1 до 7.");
                    }
                }
            }
        }
        Console.WriteLine("Массив:");
        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                Console.Write($"{matrix[i, j]} \t");
            }
            Console.WriteLine();
        }

        DataService ds1 = new DataService();
        int[,] res = ds1.Calculate(matrix);

        Console.WriteLine("Ответ:");
        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                Console.Write($"{res[i, j]} \t");
            }
            Console.WriteLine();
        }

        Console.ReadKey();

    }
}