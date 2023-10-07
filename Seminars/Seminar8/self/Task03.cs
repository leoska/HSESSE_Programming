using System;
using System.Runtime.Serialization;
class asd {
    public static bool check (char c, int f) {
        if (f == 1) c++;
        if (f == 2) c--;

        char c1 = char.ToLower(c);
        if (c1 >= 'a' && c1 <= 'z' || c1 >= 'а' && c1 <= 'я') return true;
        else return false;
    }
    public static bool Shift(ref char c, int ShiftCount) {
        if (check(c, 0)) {
            int k = Math.Abs(ShiftCount);
            while (k-- > 0) {
                if (ShiftCount > 0) {
                    if (check(c, 1)) c++;
                    else {
                        c--;
                        while(check(c, 0)) {
                            c--;
                        }
                        c++;
                    }
                }
                else {
                    if (check(c, 2)) c--;
                    else {
                        c++;
                        while(check(c, 0)) {
                            c++;
                        }
                        c--;
                    }
                }
            }
            return true;
        }
        else return false;
    }
    static void Main(string[] args) {
        char c = char.Parse(Console.ReadLine());
        int n = int.Parse(Console.ReadLine());

        if (!Shift(ref c, n)) {
            Console.WriteLine("Неверный ввод");
        }
        else {
            Console.WriteLine(c);
        }
    }
} 
