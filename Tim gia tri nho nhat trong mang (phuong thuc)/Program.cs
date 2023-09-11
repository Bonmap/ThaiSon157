class program
{
    public static int Giatrinhonhattrongmang(int[] mang)
    {
        int so_nho_nhat = int.MaxValue;
        for (int i = 0; i < mang.Length; i++)
        {
            if (mang[i] < so_nho_nhat)
            {
                so_nho_nhat=mang[i];
            }
        }
        return so_nho_nhat;
    }
    public static void Main(string[] agrs)
    {
        Console.WriteLine("Tim gia tri nho nhat trong mang (do dai mang nho hon 11)");
        int do_dai_cua_mang;
        do
        {
            Console.WriteLine("Nhap do dai cua mang");
            do_dai_cua_mang = int.Parse(Console.ReadLine());
            if (do_dai_cua_mang > 10)
            {
                Console.WriteLine("Do dai cua mang vuot qua cho phep, Vui long nhap lai");
            }
        } while (do_dai_cua_mang > 10);
        int [] mang1= new int [do_dai_cua_mang];
        Console.WriteLine("Nhap cac phan tu cua mang");
        for(int i=0; i<do_dai_cua_mang;i++)
        {
            mang1[i]= int.Parse(Console.ReadLine());
        }
        Console.WriteLine("Liet ke cac phan tu cua mang");
          for(int i=0; i<do_dai_cua_mang;i++)
        {
            Console.Write(" "+ mang1[i]);
        }
        Console.WriteLine ("");
        Console.WriteLine ("Gia tri nho nhat cua mang la "+ Giatrinhonhattrongmang(mang1));
    }
}