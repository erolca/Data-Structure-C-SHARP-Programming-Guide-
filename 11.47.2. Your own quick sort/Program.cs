using System;
using System.Collections.Generic;

class MainClass
{
    public static void Main()
    {
        MyQuickSort<int> iSort = new MyQuickSort<int>(new int[] { 2, 1, 3 });
        iSort.Sort();

    }

}


class MyQuickSort<T> where T : IComparable
{
    T[] data;

    public MyQuickSort(T[] values)
    {
        data = values;
    }
    private void doSort(int first, int last)
    {
        if (first == last)
        {
            return;
        }
        else
        {
            int pivot = getPivotPoint(first, last);

            if (pivot > first)
                doSort(first, pivot - 1);
            if (pivot < last)
                doSort(pivot + 1, last);
        }
    }

    private int getPivotPoint(int first, int last)
    {
        int pivot = first;
        int start = first;
        int end = last;

        if (last - first >= 1)
        {
            while (end > start)
            {
                while (data[pivot].CompareTo(data[start]) >= 0 && start <= last && end > start)
                    start++;
                while (data[pivot].CompareTo(data[end]) <= 0 && end >= first && end >= start)
                    end--;
                if (end > start)
                    swap(start, end);
            }
            swap(first, end);
            doSort(first, end - 1);
        }
        return end;
    }
    private void swap(int pos1, int pos2)
    {
        T temp;

        temp = data[pos1];
        data[pos1] = data[pos2];
        data[pos2] = temp;
    }
    public void Sort()
    {
        int len = data.Length;
        if (len < 2)      // Enough to sort?
            return;
        doSort(0, data.Length - 1);
    }
}