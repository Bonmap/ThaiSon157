class program
{
    static void Main(string[] args)
    {
        int so_hang_mang_hai_chieu;
        int so_cot_mang_hai_chieu;
        int[,] mang_hai_chieu;
        Console.WriteLine("Tinh duong cheo trong mang hai chieu vuong(so hang phai bang so cot)");
        do
        {
            do
            {
                Console.WriteLine("Nhap so hang cua mang: ");
                so_hang_mang_hai_chieu = int.Parse(Console.ReadLine());
                if (so_hang_mang_hai_chieu >= 6)
                {
                    Console.WriteLine("So hang cua mang khong vuot qua 5");
                }
            } while (so_hang_mang_hai_chieu >= 6);
            do
            {
                Console.WriteLine("Nhap so cot cua mang: ");
                so_cot_mang_hai_chieu = int.Parse(Console.ReadLine());
                if (so_cot_mang_hai_chieu >= 6)
                {
                    Console.WriteLine("So cot cua mang khong vuot qua 5");
                }
            } while (so_cot_mang_hai_chieu >= 6);
            if (so_hang_mang_hai_chieu != so_cot_mang_hai_chieu)
            {
                Console.WriteLine("so hang va so cot dang khac nhau, vui long nhap lai");
            }
        } while (so_hang_mang_hai_chieu != so_cot_mang_hai_chieu);
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
        int Tong_duong_cheo = 0;
        for (i = 0; i < mang_hai_chieu.GetLength(0); i++)
        {
            for (i = 0; i < mang_hai_chieu.GetLength(1); i++)
            {
                {
                    Tong_duong_cheo += mang_hai_chieu[i, i];
                }
            }
        }
        Console.WriteLine("Tong gia tri duong cheo: " + Tong_duong_cheo);
    }
}
