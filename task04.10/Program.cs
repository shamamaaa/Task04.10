namespace task04._10;

#region Task_1
class Program
{
    static void Main(string[] args)
    {

        int[] arr = { 0, 3, 4, 6, 7, -1, -6, 190 };

        Console.WriteLine(FindMin(arr));

    }
    public static int FindMin(int[] numbers)
    {
        int min = numbers[0];

        for (int i = 0; i < numbers.Length; i++)
        {
            int number = numbers[i];

            if (number < min)
            {
                min = number;
            }
        }

        return min;
    }
}
#endregion

#region Task_2
class Program
{
    static void Main(string[] args)
    {
        FindArea(4);
        FindArea(6, 9);
        FindArea(7, 3, 5);
        FindArea(4, 6, 4, 3);
    }

    public static void FindArea(int r)
    {
        Console.WriteLine(3 * (r * r));

    }
    public static void FindArea(int a, int b)
    {
        Console.WriteLine(a * b);
    }

    public static void FindArea(int a, int b, int c)
    {
        Console.WriteLine(2 * (a * b + a * c + b * c));
    }

    public static void FindArea(int a, int b, int c, int r)
    {
        int per = (a + b + c) / 2;
        Console.WriteLine(per * r);
    }


}
#endregion

#region Task_3
class Program
{
    static void Main(string[] args)
    {
        int n = IsPositive();
        Console.WriteLine(SumOfNumbers(n));
    }

    public static int IsPositive()
    {
        int n = int.Parse(Console.ReadLine());

        if (n < 0)
        {
            return IsPositive();
        }
        else return n;
    }
    public static int SumOfNumbers(int n)
    {
        int sum = 0;

        while (n != 0)
        {
            sum = sum + n % 10;
            n = n / 10;
        }

        return sum;
    }

}


#endregion

