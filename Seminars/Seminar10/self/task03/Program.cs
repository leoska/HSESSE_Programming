namespace task03
{
    internal class Program
    {
        public static bool TryFindMaxElement(int[] array,out int MaxValue)
        {
            MaxValue = 0;
            bool f= false;
            foreach(int x in array)
            {
                if (x>MaxValue)
                {
                    MaxValue = x;
                    f = true;
                }
            }
            return f;
        }

        static void Main(string[] args)
        {
            int n;
            while (true)
            {
                Console.WriteLine("Введите размер массива (N>=0)");
                if (int.TryParse(Console.ReadLine(), out n) && n >= 0)
                {
                    Console.WriteLine("Успешно введено");
                    break;
                }
                Console.WriteLine("Введены некорректные данные, повторите ввод");
            }
            int[] A = new int[n];
            if (n != 0)
            {
                Console.WriteLine("Введите элементы массива - целые числа");
            }
            for (int i=0;i<n;i++)
            {
                int a;
                while (true)
                {
                    Console.WriteLine($"Введите {i + 1} элемент");
                    if (int.TryParse(Console.ReadLine(), out a))
                    {
                        Console.WriteLine($"{i + 1} элемент успешно введен");
                        break;
                    }
                    Console.WriteLine("Введены некорретные данные, повторите попытку");
                }
                A[i] = a;
            }
            if (n != 0)
            {
                Console.WriteLine("Массив успешно введен");
            }
            if (TryFindMaxElement(A, out int MaxValue))
            {
                Console.WriteLine($"\nМаксимальный элемент = {MaxValue}");
            }
            else
            {
                Console.WriteLine("Нет максимального элемента");
            }
        }
    }
}