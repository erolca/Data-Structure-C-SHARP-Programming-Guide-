using System;
using System.Collections;


//11.44.7.	Build your own IEnumerator/IEnumerable and use it in foreach loop


class LetterEnumerator : IEnumerator
{
    string[] letters;
    int Position = -1;

    public LetterEnumerator(string[] theletters)
    {
        letters = new string[theletters.Length];
        for (int i = 0; i < theletters.Length; i++)
            letters[i] = theletters[i];
    }

    public object Current
    {
        get { return letters[Position]; }
    }

    public bool MoveNext()
    {
        if (Position < letters.Length - 1)
        {
            Position++; return true;
        }
        else
            return false;
    }

    public void Reset()
    {
        Position = -1;
    }
}

class LetterList : IEnumerable
{
    string[] letters = { "A", "B", "C" };
    public IEnumerator GetEnumerator()
    {
        return new LetterEnumerator(letters);
    }
}

class MainClass
{
    static void Main()
    {
        LetterList mc = new LetterList();

        foreach (string l in mc)
            Console.WriteLine("{0} ", l);

    }
}
//A
//B
//C