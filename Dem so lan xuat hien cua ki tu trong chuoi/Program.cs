class program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Dem so lan xuat hien cua ki tu trong chuoi");
        Console.WriteLine("Nhap chuoi");
        string chuoi = Console.ReadLine();
        Console.WriteLine("Nhap ki tu");
        char kitutim = Convert.ToChar(Console.ReadLine());
        if (Demsolanxuathienkytu(chuoi, kitutim) == 0)
        {
            Console.Write("ki tu khong co trong chuoi");
        }
        else
        {
            Console.Write("So lan xuat hien la: ");
            Console.WriteLine(Demsolanxuathienkytu(chuoi, kitutim));
        }
    }
    public static int Demsolanxuathienkytu(string chuoi, char kitutim)
    {
        int dem = 0;
        for (int i = 0; i < chuoi.Length; i++)
        {
            if (chuoi[i] == kitutim)
            {
                dem++;
            }
        }
        return dem;
    }
}
