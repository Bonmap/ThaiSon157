
class program
{
    static void Main(string[] args)
    {
        int a;
        do
        {
            Console.WriteLine("Chuong trinh doc so thanh chu");
            Console.WriteLine("Vui long nhap so");
            a = int.Parse(Console.ReadLine());
            if (a < 0 || a >= 1000)
            {
                Console.WriteLine("Ngoai pham vi cua chuong trinh");
            }
            else if (a >= 0 && a <= 10)
            {
                switch (a)
                {
                    case 1:
                        Console.WriteLine("one");
                        break;
                    case 2:
                        Console.WriteLine("two");
                        break;
                    case 3:
                        Console.WriteLine("three");
                        break;
                    case 4:
                        Console.WriteLine("four");
                        break;
                    case 5:
                        Console.WriteLine("five");
                        break;
                    case 6:
                        Console.WriteLine("six");
                        break;
                    case 7:
                        Console.WriteLine("seven");
                        break;
                    case 8:
                        Console.WriteLine("eight");
                        break;
                    case 9:
                        Console.WriteLine("nine");
                        break;
                    case 10:
                        Console.WriteLine("ten");
                        break;
                    case 0:
                        Console.WriteLine("zero");
                        break;
                }
            }
            else if (a > 10 || a > 1000)
            {
                if (a == 11 || a == 12)
                {
                    if (a == 11)
                    {
                        Console.WriteLine("eleven");
                    }
                    else
                    {
                        Console.WriteLine("twelve");
                    }
                }
                else
                {
                    int first, second, third;
                    first = a / 100;
                    if (first > 0)
                        second = (a % (first * 100)) / 10;
                    else second = a / 10;
                    third = a - (first * 100 + second * 10);
                    Console.WriteLine(first + " " + second + " " + third);
                    if (first == 0 && second == 1)
                    {
                        switch (third)
                        {
                            case 1:
                                Console.Write(" eleven ");
                                break;
                            case 2:
                                Console.Write(" twelve ");
                                break;
                            case 3:
                                Console.Write(" thirteen ");
                                break;
                            case 4:
                                Console.Write(" fourteen ");
                                break;
                            case 5:
                                Console.Write(" fifteen ");
                                break;
                            case 6:
                                Console.Write(" sixteen ");
                                break;
                            case 7:
                                Console.Write(" seventeen ");
                                break;
                            case 8:
                                Console.Write(" eighteen ");
                                break;
                            case 9:
                                Console.Write(" nineteen ");
                                break;
                        }
                    }
                    if (first == 0 && second != 1)
                    {
                        switch (second)
                        {
                            case 2:
                                Console.Write(" twenty ");
                                break;
                            case 3:
                                Console.Write(" thirty ");
                                break;
                            case 4:
                                Console.Write(" forty ");
                                break;
                            case 5:
                                Console.Write(" fifty ");
                                break;
                            case 6:
                                Console.Write(" sixty ");
                                break;
                            case 7:
                                Console.Write(" seventy ");
                                break;
                            case 8:
                                Console.Write(" eighty ");
                                break;
                            case 9:
                                Console.Write(" ninety ");
                                break;
                        }
                        switch(third)
                        {
                            case 0:
                                Console.WriteLine(" ");
                                break;
                            case 1:
                                Console.WriteLine(" one ");
                                break;
                            case 2:
                                Console.WriteLine(" two ");
                                break;
                            case 3:
                                Console.WriteLine(" three ");
                                break;
                            case 4:
                                Console.WriteLine(" four ");
                                break;
                            case 5:
                                Console.WriteLine(" five ");
                                break;
                            case 6:
                                Console.WriteLine(" six ");
                                break;
                            case 7:
                                Console.WriteLine(" seven ");
                                break;
                            case 8:
                                Console.WriteLine(" eight ");
                                break;
                            case 9:
                                Console.WriteLine(" nine ");
                                break;
                        }
                    }
                    if (first > 0)
                    {
                        switch (first)
                        {
                            case 0:
                                Console.Write("");
                                break;
                            case 1:
                                Console.Write(" one hundred ");
                                break;
                            case 2:
                                Console.Write(" two hundred ");
                                break;
                            case 3:
                                Console.Write(" three hundred ");
                                break;
                            case 4:
                                Console.Write(" four hundred ");
                                break;
                            case 5:
                                Console.Write(" five hundred ");
                                break;
                            case 6:
                                Console.Write(" six hundred ");
                                break;
                            case 7:
                                Console.Write(" seven hundred ");
                                break;
                            case 8:
                                Console.Write(" eight hundred ");
                                break;
                            case 9:
                                Console.Write(" nine hundred ");
                                break;
                        }
                        Console.Write("and");
                        switch (second)
                        {
                            case 2:
                                Console.Write(" twenty ");
                                break;
                            case 3:
                                Console.Write(" thirty ");
                                break;
                            case 4:
                                Console.Write(" forty ");
                                break;
                            case 5:
                                Console.Write(" fifty ");
                                break;
                            case 6:
                                Console.Write(" sixty ");
                                break;
                            case 7:
                                Console.Write(" seventy ");
                                break;
                            case 8:
                                Console.Write(" eighty ");
                                break;
                            case 9:
                                Console.Write(" ninety ");
                                break;
                        }
                        switch (third)
                        {
                            case 0:
                                Console.WriteLine(" ");
                                break;
                            case 1:
                                Console.WriteLine(" one ");
                                break;
                            case 2:
                                Console.WriteLine(" two ");
                                break;
                            case 3:
                                Console.WriteLine(" three ");
                                break;
                            case 4:
                                Console.WriteLine(" four ");
                                break;
                            case 5:
                                Console.WriteLine(" five ");
                                break;
                            case 6:
                                Console.WriteLine(" six ");
                                break;
                            case 7:
                                Console.WriteLine(" seven ");
                                break;
                            case 8:
                                Console.WriteLine(" eight ");
                                break;
                            case 9:
                                Console.WriteLine(" nine ");
                                break;
                        }
                    }
                }
            }
        } while (a < 0 || a > 999);
    }
}
