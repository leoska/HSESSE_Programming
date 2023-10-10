namespace Task01
{
    internal class Program
    {
        static void Triangle(int a)
        {
            string s = "";
            for (int i = 0; i < a; i++)
            {
                s += "*";
                Console.WriteLine(s);

            }
        }
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Triangle(n);
        }
    }
}