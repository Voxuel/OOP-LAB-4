using System;
using System.Collections.Generic;
using System.Collections;

namespace OOP_LAB_4
{
    class Program
    {
        static void Main(string[] args)
        {
            PartOne();
            Console.WriteLine("-------------------PART 2-----------------------");
            PartTwo();
        }
        static void PartOne()
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

            Console.WriteLine("\n\n");

            // Usese Pop() to return and remove item on top of stack.
            while (stk.Count > 0)
            {
                Console.WriteLine(stk.Pop());
                Console.WriteLine($"Items left in stack : {stk.Count}");
                Console.WriteLine("------------------------------");
            }

            // Pushes all items back to the stack after Pop()
            stk.Push(john);
            stk.Push(joe);
            stk.Push(karen);
            stk.Push(linda);
            stk.Push(jack);
            Console.WriteLine("\n\n");


            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine(stk.Peek());
                Console.WriteLine($"Items left in stack : {stk.Count}");
                Console.WriteLine("------------------------------");
            }
            if (stk.Contains(karen))
            {
                Console.WriteLine("Karen is in the stack");
            }

        }
        
        static void PartTwo()
        {
            var list = new List<Employee> { };
            var john = new Employee(1000, "John", "Male", 23500);
            var joe = new Employee(1001, "Joe", "Male", 45330);
            var karen = new Employee(1002, "Karen", "Female", 23000);
            var linda = new Employee(1003, "Linda", "Female", 40000);
            var jack = new Employee(1004, "Jack", "Male", 15034);

            list.Add(john);
            list.Add(joe);
            list.Add(karen);
            list.Add(linda);
            list.Add(jack);

            if (list.Contains(joe))
            {
                Console.WriteLine("Joe exists in the list");
            }
            else
            {
                Console.WriteLine("Joe does not exist in the list");
            }

            // Uses lambda expression to create method to specify what we are looking for 
            // as of "args => expression" model.
            Console.WriteLine("First employee in list that is male is " 
            + list.Find(x => x.Gender.Contains("Male")));

            // Use of IEnumerable to create a "temporary" listinterface of male employees as IEnumerable
            // does not load unless called in our foreach.
            IEnumerable<Employee> allMale = list.FindAll(x => x.Gender.Contains("Male"));

            Console.WriteLine("\nAll employees who are male");
            foreach (object obj in allMale)
            {
                Console.WriteLine("---------------------------------");
                Console.WriteLine(obj.ToString());
            }
        }
    }
}
