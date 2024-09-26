class Program
{
    static void Main()
    {
        if (!(double.TryParse(Console.ReadLine(), out double x)))
        {
            Console.WriteLine("Wrong input");
            return;
        }
        if (!(double.TryParse(Console.ReadLine(), out double y)))
        {
            Console.WriteLine("Wrong input");
            return;
        }
        double radius = Math.Pow((Math.Pow(x, 2) + Math.Pow(y, 2)), 0.5);
        if ((radius==2 && y>0)||(radius==1 && y<0)||(y==0 && radius>=1 && radius<=2))
        {
            Console.WriteLine("On border");
        }
        else if ((y>0 && radius<2)||(y<=0 && radius<1))
        {
            Console.WriteLine("Inside");
        }
        else
        {
            Console.WriteLine("Outside");
        }
    }
}