using System;
class asd {
    static void Ornament(int N, int M) {
        if (M <= 0) return;
        for (int q = 1; q <= M; ++q) {
            for (int i = 1; i <= N; ++i) {
                for (int j = 1; j <= i; ++j) {
                    Console.Write('*');
                }
                Console.WriteLine();
            }
        }
    }
    static void Main(string[] args) {
        int N = int.Parse(Console.ReadLine());
        int M = int.Parse(Console.ReadLine());

        Ornament(N, M);
    }
}
