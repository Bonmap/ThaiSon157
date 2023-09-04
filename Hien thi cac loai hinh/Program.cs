
class Hien_thi_cac_loai_hinh
{
    static void Main(string[] args)
    {
        int choice = 1;
        while (choice != 4)
        {
            Console.WriteLine("Menu");
            Console.WriteLine("1. Print the rectangle");
            Console.WriteLine("2. Print the square triangle The corner is square at 4 different angles: top - left, top - right, botton - left, botton - right)");
            Console.WriteLine("3. Print isosceles triangle");
            Console.WriteLine("4. Exit");
            choice = int.Parse(Console.ReadLine());
            if (choice == 1)
            {
                int chieu_dai;
                int chieu_rong;
                Console.WriteLine("Print the rectangle");
                Console.Write("Enter length: ");
                chieu_dai = int.Parse(Console.ReadLine());
                Console.Write("Enter width: ");
                chieu_rong = int.Parse(Console.ReadLine());
                for (int i = 0; i < chieu_rong; i++)
                {
                    for (int j = 0; j < chieu_dai; j++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine("");
                }
            }
            else if (choice == 2)
            {
                int chieu_dai_canh = 1;
                Console.WriteLine("Print the square triangle (The corner is square at top-left");
                Console.Write("Enter row: ");
                chieu_dai_canh = Convert.ToInt32(Console.ReadLine());
                int CDC_tam_thoi = chieu_dai_canh;
                for (int a = 0; a < chieu_dai_canh; a++)
                {
                    for (int b = 0; b < CDC_tam_thoi; b++)
                    {
                        Console.Write("*");
                    }
                    CDC_tam_thoi--;
                    Console.WriteLine("");
                }
            }
            else if (choice == 3)
            {
                int i, j, n;
                Console.WriteLine("Print isosceles triangle");
                Console.Write("Enter row: ");
                n = Convert.ToInt32(Console.ReadLine());
                for (i = 1; i <= n; i++)
                {
                    for (j = 1; j <= n - i; j++)
                    { Console.Write(" "); }
                    for (j = 1; j <= 2 * i - 1; j++)
                    { Console.Write("*"); }
                    Console.WriteLine("");
                }
            }
            else if(choice==4) 
            { Environment.Exit(0);}
        }
    }
}