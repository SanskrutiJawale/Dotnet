using System;

namespace StudentDetails
{
    class studentdetail
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of students: ");
            int numOfStudents = int.Parse(Console.ReadLine());

            int[] rollno = new int[numOfStudents];
            string[] name = new string[numOfStudents];
            string[] branch = new string[numOfStudents];
            int[] semester = new int[numOfStudents];
            string college = "Sanjivani College of Engineering";

            for (int i = 0; i < numOfStudents; i++)
            {
                Console.WriteLine($"Enter details for student {i + 1}:");
                Console.Write("Roll No: ");
                rollno[i] = int.Parse(Console.ReadLine());

                Console.Write("Name: ");
                name[i] = Console.ReadLine();

                Console.Write("Branch: ");
                branch[i] = Console.ReadLine();

                Console.Write("Semester: ");
                semester[i] = int.Parse(Console.ReadLine());

                Console.WriteLine();
            }

            Console.WriteLine("Student Details:");
            for (int i = 0; i < rollno.Length; i++)
            {
                Console.WriteLine($"Roll No: {rollno[i]}");
                Console.WriteLine($"Name: {name[i]}");
                Console.WriteLine($"Branch: {branch[i]}");
                Console.WriteLine($"Semester: {semester[i]}");
                Console.WriteLine($"College: {college}");
                Console.WriteLine();
            }
        }
    }
}