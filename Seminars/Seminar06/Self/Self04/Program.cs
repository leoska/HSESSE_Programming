using System;
internal class Program
{
    static double op(int number, double a, double b)
    {
        double res = number switch
        {
            1 => a + b,
            2 => a - b,
            3 => a * b,
            4 => a / b
        };
        return res;
    }
    static string op(int number)
    {
        string res = number switch
        {
            1 => "+",
            2 => "-",
            3 => "*",
            4 => "/"
        };
        return res;
    }
    static void Main()
    {
        for (int i1=1; i1<=4;i1++)
        {
            for (int i2=1;i2<=4;i2++)
            {
                for (int i3=1;i3<=4;i3++)
                {
                    for (int i4=1;i4<=4;i4++)
                    {
                        for (int i5=1;i5<=4;i5++)
                        {
                            if (op(i5,op(i4,op(i3,op(i2,op(i1,1,2),3),4),5),6)==35)
                            {
                                Console.WriteLine($"((((1{op(i1)}2){op(i2)}3){op(i3)}4){op(i4)}5){op(i5)}6");
                            }
                        }
                    }
                }
            }
        }
    }
}