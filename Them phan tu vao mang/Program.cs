class program
{
    public static void Main(string[] args)
    {
        int[] array;
        int added_number;
        int location_added;
        int length_of_the_array;
        Console.WriteLine("Add elements to the largest array with 10 elements");

        Console.WriteLine("Enter the length of the array");
        do
        {
            length_of_the_array = int.Parse(Console.ReadLine());
            if (length_of_the_array > 10)
            {
                Console.WriteLine("The length of the array exceeds 10 elements");
                Console.WriteLine("Please re-enter");
            }
        } while (length_of_the_array > 10);
        array = new int[length_of_the_array];
        int i;
        Console.WriteLine("import the elements into the array");
        for (i = 0; i < length_of_the_array; i++)
        {
            array[i] = int.Parse(Console.ReadLine());
        }
        Console.WriteLine("Enter added number");
        added_number = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter location added");
        do
        {
            location_added = int.Parse(Console.ReadLine());
            if (location_added > length_of_the_array)
            {
                Console.WriteLine("Position exceeds the length of the array.Please re-enter");
            }
        } while (location_added > length_of_the_array);
        Console.WriteLine("array elements before adding numbers");
        for (i = 0; i < length_of_the_array; i++)
        {
            Console.Write(array[i]);
            Console.Write(" ");
        }
        for (i = length_of_the_array - 1; i > location_added - 1; i--)
        {
            array[i] = array[i - 1];
        }
        array[location_added - 1] = added_number;
        Console.WriteLine("");
        Console.WriteLine("array elements after adding numbers");
        for (i = 0; i < length_of_the_array; i++)
        {
            Console.Write(array[i]);
            Console.Write(" ");
        }
    }
}