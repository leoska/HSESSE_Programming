namespace Self04;
class Program
{
    static void Main()
    {
        double sum = 0, newSum = 0;
        int starter = 1;

        do
        {
            sum = newSum;
            newSum += 1.0f / (starter * (starter + 1) * (starter + 2));
            ++starter;
        } while (newSum - sum > double.Epsilon);

        Console.WriteLine($"Sum = {newSum}"); // float - 0.24999848
        // double - 0.24999970726979004
    }
}