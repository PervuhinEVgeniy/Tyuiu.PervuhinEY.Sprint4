using Tyuiu.PervuhinEY.Sprint4.Task0.V30.Lib;
namespace Tyuiu.PervuhinEY.Sprint4.Task0.V30;
    class Program
{
    static void Main(string[] args)
    {


        DataService ds = new DataService();
        Console.Title = "Спринт #4 | Выполнил: Первухин Е. Ю.| АСОиУБ-26-1";
        Console.WriteLine("********************************************************************");
        Console.WriteLine("* Спринт #4                                                        *");
        Console.WriteLine("********************************************************************");
        Console.WriteLine("* Тема: Базовые навыки работы с C#                                 *");
        Console.WriteLine("* Задание #4                                                       *");
        Console.WriteLine("* Вариант #5                                                       *");
        Console.WriteLine("* Выполнил: Первухин Е. Ю.| АСОиУБ-26-1                            *");
        Console.WriteLine("********************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                         *");
        Console.WriteLine("* Дан одномерный целочисленный массив на 10 элементов заполненный  *");
        Console.WriteLine("* статическими значениями в диапазоне от 0 до 9 подсчитать сумму   *");
        Console.WriteLine("* четных элементов массива. {9, 8, 4, 6, 9, 4, 3, 6, 1, 2}         *");
        Console.WriteLine("********************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                 *");
        Console.WriteLine("********************************************************************");
        Console.WriteLine("* Массив: {9, 8, 4, 6, 9, 4, 3, 6, 1, 2}                           *");
        Console.WriteLine("********************************************************************");
        Console.WriteLine("* Результат                                                        *");
        int[] numsArrey = { 9, 8, 4, 6, 9, 4, 3, 6, 1, 2 };
        DataService ds1 = new DataService();
        int res = ds1.GetSumEvenArrEl(numsArrey);
        Console.WriteLine("********************************************************************");
        Console.WriteLine("Сумма четных эдементов = " + res);
        Console.ReadKey();

    }
}

