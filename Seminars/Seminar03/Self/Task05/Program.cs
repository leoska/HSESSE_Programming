class Program
{
    static void Main()
    {
        // Collecting input from user
        if (!(double.TryParse(Console.ReadLine(), out double a)))
        {
            Console.WriteLine("Wrong input");
            return;
        }
        if (!(double.TryParse(Console.ReadLine(), out double b)))
        {
            Console.WriteLine("Wrong input");
            return;
        }
        if (!(double.TryParse(Console.ReadLine(), out double c)))
        {
            Console.WriteLine("Wrong input");
            return;
        }

        double d = Math.Pow(b, 2) - 4*a*b;
        string output;
        // Handling special cases
        if (a==0)
        {
            double x = -c/b;
            output = $"Linear equations have only one root. x={x}";
        }
        else if (d==0)
        {
            double x = -b/2/a;
            output = $"Because the discriminant is equal to zero, equation has two equal roots. x1=x2={x}";
        }
        else if (d < 0)
        {
            output = "Because the discriminant is less than 0, equation has no real roots.";
        }
        // Default outcome
        else
        {
            double x1 = (-b-Math.Pow(d, 0.5))/2/a;
            double x2 = (-b+Math.Pow(d, 0.5))/2/a;
            output = $"Equation has two roots. x1={x1}, x2={x2}";    
        }

        Console.WriteLine($"{a}*x^2+{b}*x+{c}=0");
        Console.WriteLine(output);
    }
}