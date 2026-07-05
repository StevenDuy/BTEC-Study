namespace Lab3
{
    internal class StudentProgram
    {
        static void Main(string[] args)
        {
            Student student1 = new Student();
            Student student2 = new Student(1, "John", "Doe", new DateTime(2000, 1, 1));
            Console.WriteLine("Stuent 1 details:");
            student1.DisplayStudent();
            Console.WriteLine();
            Console.WriteLine("Student 2 details:");
            student2.DisplayStudent();

            Console.WriteLine();
            Console.WriteLine("Total students: " + Student.TotalStudents);

        }
    }
}
