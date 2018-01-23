using System;
using System.Collections.Generic;

class LetterCollection
{
    string[] letters = { "A", "B", "C" };

    public IEnumerable<string> Forward()
    {
        for (int i = 0; i < letters.Length; i++)
            yield return letters[i];
    }
}

class MainClass
{
    static void Main()
    {
        LetterCollection cc = new LetterCollection();

        foreach (string color in cc.Forward())
            Console.Write("{0} ", color);
        Console.WriteLine("");

    }
}
//A B C