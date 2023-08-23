
public class Program
{
    static void Main(string[] args)
    {
        double a;
        double b;
        double c;
        Console.WriteLine("Linear Equation Resolver");
        Console.WriteLine("Given a equation as 'a * x + b = 0', please enter constants:");
        Console.Write("so a la bao nhieu: ");
        a = Convert.ToDouble(Console.ReadLine());
        Console.Write("so b la bao nhieu: ");
        b = Convert.ToDouble(Console.ReadLine());
        Console.Write("so c la bao nhieu: ");
        c = Convert.ToDouble(Console.ReadLine());
        if (b == 0)
        {
            if (a == c)
            { Console.WriteLine("Phuong trinh vo so nghiem"); }
            else
            { Console.WriteLine("Phuong trinh vo nghiem"); }
        }
        else
        {
            double x = (a - c) / b;
            Console.WriteLine("Dap an cua phuong trinh " + x);
        }
    }

}