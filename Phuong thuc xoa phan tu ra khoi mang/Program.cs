using System.ComponentModel.DataAnnotations;

class program
{
    public static void Xoaphanturakhoimang(int[] mang, int socanxoa)
    {
        int vitricanxoa = 0;
        int i;
        Console.WriteLine("phan tu mang truoc khi xoa");
        for (i = 0; i < mang.Length; i++)
        {
            Console.Write(" " + mang[i]);
        }
        Console.WriteLine("");
        for (i = 0; i < mang.Length; i++)
        {
            if (mang[i] == socanxoa)
            {
                vitricanxoa = i;
            }
        }
        if (vitricanxoa == 0)
        {
            Console.WriteLine("Khong tim thay so can xoa");
            return;
        }
        for (i = vitricanxoa; i < mang.Length - 1; i++)
        {
            mang[i] = mang[i + 1];
        }
        mang[mang.Length - 1] = 0;
        Console.WriteLine("phan tu mang sau khi da xoa so");
        for (i = 0; i < mang.Length; i++)
        {
            Console.Write(" " + mang[i]);
        }
    }
    public static void Main(string[] agrs)
    {
        int[] mang_so = { 1, 2, 3, 4, 5, 6, 7, 8 };
        int a = 2;
        Xoaphanturakhoimang(mang_so, a);
    }
}
