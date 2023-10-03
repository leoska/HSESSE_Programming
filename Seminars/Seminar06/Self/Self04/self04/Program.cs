namespace self04
{
    internal class Program
    {
        static double Oper(double x, double y, char op)
        {
            switch (op)
            {
                case '+':
                    return x + y;

                case '-':
                    return x - y;

                case '*':
                    return x * y;

                case '/':
                    return x / y;

                default:
                    return 0;
            }
        }
        static void Main(string[] args)
        {
            char[] ops = { '+', '-', '*', '/' };

            foreach (char ch1 in ops)
            {
                foreach (char ch2 in ops)
                {
                    foreach (char ch3 in ops)
                    {
                        foreach (char ch4 in ops)
                        {
                            foreach (char ch5 in ops)
                            {
                                if (Oper(Oper(Oper(Oper(Oper(1, 2, ch1), 3, ch2), 4, ch3), 5, ch4), 6, ch5) == 35)
                                {
                                    Console.WriteLine($"Комбинация знаков: {ch1}{ch2}{ch3}{ch4}{ch5}");
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}