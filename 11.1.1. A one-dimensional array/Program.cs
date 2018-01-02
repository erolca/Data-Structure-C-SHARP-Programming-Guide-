using System;

//An array is a collection of variables of the same type that are referred to by a common name.
//To declare a one-dimensional array, you will use this general form:

//type[] array-name = new type[size];


class MainClass
{
    public static void Main()
    {
        int[] sample = new int[10];
        int i;

        for (i = 0; i < 10; i = i + 1)
            sample[i] = i;

        for (i = 0; i < 10; i = i + 1)
            Console.WriteLine("sample[" + i + "]: " +
                               sample[i]);
    }
}



//sample[0]: 0
//sample[1]: 1
//sample[2]: 2
//sample[3]: 3
//sample[4]: 4
//sample[5]: 5
//sample[6]: 6
//sample[7]: 7
//sample[8]: 8
//sample[9]: 9