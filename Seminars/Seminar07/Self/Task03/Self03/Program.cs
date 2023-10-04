namespace Self03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            if (int.TryParse(Console.ReadLine(), out int n) && n > 0 && int.TryParse(Console.ReadLine(), out int m) && m > 0)
            {
                ModOrnamentClass.ModOrnament(n, m);
            }
            
        }
    }
}