using System;

class Program
{
    static int sum_numbers(int m, int n) {
        if (m == n) {
            return m;
        } else {
            return m + sum_numbers(m + 1, n);
        }
    }
    
    static int Prompt(string Word) {
        Console.WriteLine(Word);
        return int.Parse(Console.ReadLine());
    }
    
    static void Main() {
        int m = Prompt("Write the first number");
        int n = Prompt("Write the second number");
        Console.WriteLine($"Sum of numbers : {sum_numbers(m, n)}");
    }
}