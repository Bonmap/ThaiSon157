class program
{
    static void Main(string[] args)
    {
        double a;
        double b;
        double c;
        Console.WriteLine("Giai Phuong trinh bac hai:ax2+bx+c=0");
        Console.WriteLine("gia tri cua a=");
        a = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("gia tri cua b=");
        b = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("gia tri cua c=");
        c = Convert.ToDouble(Console.ReadLine());
        double delta = Math.Pow(b, 2) - 4 * a * c;
        if (a == 0)
        {
            if (b == c)
            { Console.WriteLine("Phuong trinh vo so nghiem"); }
            else if (b==0)
            { Console.WriteLine("Phuong trinh vo nghiem"); }
            else 
            {
            double x2 = - c / b;
            Console.WriteLine("Dap an cua phuong trinh x2=" + x2);
            }
        }
        else if (delta < 0)
        {
            Console.WriteLine("Phuong trinh vo nghiem");
        }
        else if (delta == 0)
        {
            Console.WriteLine("Phuong trinh vo so nghiem");
        }
        else
        {
            Console.WriteLine("Phuong trinh co 2 nghiem rieng biet");
            double x1 = (-b + (Math.Sqrt(delta))) / (2 * a);
            double x2 = (-b - (Math.Sqrt(delta))) / (2 * a);
            Console.Write("x1=" + x1);
            Console.Write(" ;x2=" + x2);
        }

    }
}