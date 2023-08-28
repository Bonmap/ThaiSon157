class program
{
    public static void Main(string[] args)
    {
        int chieu_dai;
        int chieu_rong;
        Console.WriteLine("Ve hinh chu nhat");
        Console.WriteLine("chieu dai hinh chu nhat");
        chieu_dai = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("chieu rong hinh chu nhat");
        chieu_rong = Convert.ToInt32(Console.ReadLine());
        for (int j = 0; j < chieu_rong; j++)
        {    for (int i = 0; i < chieu_dai; i++)
            {
                Console.Write("o");
            }
            Console.WriteLine("");
        }    
    }
}