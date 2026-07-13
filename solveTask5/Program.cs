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
            //Stack<string> history = new Stack<string>();

            //for (int i = 0; i < 3; i++)
            //{
            //    Console.WriteLine($"Enter website {i+1}: ");
            //    string url = Console.ReadLine();
            //    history.Push(url);
            //}

            //Console.WriteLine($"\nCurrent page: {history.Peek()}");

            //string leftpage = history.Pop();
            //Console.WriteLine($"Pressing back... leaving {leftpage}");
            //Console.WriteLine($"You land on: {history.Peek()}");

            //////////

            // TASK 4
            //Queue<string> customers = new Queue<string>();

            //for (int i = 0; i < 3; i++)
            //{
            //    Console.WriteLine($"Enter customer {i + 1}: ");
            //    string name = Console.ReadLine();
            //    customers.Enqueue(name);
            //}

            //Console.WriteLine($"\nNext in line: {customers.Peek()}");

            //string served = customers.Dequeue();
            //Console.WriteLine($"Now serving: {served}");
            //Console.WriteLine($"Customer still waiting: {customers.Count}");

            //////////

            // TASK 5
            //int[] grades = new int[5];

            //for (int i = 0; i < grades.Length; i++)
            //{
            //    Console.Write($"Enter grade {i + 1}: ");
            //    grades[i] = int.Parse(Console.ReadLine());
            //}

            //Array.Sort(grades);

            //int sum = 0;
            //for (int i = 0; i < grades.Length; i++)
            //{
            //    sum += grades[i];
            //}

            //double average = (double)sum / grades.Length;

            //Console.WriteLine($"\nLowest grade:  {grades[0]}");
            //Console.WriteLine($"Highest grade: {grades[grades.Length - 1]}");
            //Console.WriteLine($"Average grade: {average}");

            //////////

            // TASK 6
            //List<string> shopping = new List<string>();
            //string input = "";

            //Console.WriteLine("Enter shopping items. Type 'done' to finish.");

            //while (input.ToLower() != "done")
            //{
            //    Console.Write("Item: ");
            //    input = Console.ReadLine();

            //    if (input.ToLower() != "done")
            //    {
            //        shopping.Add(input);
            //    }
            //}

            //Console.WriteLine("\nList before removal:");
            //foreach (string item in shopping)
            //{
            //    Console.WriteLine($"- {item}");
            //}

            //Console.Write("\nWhich item do you want to remove? ");
            //string toRemove = Console.ReadLine();
            //bool removed = shopping.Remove(toRemove);

            //if (removed)
            //{
            //    Console.WriteLine($"Removed: {toRemove}");
            //}
            //else
            //{
            //    Console.WriteLine($"'{toRemove}' was not found in the list.");
            //}

            //Console.WriteLine("\nList after removal:");
            //foreach (string item in shopping)
            //{
            //    Console.WriteLine($"- {item}");
            //}

            //////////

            // TASK 7
            //List<int> scores = new List<int>();

            //for (int i = 0; i < 5; i++)
            //{
            //    Console.Write($"Enter score {i + 1}: ");
            //    int score = int.Parse(Console.ReadLine());
            //    scores.Add(score);
            //}

            //scores.Sort();
            //scores.Reverse();

            //Console.WriteLine("\n=== PODIUM ===");
            //Console.WriteLine($"1st place: {scores[0]}");
            //Console.WriteLine($"2nd place: {scores[1]}");
            //Console.WriteLine($"3rd place: {scores[2]}");

            //////////

            // TASK 8
            Stack<string> actions = new Stack<string>();
            string input = "";

            Console.WriteLine("Enter your actions. Type 'stop' to finish.");

            while (input.ToLower() != "stop")
            {
                Console.Write("Action: ");
                input = Console.ReadLine();

                if (input.ToLower() != "stop")
                {
                    actions.Push(input);
                }
            }

            Console.WriteLine("\n=== UNDO ===");

            for (int i = 1; i <= 2; i++)
            {
                if (actions.Count > 0)
                {
                    string undone = actions.Pop();
                    Console.WriteLine($"Undo {i}: {undone}");
                }
                else
                {
                    Console.WriteLine($"Undo {i}: nothing left to undo.");
                }
            }

            Console.WriteLine("\nRemaining actions on the stack:");
            if (actions.Count == 0)
            {
                Console.WriteLine("(empty)");
            }
            else
            {
                foreach (string action in actions)
                {
                    Console.WriteLine($"- {action}");
                }

            }
        }
    }
}
