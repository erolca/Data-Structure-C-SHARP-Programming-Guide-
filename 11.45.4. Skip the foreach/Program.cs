using System;
using System.Collections.Generic;


//11.45.4.	Skip the foreach and manually use the enumerable and enumerator for a 'yield' IEnumerable


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


        IEnumerable<string> ieable = cc.Forward();
        IEnumerator<string> ieator = ieable.GetEnumerator();

        while (ieator.MoveNext())
            Console.Write("{0} ", ieator.Current);
    }
}
//A B C