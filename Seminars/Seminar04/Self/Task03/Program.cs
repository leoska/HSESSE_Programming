namespace Task03
{
    class Program
    {
        static void IncorrectInput()
        {
            Console.WriteLine("Введены некорректные данные");
        }

        static void Main(string[] args)
        {
            int code;
            double A, B;

            Console.Write("Введите код операции: ");
            if(!int.TryParse(Console.ReadLine(), out code) || code < 1 || code > 4)
            {
                IncorrectInput();
                return;
            }
            Console.Write("Введите A: ");
            if(!double.TryParse(Console.ReadLine(), out A))
            {
                IncorrectInput();
                return;
            }
            Console.Write("Введите B: ");
            if(!double.TryParse(Console.ReadLine(), out B) || B == 0)
            {
                IncorrectInput();
                return;
            }

            switch (code)
            {
                case 1: Console.WriteLine($"{A} + {B} = {A + B}"); break;
                case 2: Console.WriteLine($"{A} - {B} = {A - B}"); break;
                case 3: Console.WriteLine($"{A} * {B} = {A * B}"); break;
                case 4: Console.WriteLine($"{A} / {B} = {A / B}"); break;
            };
        }
    }
}
