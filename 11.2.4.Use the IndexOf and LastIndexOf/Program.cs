using System;


//Array.IndexOf Yöntemi (Array, Object)
//public static int IndexOf(Array array, object value)
//array Type: System.Array Aranacak tek boyutlu dizi.
//value Type: System.Object Bulunacak nesne array.

//IndexOf(Array, Object), dizenin ilk örneğinin belirlemek için bir dize dizisi olarak "".
//IndexOf(Array, Object, Int32), dizenin ilk örneğinin belirlemek için dördüncü bir dize dizisi son öğeleri için "".
//IndexOf(Array, Object, Int32, Int32), dizenin ilk örneğinin belirlemek için bir dizede "" dizi öğeden son başarılı eşleşme dizinin sonuna izler.

//Belirtilen nesne arar ve ilk oluşum dizinini tek boyutlu bir dizi döndürür.




//Array.LastIndexOf Yöntemi
//Bir boyutlu bir değerin son geçtiği dizini döndürür Array veya bir bölümünü Array.
//public static int LastIndexOf(Array array,object value)


class MainClass
{
    public static void Main()
    {
        int[] intArray = { 1, 2, 1, 3 };
        Console.WriteLine("intArray:");
        for (int i = 0; i < intArray.Length; i++)
        {
            Console.WriteLine("intArray[" + i + "] = " +
              intArray[i]);
        }


        int index = Array.IndexOf(intArray, 1);
        Console.WriteLine("Array.IndexOf(intArray, 1) = " + index);
        index = Array.LastIndexOf(intArray, 1);
        Console.WriteLine("Array.LastIndexOf(intArray, 1) = " + index);


        //-2
        MainClass d = new MainClass();
        d.indexofMethod();
        d.LastIndexOfMethod();
    }

    public void indexofMethod()
    {

        // Create a string array with 3 elements having the same value.
        String[] strings = { "the", "quick", "brown", "fox", "jumps",
                            "over", "the", "lazy", "dog", "in", "the",
                            "barn" };

        // Display the elements of the array.
        Console.WriteLine("The array contains the following values:");
        for (int i = strings.GetLowerBound(0); i <= strings.GetUpperBound(0); i++)
            Console.WriteLine("   [{0,2}]: {1}", i, strings[i]);

        // Search for the first occurrence of the duplicated value.
        String searchString = "the";
        int index = Array.IndexOf(strings, searchString);
        Console.WriteLine("The first occurrence of \"{0}\" is at index {1}.",
                             searchString, index);

        // Search for the first occurrence of the duplicated value in the last section of the array.
        index = Array.IndexOf(strings, searchString, 4);
        Console.WriteLine("The first occurrence of \"{0}\" between index 4 and the end is at index {1}.",
                          searchString, index);

        // Search for the first occurrence of the duplicated value in a section of the array.
        int position = index + 1;
        index = Array.IndexOf(strings, searchString, position, strings.GetUpperBound(0) - position + 1);
        Console.WriteLine("The first occurrence of \"{0}\" between index {1} and index {2} is at index {3}.",
                          searchString, position, strings.GetUpperBound(0), index);

    }


    public void LastIndexOfMethod()
    {
        Array myArray = Array.CreateInstance(typeof(String), 12);
        myArray.SetValue("the", 0);
        myArray.SetValue("quick", 1);
        myArray.SetValue("brown", 2);
        myArray.SetValue("fox", 3);
        myArray.SetValue("jumps", 4);
        myArray.SetValue("over", 5);
        myArray.SetValue("the", 6);
        myArray.SetValue("lazy", 7);
        myArray.SetValue("dog", 8);
        myArray.SetValue("in", 9);
        myArray.SetValue("the", 10);
        myArray.SetValue("barn", 11);

        // Displays the values of the Array.
        Console.WriteLine("The Array contains the following values:");
        PrintIndexAndValues(myArray);

        // Searches for the last occurrence of the duplicated value.
        String myString = "the";
        int myIndex = Array.LastIndexOf(myArray, myString);
        Console.WriteLine("The last occurrence of \"{0}\" is at index {1}.", myString, myIndex);

        // Searches for the last occurrence of the duplicated value in the first section of the Array.
        myIndex = Array.LastIndexOf(myArray, myString, 8);
        Console.WriteLine("The last occurrence of \"{0}\" between the start and index 8 is at index {1}.", myString, myIndex);

        // Searches for the last occurrence of the duplicated value in a section of the Array.
        // Note that the start index is greater than the end index because the search is done backward.
        myIndex = Array.LastIndexOf(myArray, myString, 10, 6);
        Console.WriteLine("The last occurrence of \"{0}\" between index 5 and index 10 is at index {1}.", myString, myIndex);
    }


    public static void PrintIndexAndValues(Array myArray)
    {
        for (int i = myArray.GetLowerBound(0); i <= myArray.GetUpperBound(0); i++)
            Console.WriteLine("\t[{0}]:\t{1}", i, myArray.GetValue(i));
    }


    // The example displays the following output:
    //    The array contains the following values:
    //       [ 0]: the
    //       [ 1]: quick
    //       [ 2]: brown
    //       [ 3]: fox
    //       [ 4]: jumps
    //       [ 5]: over
    //       [ 6]: the
    //       [ 7]: lazy
    //       [ 8]: dog
    //       [ 9]: in
    //       [10]: the
    //       [11]: barn
    //    The first occurrence of "the" is at index 0.
    //    The first occurrence of "the" between index 4 and the end is at index 6.
    //    The first occurrence of "the" between index 7 and index 11 is at index 10.    {


    /* 
    This code produces the following output.

    The Array contains the following values:
        [0]:    the
        [1]:    quick
        [2]:    brown
        [3]:    fox
        [4]:    jumps
        [5]:    over
        [6]:    the
        [7]:    lazy
        [8]:    dog
        [9]:    in
        [10]:    the
        [11]:    barn
    The last occurrence of "the" is at index 10.
    The last occurrence of "the" between the start and index 8 is at index 6.
    The last occurrence of "the" between index 5 and index 10 is at index 10.
    */





}
//intArray:
//intArray[0] = 1
//intArray[1] = 2
//intArray[2] = 1
//intArray[3] = 3
//Array.IndexOf(intArray, 1) = 0
//Array.LastIndexOf(intArray, 1) = 2