using System;
using System.Collections.Generic;

namespace QueueActivity
{
    class Program
    {
        static Queue<string> queue = new Queue<string>(5);

        public static void Main(string[] args)
        {
            bool flag = true;
            while (flag == true)
            {
                Console.WriteLine("QUEUE MENU");
                Console.WriteLine("1. Add an Element");
                Console.WriteLine("2. Remove front Element");
                Console.WriteLine("3. Search an Element");
                Console.WriteLine("4. Display Queue Elements");
                Console.WriteLine("5. Exit");
                
                Console.Write("Enter choice: ");
                try
                {
                    int choice = Convert.ToInt32(Console.ReadLine().Trim());
                    switch (choice)
                    {
                        case 1:
                            Console.Write("Enter element: ");
                            string element = Console.ReadLine();
                            AddElement(element);
                            break;
                            
                        case 2:
                            if (queue.Count != 0)
                            {
                                Console.WriteLine("Removed front element: " + queue.Dequeue());
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Queue is empty!");
                                break;
                            }
                            
                        case 3:
                            if (queue.Count != 0)
                            {
                                Console.Write("Search element: ");
                                element = Console.ReadLine();
                                SearchElement(element);
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Queue is empty!");
                                break;
                            }
                            
                        case 4:
                            DisplayElements();
                            break;
                            
                        case 5:
                            flag = false;
                            Console.WriteLine("Exiting program...");
                            break;
                        default:
                            Console.WriteLine("Enter Numbers 1-5 only");
                            break;
                    }
                    Console.WriteLine();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                }
            }
        }

        static void AddElement(string element)
        {
            if (String.IsNullOrWhiteSpace(element) == false)
            {
                element = element.Trim();
                if (queue.Count < 5)
                {
                    queue.Enqueue(element);
                    Console.WriteLine("{element} has been added to queue.");
                }
                else
                {
                    Console.WriteLine("Queue is full please remove an element first before adding.");
                    Console.WriteLine("Queue limit is 5.");
                }
            }
            else
            {
                Console.WriteLine("Input is null. invalid input.");
            }
        }

        static void SearchElement(string element)
        {
            if (String.IsNullOrWhiteSpace(element) == false)
            {
                element = element.Trim();
                if (queue.Contains(element))
                {
                    Console.WriteLine("Queue contains {element}");
                }
                else
                {
                    Console.WriteLine("Queue does not contain {element}");
                }
            }
            else
            {
                Console.WriteLine("Input is null. Invalid input");
            }
        }

        static void DisplayElements()
        {
            if (queue.Count != 0)
            {
                string s = string.Join(", ", queue);
                Console.WriteLine("Elements in queue: {s}");
                Console.WriteLine("Current queue count: {queue.Count}");
            }
            else
            {
                Console.WriteLine("Queue is empty!");
            }
        }
    }
}
