namespace Self04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            if (int.TryParse(Console.ReadLine(), out int n) && n > 0)
            {
                PythonClass.DrawPython(n);
            }
                
        }
    }
}