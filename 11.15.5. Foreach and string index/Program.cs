using System;

class Class1
{
    [STAThread]
    static void Main(string[] args)
    {
        string[,,] arr1 = new string[8, 2, 5];

        for (int row = 0; row < 8; row++)
        {
            for (int col = 0; col < 2; col++)
            {
                for (int z = 0; z < 5; z++)
                    arr1[row, col, z] = row + "," + col + "," + z;
            }
        }

        int idx = 0;
        foreach (string elem in arr1)
        {
            Console.Write("indices = [ ");
            foreach (int i in GetDimensionIndices(idx, arr1))
            {
                Console.Write("{0} ", i);
            }
            Console.WriteLine("] string = {0}", elem);
            idx++;
        }
    }

    static int[] GetDimensionIndices(int flatIndex, Array array)
    {

       
        int upper0 = array.GetUpperBound(0);
         int upper1 = array.GetUpperBound(1);
         int upper2 = array.GetUpperBound(2);
  



        int[] indices = new int[array.Rank];

        int p = 1;
        for (int i = array.Rank - 1; i >= 0; i--)
        {

            int f = (int)(flatIndex / p);
            int g = (array.GetUpperBound(i) + 1);
                f = f % g;

            indices[i] = (((flatIndex / p)) % (array.GetUpperBound(i) + 1));

            if (i > 0)
            {
                p *= array.GetUpperBound(i) + 1;
            }
        }
        return indices;
    }
}