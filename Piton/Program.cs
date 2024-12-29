namespace Piton;

class Program
{
    static void Main(string[] args)
    {
        static int Add(int a, int b)
    {
        return a + b;
    }


    static bool IsEven(int n)
    {
        return n % 2 == 0;
    }


    static string ReverseString(string s)
    {
        char[] charArray = s.ToCharArray();
        Array.Reverse(charArray);
        return new string(charArray);
    }

    static int FindMax(int[] arr)
    {
        return arr.Max();
    }


    static double C(double s)
    {
        return s * 12;
    }


    static double cekcToazizp(double cekc)
    {
        return cekc * 9 / 5 + 32;
    }


    static int CountVowels(string s)
    {
        string vowels = "аиоуеэАИОУЕЭ";
        int count = 0;
        foreach (char c in s)
        {
            if (vowels.Contains(c))
            {
                count++;
            }
        }
        return count;
    }


    static int GeneratePassword(string passwordToHack)
    {
        int count = 0;
        for (int x = 0; x < 10; x++)
        {
            for (int y = 0; y < 10; y++)
            {
                for (int z = 0; z < 10; z++)
                {
                    for (int h = 0; h < 10; h++)
                    {
                        count++;
                        string kol = $"{x}{y}{z}{h}";
                        if (kol == passwordToHack)
                        {
                            Console.WriteLine("Ура! Вы взломали пароль, теперь вы хакер");
                            return count;
                        }
                    }
                }
            }
        }
        return count;
    }


        int sum = Add(5, 3);
        Console.WriteLine("Сумма: " + sum);


        bool isEven = IsEven(4);
        Console.WriteLine("Функция проверки четности: " + isEven);

        string reversedString = ReverseString("hello");
        Console.WriteLine("Функция переворота строки: " + reversedString);


        int max = FindMax(new int[] { 1, 2, 3, 4, 5 });
        Console.WriteLine("Функция поиска максимального элемента в массиве: " + max);


        double aziz = C(1000);
        Console.WriteLine("Функция вычисления зарплаты за год: " + aziz);



        double azizp = cekcToazizp(25);
        Console.WriteLine("Функция конвертации температур: " + azizp);


        int lol = CountVowels("Привет мир");
        Console.WriteLine("Функция поиска количества гласных в строке: " + lol);


        int pol = GeneratePassword("1234");
        Console.WriteLine("Функция для опредления сложности взлома 4х значного пароля пароля: " + pol);

    }
}
