using System.Data.SqlTypes;
using System.Security.Cryptography;

namespace task03
{
    internal class Program
    {
        public static bool Shift(int shiftCount, ref char c)
        {
            char[] ABC = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'G', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };
            char[] abc = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'g', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
            char[] RABC = { 'А', 'Б', 'В', 'Г', 'Д', 'Е', 'Ё', 'Ж', 'З', 'И', 'Й', 'К', 'Л', 'М', 'Н', 'О', 'П', 'Р', 'С', 'Т', 'У', 'Ф', 'Х', 'Ц', 'Ч', 'Ш', 'Щ', 'Ъ', 'Ы', 'Ь', 'Э', 'Ю', 'Я' };
            char[] rabc = { 'а', 'б', 'в', 'г', 'д', 'е', 'ё', 'ж', 'з', 'и', 'й', 'к', 'л', 'м', 'н', 'о', 'п', 'р', 'с', 'т', 'у', 'ф', 'ч', 'ц', 'ч', 'ш', 'щ', 'ъ', 'ы', 'ь', 'э', 'ю', 'я' };
            if (Array.IndexOf(ABC, c)!=-1)
            {
                int n = Array.IndexOf(ABC, c);
                shiftCount = shiftCount % 26;
                n = (n + shiftCount) % 26;
                if (n < 0)
                {
                    c = ABC[26 + n];
                }
                else
                {
                    c = ABC[n];
                }
                return true;
            }
            else if (Array.IndexOf(abc, c) != -1)
            {
                int n = Array.IndexOf(abc, c);
                shiftCount = shiftCount % 26;
                n = (n + shiftCount) % 26;
                if (n < 0)
                {
                    c = abc[26 + n];
                }
                else
                {
                    c = abc[n];
                }
                return true;
            }
            else if (Array.IndexOf(RABC, c) != -1)
            {
                int n = Array.IndexOf(RABC, c);
                shiftCount = shiftCount % 33;
                n = (n + shiftCount) % 33;
                if (n < 0)
                {
                    c = RABC[33 + n];
                }
                else
                {
                    c = RABC[n];
                }
                return true;
            }
            else if (Array.IndexOf(rabc, c) != -1)
            {
                int n = Array.IndexOf(rabc, c);
                shiftCount = shiftCount % 33;
                n = (n + shiftCount) % 33;
                if (n < 0)
                {
                    c = rabc[33 + n];
                }
                else
                {
                    c = rabc[n];
                }
                return true;
            }

            else
            {
                return false;
            }
        }
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Введите символ и кол-во позиций для сдвига");
                char c = char.Parse(Console.ReadLine());
                int shiftCount = int.Parse(Console.ReadLine());
                bool f=Shift(shiftCount, ref c);
                if (f)
                {
                    Console.WriteLine($"Полученное значение = {c}");
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Введены некорретные значения");
            }
            
        }
    }
}