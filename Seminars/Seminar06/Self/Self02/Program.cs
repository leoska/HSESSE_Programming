namespace Self02;
class Program
{
    static void Main()
    {
        bool a = false, b = false, c = false;
        do
        {
            do
            {
                do
                {
                    bool f = !(a | b & c) | a;
                    Console.WriteLine($"a = {a}, b = {b}, c = {c}, f = {f}");
                    c = !c;
                } while (c);
                b = !b;
            } while (b);
            a = !a;
        } while (a);
    }
}