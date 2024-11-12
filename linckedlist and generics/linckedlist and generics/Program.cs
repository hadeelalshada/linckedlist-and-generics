using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linckedlist_and_generics
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new LinkedList<int>();  // Create a new linked list of type int

            while (true)  // Infinite loop for repeated user input
            {
                // Display options to the user
                Console.WriteLine("\nChoose an operation:");
                Console.WriteLine("1. Add element at the beginning");
                Console.WriteLine("2. Add element at the end");
                Console.WriteLine("3. Add element at a specific position");
                Console.WriteLine("4. Remove the first element");
                Console.WriteLine("5. Remove the last element");
                Console.WriteLine("6. Print the list");
                Console.WriteLine("7. Exit the program");

                Console.Write("Enter your choice: ");
                int choice = int.Parse(Console.ReadLine()); switch (choice)
                {
                    case 1:
                        Console.Write("Enter the element to add at the beginning: ");
                        int firstElement = int.Parse(Console.ReadLine());
                        list.AddFirst(firstElement);
                        break;

                    case 2:
                        Console.Write("Enter the element to add at the end: ");
                        int lastElement = int.Parse(Console.ReadLine());
                        list.AddLast(lastElement);
                        break;

                    case 3:
                        Console.Write("Enter the position to add the element: ");
                        int position = int.Parse(Console.ReadLine());
                        Console.Write("Enter the element to add: ");
                        int elementAtPosition = int.Parse(Console.ReadLine());
                        try
                        {
                            list.AddAt(position, elementAtPosition);
                        }
                        catch (ArgumentOutOfRangeException ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                        break;

                    case 4:
                        try
                        {
                            list.RemoveFirst();
                            Console.WriteLine("Removed the first element.");
                        }
                        catch (InvalidOperationException ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                        break;

                    case 5:
                        try
                        {
                            list.RemoveLast();
                            Console.WriteLine("Removed the last element.");
                        }
                        catch (InvalidOperationException ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                        break;

                    case 6:
                        Console.WriteLine("Current list:");
                        list.PrintList();
                        break;

                    case 7:
                        Console.WriteLine("Exiting the program.");
                        return;

                    default:
                        Console.WriteLine("Invalid choice, please try again.");
                        break;
                }
            }
        }
    }
}
    









    
   
                        
               
            
             
                
              
                
            
        

