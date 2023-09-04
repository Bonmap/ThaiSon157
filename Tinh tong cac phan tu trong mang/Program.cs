class program
{
    static void Main(string[] args)
    {
       int [] numbers= new int [5];
       numbers[0]=1;
       numbers[1]=2;
       numbers[2]=3;
       numbers[3]=4;
       numbers[4]=5;
       int total = 0;
       for(int i=0;i<numbers.Length;i++)
       {
        total=numbers[i]+total;
       }
      Console.WriteLine(total);
    }
}