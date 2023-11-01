using System;
public class GFG 
{
    public static int Fib(int n) 
    {
        if (n <= 1) 
        {
            return n; 
        }
        else 
        {
            return Fib(n - 1) + Fib(n - 2); 
        } 
    } 
    public static void Main(string[] args) 
    {
        Console.Write("Enter a number: ");
        int n = int.Parse(Console.ReadLine());
        Console.Write(Fib(n)); 
    }
}
//امیرحسین جورابچی
//4.عدد n ام فیبوناچی