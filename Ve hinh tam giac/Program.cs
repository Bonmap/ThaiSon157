class program
{
    static void Main(string[] args)
    {
        int chieu_dai_canh = 1;
        Console.WriteLine("Ve hinh tam giac can");
        Console.Write("Nhap chieu dai canh tam giac: ");
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
}