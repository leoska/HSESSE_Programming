namespace self02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int counterInt = 0, counterDouble = 0, counterNan = 0;

            while (true)
            {
                bool flag = double.TryParse(Console.ReadLine(), out double number);

                if (flag && number == 0)
                {
                    break;
                }
                else if (!flag)
                {
                    counterNan++;
                }
                else if ((int)number == number)
                {
                    counterInt++;
                }
                else
                {
                    counterDouble++;
                }

                Console.WriteLine($"Int: {counterInt}\tDouble: {counterDouble}\tNan: {counterNan}");




            }
        }
    }
}