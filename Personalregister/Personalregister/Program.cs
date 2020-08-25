using System;

namespace Personalregister
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("How many employees do you want to add?");
            int n= int.Parse(Console.ReadLine());
            for (int i=0; i < n; i++)
            { 
                Console.WriteLine("Insert the name of your employee");
                string name = Console.ReadLine();
                Console.WriteLine("Insert the salary of your employee");
                int salary = int.Parse(Console.ReadLine());
                Console.WriteLine(name + " " + salary);
            }

        }
    }
}
