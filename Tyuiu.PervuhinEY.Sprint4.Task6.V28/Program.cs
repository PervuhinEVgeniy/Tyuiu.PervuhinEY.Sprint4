
using System.Security.Cryptography;
using Tyuiu.PervuhinEY.Sprint4.Task6.V28.Lib;
using static System.Runtime.InteropServices.JavaScript.JSType;
namespace Tyuiu.PervuhinEY.Sprint4.Task6.V28;

class Program
{
    static void Main(string[] args)
    {
        Console.Title = "Спринт #4 | Выполнил: Первухин Е. Ю.| АСОиУБ-26-1";
        Console.WriteLine("********************************************************************");
        Console.WriteLine("* Спринт #4                                                        *");
        Console.WriteLine("********************************************************************");
        Console.WriteLine("* Тема: Базовые навыки работы с C#                                 *");
        Console.WriteLine("* Задание #6                                                       *");
        Console.WriteLine("* Вариант #28                                                      *");
        Console.WriteLine("* Выполнил: Первухин Е. Ю.| АСОиУБ-26-1                            *");
        Console.WriteLine("********************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                         *");
        Console.WriteLine("* Дан строковый массив данных:[\"Река\", \"Озеро\", \"Болото\",    *");
        Console.WriteLine("* \"Океан\",\"Лужа\", \"Море\"], используя класс Array, выведите   *");
        Console.WriteLine("* элементы массива, длина которых равна 4 символам.                *");
        Console.WriteLine("********************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                 *");
        Console.WriteLine("********************************************************************");
        Console.WriteLine("********************************************************************");

        DataService ds = new DataService();
        string[] mas = new string[] { "Река", "Озеро", "Болото", "Океан", "Лужа", "Море" };
        string[] res = ds.Calculate(mas);

        Console.WriteLine("********************************************************************");
        Console.WriteLine("Ответ: ");
        for (int i = 0; i < res.Length; i++)
        {
            Console.WriteLine(res[i]);
        }
        Console.ReadKey();
        }

    }
