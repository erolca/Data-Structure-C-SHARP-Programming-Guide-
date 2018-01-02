using System;
using System.Collections;

class Class1
{
    [STAThread]
    static void Main(string[] args)
    {
        NameCollection names = new NameCollection();
        names.Add("A");
    }
}

class NameCollection : ArrayList
{
    public override int Add(object value)
    {
        if (value.GetType() == Type.GetType("System.String"))
        {
            string[] name = ((string)value).Split(new char[] { ' ' });
            if (name.Length == 2)
                return base.Add(value);
        }

        return -1;
    }

    public int Add(string value)
    {
        string[] name = ((string)value).Split(new char[] { ' ' });
        if (name.Length == 2)
            return base.Add(value);
        return -1;
    }
}