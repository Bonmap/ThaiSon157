class Program
{
    static void Main(string[] args)
    {
        int tuoi;
        Console.WriteLine("Ban bao nhieu tuoi");
        tuoi = int.Parse(Console.ReadLine());
        if (tuoi >= 6 && tuoi <= 10)
        {
            Console.WriteLine("Dang hoc tieu hoc");
        }
        else if (tuoi >= 11 && tuoi <= 14)
        {
            Console.WriteLine("Dang hoc THCS");
        }
        else if (tuoi >= 15 && tuoi <= 18)
        {
            Console.WriteLine("Dang hoc THPT");
        }
        else
        {
            Console.WriteLine("Da ra truong");
        }
        Console.WriteLine("ket thuc chuong trinh");
    }
}