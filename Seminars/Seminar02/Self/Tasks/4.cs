using System;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        { /// Task04
            char a;
            string ans = "�� �����, �� �����";

            a = char.Parse(Console.ReadLine());

            ans = a >= '0' ? (a <= '9' ? "��� �����" : "") : "";
            ans = a > '�' ? (a < '�' ? "��� �����" : "") : "";
            ans = a > '�' ? (a < '�' ? "��� �����" : "") : "";

            Console.WriteLine(ans);
        }
    }
}
