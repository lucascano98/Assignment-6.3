namespace Assignment_6._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Customer c1 = new Customer("John Doe", 1234567890, ProblemArea.Internet);
            Customer c2 = new Customer("Jane Smith", 9876543210, ProblemArea.Cable);
            Customer c3 = new Customer("Bob McGee", 1357924680, ProblemArea.Other);
            Customer c4 = new Customer("Stephanie Diaz", 2468135790, ProblemArea.Phone);

            Queue queue = new Queue();
            queue.Enqueue(c1);
            queue.Enqueue(c2);
            Console.WriteLine("Added two customers to the queue:");
            queue.Display();
            queue.Enqueue(c3);
            queue.Enqueue(c4);
            Console.WriteLine("Added another two customers to the queue:");
            queue.Display();
            Console.WriteLine();

            Console.WriteLine("Press any button to begin attending customers...");
            Console.ReadKey();

            while (queue.Size() != 0)
            {
                Console.Clear();
                Console.WriteLine("Now Helping:");
                queue.Dequeue();
                Console.WriteLine();
                if (queue.Size() >= 0)
                {
                    Console.WriteLine("Press Q to quit, or any other key to continue...");
                    if (Console.ReadKey(intercept: true).Key == ConsoleKey.Q)
                        break;
                }
            }
            Console.Clear();
            Console.WriteLine("All customers have been helped!");
        }
    }
}
