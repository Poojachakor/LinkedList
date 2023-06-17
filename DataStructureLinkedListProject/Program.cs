using System.Collections.Generic;

namespace DataStructureLinkedListProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LinkedList list = new LinkedList();
            list.Add(56);
            list.Add(30);
            list.Add(70);
            list.popfirst();
            // list.Display();
            //list.InsertAtPerticularPosition(2, 30);
        }
    }
}