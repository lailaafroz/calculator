using System;

namespace myFirstProjects
{
    class Program
    {
        static void Main(string[] args)
        {
            myStack<string> ms = new myStack<string>(3);
            ms.myPush("i");
            ms.myPush("am");
            ms.myPush("labonno");
            ms.myPush("i can");
            ms.myPush("not");
            ms.myPush("solve");
            ms.myPush("solve");
            ms.myPush("program");
            Console.WriteLine(ms.myTop());
        }
    }
}
