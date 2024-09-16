using System;
internal class Program
{
    static void Main()
    {
        double x, y;
        try
        {
            x = double.Parse(Console.ReadLine());
            y = double.Parse(Console.ReadLine());
            if ((y<=0 && x*x+y*y<1)||(y>0 && x*x+y*y<4))
            {
                Console.WriteLine("точка попала во внутрь области");
            }
            else if ((y==0 && (x>=-2 && x<=-1) || (x>=1 && x<=2)) || (y>0 && x*x+y*y==4) || (y<0 && x*x+y*y==1))
            {
                Console.WriteLine("точка попала на границу области");
            }
            else
            {
                Console.WriteLine("точка не принадлежит области");
            }
        }
        catch (FormatException ex)
        {
            Console.WriteLine("введены некорректные данные");
        }
    }
}
