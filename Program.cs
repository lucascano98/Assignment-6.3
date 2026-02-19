namespace Assignment_6._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Customer c1 = new Customer("John Doe", 123456789, ProblemArea.Internet);
            Customer c2 = new Customer("Jane Smith", 987654321, ProblemArea.Cable);
            Customer c3 = new Customer("Bob McGee", 135792468, ProblemArea.Other);
            Customer c4 = new Customer("Stephanie Diaz", 246813579, ProblemArea.Phone);

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
