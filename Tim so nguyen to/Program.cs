class program
{
    static void Main(string[] args)
    {
        int a;
        Console.WriteLine("Tim so nguyen to");
        Console.WriteLine("Vui long nhap so");
        a = Convert.ToInt32(Console.ReadLine());
        bool so_nguyen_to = true;
        for (int i = 2; i < a; i++)
            if (a % i == 0)
            {
                so_nguyen_to = false;
            }
        switch (so_nguyen_to)
        {
            case true:
                Console.WriteLine("So a la so nguyen to");
                break;
            case false:
                Console.WriteLine("So a khong phai la so nguyen to");
                break;
        }
    }
}