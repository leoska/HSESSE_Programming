namespace Self01
{
    internal class Program
    {
        public static void Triangle(int n)
        {
            if (n >0)
            {
                Console.WriteLine($"N = {n}");
                string str = "";
                for (int i = 0; i < n; i++)
                {
                    str += "*";
                    Console.WriteLine(str);
                }
                
            }

        }
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Triangle(n);
        }
    }
}