using System;

namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedListEvent linkedList = new LinkedListEvent();

            linkedList.InsertFirst(100);
            linkedList.InsertFirst(2);
            linkedList.InsertFirst(30);
            linkedList.InsertFirst(44);
            linkedList.InsertFirst(90);

            linkedList.DeleteFirst();
            linkedList.DeleteFirst();

            linkedList.InsertLast(546);
            linkedList.InsertLast(1089);

            linkedList.DisplayList();


        }
    }
}
