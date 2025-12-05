using System;
class Program
{
    static void Main()
    {
        int[] numbers = { 1, 2, 3, 4, 5 };
        bool containsThree = false;
        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] == 3)
            {
                containsThree = true;
                break;
            }
        }
        Console.WriteLine(containsThree);
    }
}
