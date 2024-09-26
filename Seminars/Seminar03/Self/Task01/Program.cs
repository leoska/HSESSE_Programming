class Program {
    static void Main() {
        int n;
        if (int.TryParse(Console.ReadLine(), out n))
        {
            if (n < 1 || n >= 11)
            {
                Console.WriteLine("Out of range");
                return;
            }
        }
        else
        {
            Console.WriteLine("Wrong input");
            return;
        }

        double l;
        if (double.TryParse(Console.ReadLine(), out l))
        {
            if (l <= 0)
            {
                Console.WriteLine("Out of range");
                return;
            }
        }
        else
        {
            Console.WriteLine("Wrong input");
            return;
        }

        double s = (n*Math.Pow(l, 2)/4/Math.Tan(Math.PI/n));
        Console.WriteLine(s);
    }
}