using System;
using System.Collections.Generic;
using System.Collections;

namespace OOP_LAB_4
{
    class Program
    {
        static void Main(string[] args)
        {
            var john = new Employee(1000, "John", "Male", 23500);
            var joe = new Employee(1001, "Joe", "Male", 45330);
            var karen = new Employee(1002, "Karen", "Female", 23000);
            var linda = new Employee(1003, "Linda", "Female", 40000);
            var jack = new Employee(1004, "Jack", "Male", 15034);

            var stk = new Stack();
            stk.Push(john);
            stk.Push(joe);
            stk.Push(karen);
            stk.Push(linda);
            stk.Push(jack);

            foreach (var item in stk)
            {
                Console.WriteLine(item.ToString());
                Console.WriteLine($"Items left in stack : {stk.Count}");
                Console.WriteLine("------------------------------");
            }
            for (int i = 0; i <  5; i++)
            {
                Console.WriteLine(stk.Pop());
                Console.WriteLine($"Items left in stack : {stk.Count}");
            }
            
        }
    }
}
