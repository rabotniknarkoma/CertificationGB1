using System;

class Program
{
    static void rec_numbers(int m, int n) {
        Console.WriteLine(m);
        if (m < n) {
            rec_numbers(m + 1, n);
        }
    }
    
    static int Prompt(string Word) {
        Console.WriteLine(Word);
        return int.Parse(Console.ReadLine());
    }
    
    static void Main() {
        int m = Prompt("Write the first number");
        int n = Prompt("Write the second number");
        rec_numbers(m, n);
    }
}