using System;
using System.Collections.Generic;
using System.Collections;

namespace OOP_LAB_4
{
    // Leo F SUT22
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

            foreach (object obj in stk)
            {
                Console.WriteLine(obj.ToString());
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
            string exists = stk.Contains(karen) ? "Karen is in the stack" : "Karen is not in the stack";
            Console.WriteLine(exists);

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

            string exist = list.Contains(joe) ? "Joe exists in the list" : "Joe does not exist in the list";
            Console.WriteLine("\n" + exist);

            // Uses lambda expression to create method to specify what we are looking for 
            // as of "arg => expression" model.
            Console.WriteLine("\nFirst employee in list that is male is "
            + list.Find(x => x.Gender.Contains("Male")));
            
            var allMale = list.FindAll(x => x.Gender.Contains("Male"));
            Console.WriteLine("\nAll employees who are male");
            foreach (object obj in allMale)
            {
                Console.WriteLine("---------------------------------");
                Console.WriteLine(obj.ToString());
            }
        }
    }
}
