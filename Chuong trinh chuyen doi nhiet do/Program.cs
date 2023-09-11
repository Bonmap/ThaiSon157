using System.Reflection.Metadata;
using System.Xml.Serialization;

class program
{
    public static float ChuyendoidoCsangdoF(float a)
    {
        float doF;
        float doC = a;
        doF = Convert.ToInt32((doC * 9 / 5) + 32);
        return doF;
    }
    public static float ChuyendoidoFsangdoC(float b)
    {
        float doF = b;
        float doC;
        doC = Convert.ToInt32((doF - 32) * 5 / 9);
        return doC;
    }
    public static void Main(string[] args)
    {
        Console.WriteLine("Chuong trinh chuyen doi nhiet do");
        Console.WriteLine("1. Chuyen doi tu Do C sang Do F");
        Console.WriteLine("2. Chuyen doi tu Do F sang Do C");
        Console.WriteLine("0. Exit");
        int choice;
        do
        {
            choice = int.Parse(Console.ReadLine());
            if (choice > 2)
            {
                Console.WriteLine("Ban da nhap ngoai gia tri chuong trinh, Vui long nhap lai");
            }
            else
            {
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Vui long nhap so Do C");
                        int doC = int.Parse(Console.ReadLine());
                        Console.WriteLine(doC + " Do C tuong duong " + ChuyendoidoCsangdoF(doC) + " Do F");
                        break;
                    case 2:
                        Console.WriteLine("Vui long nhap so Do F");
                        int doF = int.Parse(Console.ReadLine());
                        Console.WriteLine(doF + " Do F tuong duong " + ChuyendoidoFsangdoC(doF) + " Do C");
                        break;
                    case 0:
                        Environment.Exit(0);
                        break;
                }
            }
        } while (choice > 2);
    }
}