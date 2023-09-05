class program
{
    static void Main(string[] args)
    {
        int so_hang_mang_hai_chieu;
        int so_cot_mang_hai_chieu;
        int[,] mang_hai_chieu;
        Console.WriteLine("Tim gia tri lon nhat trong mang hai chieu");
        do
        {
            Console.WriteLine("Nhap so hang cua mang: ");
            so_hang_mang_hai_chieu = int.Parse(Console.ReadLine());
            if (so_hang_mang_hai_chieu >= 6)
            {
                Console.WriteLine("So hang cua mang khong vuot qua 5");
            }
        }
        while (so_hang_mang_hai_chieu >= 6);
        do
        {
            Console.WriteLine("Nhap so cot cua mang: ");
            so_cot_mang_hai_chieu = int.Parse(Console.ReadLine());
            if (so_cot_mang_hai_chieu >= 6)
            {
                Console.WriteLine("So cot cua mang khong vuot qua 5");
            }
        }
        while (so_cot_mang_hai_chieu >= 6);
        int i;
        int j;
        mang_hai_chieu = new int[so_hang_mang_hai_chieu, so_cot_mang_hai_chieu];
        Console.WriteLine("So hang cua mang " + mang_hai_chieu.GetLength(0));
        Console.WriteLine("So cot cua mang " + mang_hai_chieu.GetLength(1));
        Console.WriteLine("Nhap cac phan tu cua mang hai chieu");
        for (i = 0; i < mang_hai_chieu.GetLength(0); i++)
        {
            for (j = 0; j < mang_hai_chieu.GetLength(1); j++)
            {
                mang_hai_chieu[i, j] = int.Parse(Console.ReadLine());
            }
        }
        Console.WriteLine("In ra cac phan tu cua mang");
        for (i = 0; i < mang_hai_chieu.GetLength(0); i++)
        {
            for (j = 0; j < mang_hai_chieu.GetLength(1); j++)
            {
                Console.Write(" " + mang_hai_chieu[i, j]);
            }
            Console.WriteLine("");
        }
        int so_lon_nhat = int.MinValue;
        for (i = 0; i < mang_hai_chieu.GetLength(0); i++)
        {
            for (j = 0; j < mang_hai_chieu.GetLength(1); j++)
            {
                if (mang_hai_chieu[i, j] > so_lon_nhat)
                {
                    so_lon_nhat = mang_hai_chieu[i, j];
                }
            }
        }
        Console.WriteLine("");
        Console.WriteLine("So lon nhat cua mang la: " + so_lon_nhat);
    }
}
