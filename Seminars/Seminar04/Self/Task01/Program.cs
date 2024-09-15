class Program
{
    static void Main()
    {
        string abc = "qwertyuiopasdfghjklzxcvbnm";
        string capitalizedAbc = abc.ToUpper();
        string nums = "1234567890";
        if (!(char.TryParse(Console.ReadLine(), out char a)))
        {
            Console.WriteLine("Wrong input");
            return;
        }
        int f;
        if (nums.Contains(a))
        {
            f = 100;
        }
        else if (capitalizedAbc.Contains(a))
        {
            f = 200;
        }
        else if (abc.Contains(a))
        {
            f = 300;
        }
        else
        {
            f = 400;
        }

        Console.WriteLine(f);
        Console.WriteLine(a);
    }
}