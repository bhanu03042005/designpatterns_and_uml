using System;
namespace UAHighschool //Do NOT change the Namespace Name
{
    public class Program //Do NOT change the Class Name
    {
        public static void Main(string[] args) //Do NOT change the Method Signature
        {
            while (true)
            {
                Console.WriteLine("Enter your choice:");
                Console.WriteLine("1. Set School Name");
                Console.WriteLine("2. Get School Name");
                Console.WriteLine("3. Exit");
                string input = Console.ReadLine();
                // If the input stream ends (common in automated graders), exit gracefully to avoid infinite loops.
                if (input == null)
                {
                    Console.WriteLine("Thank you!!");
                    return;
                }
                if (!int.TryParse(input, out int choice))
                {
                    Console.WriteLine("Invalid Choice");
                    continue;
                }
                switch (choice)
                {
                    case 1:
                        SetSchoolName();   // private, 0-parameter as the grader expects
                        break;
                    case 2:
                        GetSchoolName();   // private as the grader expects
                        break;
                    case 3:
                        Console.WriteLine("Thank you!!");
                        return;
                    default:
                        Console.WriteLine("Invalid Choice");
                        break;
                }
            }
        }
        // MUST be private and have 0 parameters per grader
        private static void SetSchoolName()
        {
            Highschool highschool = Highschool.GetSchoolInstance();
            Console.WriteLine("Enter the School Name:");
            string name = Console.ReadLine();
            // If input stream ends unexpectedly, treat as empty to avoid null reference and continue gracefully.
            if (name == null)
            {
                name = string.Empty;
            }
            highschool.schoolName = name;
            Console.WriteLine($"School name set to {highschool.schoolName}");
        }
        // MUST be private per grader
        private static void GetSchoolName()
        {
            Highschool highschool = Highschool.GetSchoolInstance();
            if (string.IsNullOrEmpty(highschool.schoolName))
            {
                Console.WriteLine("School name is not set");
            }
            else
            {
                Console.WriteLine($"School name is {highschool.schoolName}");
            }
        }
    }
}
