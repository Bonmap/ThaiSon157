namespace chuyendoitiente
{
    public class Program
    {
        static void Main(string[] args)
        {
            float USD;
            float VND = 23000f;
            Console.Write("Enter USD: ");
            USD = float.Parse(Console.ReadLine());
            float area = USD*VND;
            Console.WriteLine(area);
        }
        
    }
}
