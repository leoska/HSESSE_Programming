namespace Self03;
class Program
{
    static void Main()
    {
        for (uint n = 2000; n <= 3000; ++n)
        {
            string number = Convert.ToString(n);
            if (number[0] != number[1] & number[0] != number[2] &
                number[0] != number[3] & number[1] != number[2] &
                number[1] != number[3] & number[2] != number[3])
            {
                Console.WriteLine(n);
            }
        }
    }
}