using System;
namespace lesson;

public class lessoner
{
    public static string name, year, month, day ;
    public static int year1, month1, day1;
    static void Main()
    {
        Console.WriteLine("Пожалуйста введите своё имя");
        name = Console.ReadLine() ?? "Гость";
        Console.WriteLine("Здравствуйте "+name +"!");
        Console.WriteLine("Пожалуйста введите свой год рождения");
        year = Console.ReadLine();
        int year1 = Convert.ToInt32(year);
    if(DateTime.Now.Year>year1)
        {
        Console.WriteLine("Пожалуйста введите номер месяца в который вы родились");
        month = Console.ReadLine();
        int month1 = Convert.ToInt32(month);
        if(DateTime.Now.Month<month1)
        {
            Console.WriteLine("Вам "+(DateTime.Now.Year-year1-1)+"лет");
        }
        else if(DateTime.Now.Month==month1)
        {
        Console.WriteLine("Пожалуйста введите день в который вы родились");
        day = Console.ReadLine();
        int day1 = Convert.ToInt32(day);
        if(DateTime.Now.Day<day1)
         {
            Console.WriteLine("Вам "+(DateTime.Now.Year-year1-1)+"лет");
         }
         else
         {
            Console.WriteLine("Вам "+(DateTime.Now.Year-year1)+"лет");
         }
        }
        else
         {
            Console.WriteLine("Вам "+(DateTime.Now.Year-year1)+"лет");
         }
        }
        else if(DateTime.Now.Year<year1)
        {
            Console.WriteLine("Введена неверная дата");
        }
        else if(DateTime.Now.Year==year1)
        {
        if(DateTime.Now.Month<month1)
        {
            Console.WriteLine("Введена неверная дата");
        }
        else if(DateTime.Now.Month==month1)
        {
            if(DateTime.Now.Day<day1)
            {
                Console.WriteLine("Введена неверная дата");
            }
            else
            {
                Console.WriteLine("Вам 0 лет");
            }
        }
        else
        {
            Console.WriteLine("Вам 0 лет");
        }
        }
    }
}
static void returnessd()
{
 Console.WriteLine("Пожалуйста введите свой год рождения");
        year = Console.ReadLine();
        int year1 = Convert.ToInt32(year);
    if(DateTime.Now.Year>year1)
        {
        Console.WriteLine("Пожалуйста введите номер месяца в который вы родились");
        month = Console.ReadLine();
        int month1 = Convert.ToInt32(month);
        if(DateTime.Now.Month<month1)
        {
            Console.WriteLine("Вам "+(DateTime.Now.Year-year1-1)+"лет");
        }
        else if(DateTime.Now.Month==month1)
        {
        Console.WriteLine("Пожалуйста введите день в который вы родились");
        day = Console.ReadLine();
        int day1 = Convert.ToInt32(day);
        if(DateTime.Now.Day<day1)
         {
            Console.WriteLine("Вам "+(DateTime.Now.Year-year1-1)+"лет");
         }
         else
         {
            Console.WriteLine("Вам "+(DateTime.Now.Year-year1)+"лет");
         }
        }
        else
         {
            Console.WriteLine("Вам "+(DateTime.Now.Year-year1)+"лет");
         }
        }
        else if(DateTime.Now.Year<year1)
        {
            Console.WriteLine("Введена неверная дата");
            ret();
        }
        else if(DateTime.Now.Year==year1)
        {
        if(DateTime.Now.Month<month1)
        {
            Console.WriteLine("Введена неверная дата");
            ret();
        }
        else if(DateTime.Now.Month==month1)
        {
            if(DateTime.Now.Day<day1)
            {
                Console.WriteLine("Введена неверная дата");
                ret();
            }
            else
            {
                Console.WriteLine("Вам 0 лет");
            }
        }
        else
        {
            Console.WriteLine("Вам 0 лет");
        }
        }
}
static void reter()
{
returned();
}