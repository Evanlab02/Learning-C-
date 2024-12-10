using System;
using System.Collections.Generic;

public class Hello
{
    public static void Main()
    {
        List<int> primeNumbers = new List<int>();
        int[] array = new int[] { 2, 3, 5, 7, 11 };
        primeNumbers.AddRange(array);

        // test code
        Console.WriteLine(primeNumbers.Count);
        Console.WriteLine(primeNumbers[0]);
        Console.WriteLine(primeNumbers[1]);
        Console.WriteLine(primeNumbers[2]);
        Console.WriteLine(primeNumbers[3]);
        Console.WriteLine(primeNumbers[4]);

    }
}