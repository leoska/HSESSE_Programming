namespace self03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int counter = 0;

            for (int i = 2000; i <= 3000; i++)
            {
                bool flag = true;

                for (int j = 0; j < i.ToString().Length; j++)
                {
                    if (i.ToString().Count(x => x == i.ToString()[j]) > 1)
                    {
                        flag = false;
                        break;
                    }
                }

                if (flag)
                {
                    counter++;
                    Console.WriteLine(i);
                }
            }
            Console.WriteLine($"всего - {counter} чисел");
        }
    }
}