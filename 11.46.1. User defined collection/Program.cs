using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;


//11.46.1.	User defined collection with events

public class NotificationList<T> : Collection<T>
{
    public event EventHandler<ItemInsertedArgs<T>> ItemAdded;

    protected override void InsertItem(int index, T item)
    {
        EventHandler<ItemInsertedArgs<T>> handler = ItemAdded;
        if (handler != null)
        {
            handler(this, new ItemInsertedArgs<T>(index, item));
        }
        base.InsertItem(index, item);
    }
}

public class ItemInsertedArgs<T> : EventArgs
{
    public int Index;
    public T Item;

    public ItemInsertedArgs(int index, T item)
    {
        this.Index = index;
        this.Item = item;
    }
}

public class MainClass
{
    public static void Main()
    {

        NotificationList<int> list = new NotificationList<int>();

        list.ItemAdded += delegate (object o, ItemInsertedArgs<int> args) {
            Console.WriteLine("A new item was added to the list: {0} at index {1}", args.Item, args.Index);
        };

        for (int i = 0; i < 10; i++)
        {
            list.Add(i);
        }

    }
}
//A new item was added to the list: 0 at index 0
//A new item was added to the list: 1 at index 1
//A new item was added to the list: 2 at index 2
//A new item was added to the list: 3 at index 3
//A new item was added to the list: 4 at index 4
//A new item was added to the list: 5 at index 5
//A new item was added to the list: 6 at index 6
//A new item was added to the list: 7 at index 7
//A new item was added to the list: 8 at index 8
//A new item was added to the list: 9 at index 9