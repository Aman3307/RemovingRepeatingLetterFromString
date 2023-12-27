using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a string: ");
        string inputString = Console.ReadLine();

        int length = inputString.Length;

        for (int i = 0; i < length; i++)
        {
            for (int j = i + 1; j < length;)
            {
                char currentChar = inputString[i];
                char iteratingChar = inputString[j];

                if (currentChar == iteratingChar)
                {
                    inputString = inputString.Remove(j, 1);
                    length = length - 1;
                }
                else
                {
                    j++;
                }
            }
        }

        Console.WriteLine("The String after removing repetitive characters is: " + inputString);
        Console.ReadKey();
    }
}
