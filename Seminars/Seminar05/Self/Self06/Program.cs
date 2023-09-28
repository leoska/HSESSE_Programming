namespace Self06;
class Program
{
    static void Main()
    {
        for (uint n = 100; n < 1000; ++n)
        {
            string s = Convert.ToString(n);
            if (s[0] == s[1] & s[1] == s[2])
            {
                Console.WriteLine(s);
            }
        }
    }
}
// Хотя задание странное по своей сути, потому что и так понятно, что это за числа.
// Да и просто выводить не очень интересно)