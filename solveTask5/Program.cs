namespace solveTask5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // TASK 1
            //int[] grades = new int[5];

            //for (int i = 0; i < grades.Length; i++)
            //{
            //    Console.WriteLine($"Enter grade grades{i+1}: ");
            //    grades[i] = int.Parse(Console.ReadLine());
            //}

            //Console.WriteLine("\nGrades entered: ");
            //foreach (int grade in grades)
            //{
            //    Console.WriteLine(grade);
            //}

            //////////

            // TASK 2
            //List<string> tasks = new List<string>();

            //for (int i = 0; i < 5; i++)
            //{
            //    Console.WriteLine($"Enter task {i+1}");
            //    string task = Console.ReadLine();
            //    tasks.Add( task );
            //}

            //Console.WriteLine("\nYour to-do list: ");
            //int number = 1;
            //foreach (string task in tasks)
            //{
            //    Console.WriteLine($"{number}. {task}");
            //    number++;
            //}

            //////////
            
            // TASK 3
            Stack<string> history = new Stack<string>();

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine($"Enter website {i+1}: ");
                string url = Console.ReadLine();
                history.Push(url);
            }

            Console.WriteLine($"\nCurrent page: {history.Peek()}");

            string leftpage = history.Pop();
            Console.WriteLine($"Pressing back... leaving {leftpage}");
            Console.WriteLine($"You land on: {history.Peek()}");

        }
    }
}
