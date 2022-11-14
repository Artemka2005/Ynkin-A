using System;
public class MainClass
{
    public static void Main()
    {
        int num1, num2, num3, res1, res2;
        Console.WriteLine("Число единиц двузначного числа:");
        num1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Число десятков двузначного числа");
        num2 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Число однозначного числа");
        num3 = Convert.ToInt32(Console.ReadLine());
        res1 = (num1 + num3) % 10;
        res2 = num2 + (num1 + num3) / 10;
        Console.WriteLine($"Итог:{res2}{res1}"); ;
    }
}
