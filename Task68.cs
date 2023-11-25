using System;

class Program
{
    static int akkerman(int m, int n) {
        if (m == 0) {
            return n + 1;
        } else if (m > 0 && n == 0) {
            return akkerman(m - 1, 1);
        } else if (m > 0 && n > 0) {
            return akkerman(m - 1, akkerman(m, n - 1));
        } else {
            return 0;
        }
    }
    
    static int Prompt(string Word) {
        Console.WriteLine(Word);
        return int.Parse(Console.ReadLine());
    }
    
    static void Main() {
        int m = Prompt("Write the first number");
        int n = Prompt("Write the second number");
        Console.WriteLine($"Akkerman : {akkerman(m, n)}");
    }
}