namespace solveTask5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // TASK 1
            int[] grades = new int[5];

            for (int i = 0; i < grades.Length; i++)
            {
                Console.WriteLine($"Enter grade grades{i+1}: ");
                grades[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("\nGrades entered: ");
            foreach (int grade in grades)
            {
                Console.WriteLine(grade);
            }
        }
    }
}
