namespace task02
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Введите длину массива");
            int n = int.Parse(Console.ReadLine());
            Random rnd = new Random();
            Methods.Fill_Array(n, rnd, out int[] A1);
            Methods.Fill_Array(n, rnd, out double[] A2);
            Methods.Fill_Array(n, out int[] A3);
            Methods.Fill_Array(n, out double[] A4);
            Methods.Print_Array(A1);
            Methods.Print_Array(A2);
            Methods.Print_Array(A3);
            Methods.Print_Array(A4);
        }
    }
}