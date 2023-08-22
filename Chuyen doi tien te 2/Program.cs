
namespace cannangcuacothe
{
    class Program
    {
        const int VND_RATE=23000;
        static void Main(string[] args)
        { 
            int usd;
            Console.WriteLine("Nhap vao bao nhieu USD");
            usd = int.Parse(Console.ReadLine());
            int ketqua = usd * VND_RATE;
            Console.WriteLine("Ket qua la "+ ketqua + " VND");
        }

    }
}