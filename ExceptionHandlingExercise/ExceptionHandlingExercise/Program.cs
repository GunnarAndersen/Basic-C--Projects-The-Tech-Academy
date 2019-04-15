using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        try
        {
            var numbers = new List<int>();
            numbers.Add(15);
            numbers.Add(14);
            numbers.Add(26);
            numbers.Add(25);
            numbers.Add(23);
            numbers.Add(20);
            numbers.Add(12);
            numbers.Add(9);
            numbers.Add(2);
            numbers.Add(7);
            numbers.Add(6);
            numbers.Add(5);
            numbers.Add(4);
            Console.WriteLine("Enter a number by which we shall divide the integers in this list");
            int divisor = Convert.ToInt32(Console.ReadLine());

            int i = 0;
            while (i < 13)
            {
                Console.WriteLine(numbers[i]);
                Console.WriteLine(numbers[i] + " divided by  " + divisor + "\n");
                Console.WriteLine(numbers[i] / divisor);
                i++;
            }
        }
        catch (FormatException ex)
        {
            Console.WriteLine("Please input a whole number");
        }
        catch (DivideByZeroException ex)
        {
            Console.WriteLine("Please do not divide by zero");
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
        finally
        {
            Console.ReadLine();
        }
    }
}

