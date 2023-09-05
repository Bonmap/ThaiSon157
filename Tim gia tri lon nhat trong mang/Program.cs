using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;

class program
{
    static void Main(string[] args)
    {
        int kich_co;
        int[] mang;
        do
        {
            Console.WriteLine("Tim gia tri lon nhat trong bang");
            Console.WriteLine("Nhap kich co cua mang: ");
            kich_co = int.Parse(Console.ReadLine());
            if (kich_co >= 6)
            {
                Console.WriteLine("Kich co cua mang khong vuot qua 5");
            }
        }
        while (kich_co >= 6);
        int i;
        mang = new int[kich_co];
        Console.WriteLine("Chieu dai cua mang " + mang.Length);
        Console.WriteLine("Nhap cac phan tu cua mang");
        for (i = 0; i < mang.Length; i++)
        {
            mang[i] = int.Parse(Console.ReadLine());
        }
        Console.Write("In ra cac phan tu cua mang");
        for (i = 0; i < mang.Length; i++)
        {
            Console.Write(" " + mang[i]);
        }
        int so_lon_nhat= int.MinValue;
        for(i=0;i<mang.Length;i++)
        {
            if (mang[i]>so_lon_nhat)
            {
                so_lon_nhat=mang[i];
            }  
        }
        Console.WriteLine ("");
        Console.WriteLine ("So lon nhat cua mang la: "+so_lon_nhat);
    }
}