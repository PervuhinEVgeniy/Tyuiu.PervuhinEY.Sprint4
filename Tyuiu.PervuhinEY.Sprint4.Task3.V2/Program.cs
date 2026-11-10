
using Tyuiu.PervuhinEY.Sprint4.Task3.V2.Lib;
using static System.Runtime.InteropServices.JavaScript.JSType;
namespace Tyuiu.PervuhinEY.Sprint4.Task3.V2;

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
        Console.WriteLine("* статическими значениями в диапазоне от 2 до 8. Найдите           *");
        Console.WriteLine("* максимальный элемент в первой строке массива.                    *");
        Console.WriteLine("* 4, 3, 2, 8, 7,                                                   *");
        Console.WriteLine("* 4, 6, 5, 5, 7,                                                   *");
        Console.WriteLine("* 3, 8, 8, 3, 5,                                                   *");
        Console.WriteLine("* 5, 7, 5, 4, 4,                                                   *");
        Console.WriteLine("* 8, 8, 3, 7, 6,                                                   *");
        Console.WriteLine("********************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                 *");
        Console.WriteLine("********************************************************************");
        Console.WriteLine("********************************************************************");

        DataService ds1 = new DataService();
        int[,] mas = new int[5, 5] { { 4, 3, 2, 8, 7 }, { 4, 6, 5, 5, 7 }, { 3, 8, 8, 3, 5 }, { 5, 7, 5, 4, 4 }, { 8, 8, 3, 7, 6 } };
        int res = ds1.Calculate(mas);
        Console.WriteLine("********************************************************************");
        Console.WriteLine("Максимальный элемент в первой строке массива = " + res);
        Console.ReadKey();

    }
}