using System;
namespace HomeWork;

class Program
{
    public static float number1, number2, summ;
    public static string str1, str2;
    public static void Main(string[] args)
    {
        GuessGame guessGame = new();
        guessGame.Run();
        Console.WriteLine("Введите 2 числа");
        str1 = Console.ReadLine();
        str2 = Console.ReadLine();
        number1 = float.Parse(str1);
        number2 = float.Parse(str2);
        summ = number1 + number2;
        Console.WriteLine(summ);
    }
}
