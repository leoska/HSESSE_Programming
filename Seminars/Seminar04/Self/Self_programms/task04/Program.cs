using System;
    internal class Program
    {
        static void Main(string[] args)
        {
        string s_in, s_out;
        s_in = Console.ReadLine();
        if (s_in.Contains("-"))
        {
            int numb = s_in.IndexOf("-");
            double a, b, c;
            string srez1 = (s_in.Substring(0, numb)).Trim();  // Срез первого числа
            int len = s_in.Length;
            string srez2 = (s_in.Substring(numb+1, len-numb-1)).Trim();  // Срез второго числа
            a = double.Parse(srez1);
            b = double.Parse(srez2);
            c = a - b;
            Console.WriteLine($"результат вычислений: {c}");
        }
        else if (s_in.Contains("+"))
        {
            int numb = s_in.IndexOf("+");
            double a, b, c;
            string srez1 = (s_in.Substring(0, numb)).Trim();  // Срез первого числа
            int len = s_in.Length;
            string srez2 = (s_in.Substring(numb + 1, len - numb - 1)).Trim();  // Срез второго числа
            a = double.Parse(srez1);
            b = double.Parse(srez2);
            c = a + b;
            Console.WriteLine($"результат вычислений: {c}");
        }
        else if (s_in.Contains("*"))
        {
            int numb = s_in.IndexOf("*");
            double a, b, c;
            string srez1 = (s_in.Substring(0, numb)).Trim();  // Срез первого числа
            int len = s_in.Length;
            string srez2 = (s_in.Substring(numb + 1, len - numb - 1)).Trim();  // Срез второго числа
            a = double.Parse(srez1);
            b = double.Parse(srez2);
            c = a * b;
            Console.WriteLine($"результат вычислений: {c}");
        }
        else if (s_in.Contains("/"))
        {
            int numb = s_in.IndexOf("/");
            double a, b, c;
            string srez1 = (s_in.Substring(0, numb)).Trim();  // Срез первого числа
            int len = s_in.Length;
            string srez2 = (s_in.Substring(numb + 1, len - numb - 1)).Trim();  // Срез второго числа
            a = double.Parse(srez1);
            b = double.Parse(srez2);
            c = a / b;
            Console.WriteLine($"результат вычислений: {c}");
        }
        else
        {
            Console.WriteLine("Введены некорректные данные");
        }
    }
    }
