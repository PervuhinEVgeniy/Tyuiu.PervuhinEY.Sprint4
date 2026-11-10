
using System.Security.Cryptography;
using Tyuiu.PervuhinEY.Sprint4.Task7.V30.Lib;
using static System.Runtime.InteropServices.JavaScript.JSType;
namespace Tyuiu.PervuhinEY.Sprint4.Task7.V30;

class Program
{
    static void Main(string[] args)
    {
        Console.Title = "Спринт #4 | Выполнил: Первухин Е. Ю.| АСОиУБ-26-1";
        Console.WriteLine("********************************************************************");
        Console.WriteLine("* Спринт #4                                                        *");
        Console.WriteLine("********************************************************************");
        Console.WriteLine("* Тема: Базовые навыки работы с C#                                 *");
        Console.WriteLine("* Задание #7                                                       *");
        Console.WriteLine("* Вариант #30                                                      *");
        Console.WriteLine("* Выполнил: Первухин Е. Ю.| АСОиУБ-26-1                            *");
        Console.WriteLine("********************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                         *");
        Console.WriteLine("* Дана строка из одноразрядных цифр 684259137159648.Преобразуйте ее*");
        Console.WriteLine("* в матрицу 5 на 3 и подсчитайте произведение четных чисел.        *");
        Console.WriteLine("********************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                 *");
        Console.WriteLine("********************************************************************");

        DataService ds = new DataService();
        int n = 5;
        int m = 3;
        string str = "684259137159648";
        int res = ds.Calculate(n, m, str);
        Console.WriteLine("Ответ: " + res);
        Console.ReadKey();
    }

}
