namespace task06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите строку");
            string s = Console.ReadLine();
            int startIndex, endIndex;
            try
            {
                startIndex = s.IndexOf("[");
                endIndex = s.IndexOf("]");
                Console.WriteLine(s[(startIndex + 1)..endIndex]);
            }
            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine("Не содержит '[' или ']'");
            }


        }
    }
}