namespace Task05
{
    class Program
    {
        static void Main(string[] args)
        {
            int U = int.Parse(Console.ReadLine());
            int R = int.Parse(Console.ReadLine());
            Console.WriteLine(U / (double)R);
            Console.WriteLine(U * U / (double)R);
        }
    }
}
