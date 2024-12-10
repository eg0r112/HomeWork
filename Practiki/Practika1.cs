using System;
namespace HomeWork;

public class Practika1
{
    //A
    public int[] numbers = new int[] { 1, 2, 3, 4, 5 };
    //B
    public void Pr()
    {
        Console.WriteLine(numbers[1]);
        numbers[1] = 100;
        Console.WriteLine(numbers[1]);
        Console.WriteLine(numbers.Length);
    }
}