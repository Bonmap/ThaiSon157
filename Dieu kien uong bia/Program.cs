class program
{
    static void Main(string[] args)
    {
        int tuoi;
        Console.WriteLine("Ban bao nhieu tuoi");
        tuoi = int.Parse(Console.ReadLine());
        if (tuoi >= 18)
        {
            Console.WriteLine("Du tuoi uong bia");
        }
        else
        {
            Console.WriteLine("Khong du tuoi uong bia");
        }
    }
}