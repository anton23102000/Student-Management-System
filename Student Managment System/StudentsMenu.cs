using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Managment_System
{
    public class StudentsMenu
    {
        private List<Class> Classes;

        public StudentsMenu(List<Class> classes)
        {
            Classes = classes;
        }

        public void ManageStudents()
        {
            var exit = false;
            while (!exit)
            {
                Console.WriteLine("Manage Students");
                Console.WriteLine("1. Add Student");
                Console.WriteLine("2. Remove Student");
                Console.WriteLine("3. Back to Main Menu");
                Console.Write("Enter your choice: ");
                var choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        AddStudent();
                        break;
                    case "2":
                        RemoveStudent();
                        break;
                    case "3":
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
        }

        public void AddStudent()
        {
            
                Console.WriteLine("Enter name of the Class:");
                var className = Console.ReadLine();
                var studentsClass = Classes.Find(c => c.Name == className);
                if (studentsClass == null)
                {
                    Console.WriteLine("Class not found.");
                    return;
                }

                Console.WriteLine("Enter student Name");
                string studentName = Console.ReadLine();
                Console.WriteLine("Enter student Age");
                string studentAge = Console.ReadLine();
                int STage = Convert.ToInt32(studentAge);
                int[] studentMarks = new int[4];

                Console.WriteLine("Enter mark of the Math");
                string MM = Console.ReadLine();
                int MM1 = Convert.ToInt32(MM);
                studentMarks[0] = MM1;

                Console.WriteLine("Enter mark of the English");
                string ME = Console.ReadLine();
                int ME1 = Convert.ToInt32(ME);
                studentMarks[1] = ME1;

                Console.WriteLine("Enter mark of the Biology");
                string MB = Console.ReadLine();
                int MB1 = Convert.ToInt32(MB);
                studentMarks[2] = MB1;

                Console.WriteLine("Enter mark of the Geography");
                string MG = Console.ReadLine();
                int MG1 = Convert.ToInt32(MG);
                studentMarks[3] = MG1;
                var student = new Student(studentName, STage, studentMarks);
                studentsClass.Students.Add(student);
            }

        public void RemoveStudent()
        {
            Console.Write("Enter student name to remove: ");
            var studentName = Console.ReadLine();
            var found = false;
            foreach (var schoolClass in Classes)
            {
                var student = schoolClass.Students.Find(s => s.Name == studentName);
                if (student != null)
                {
                    schoolClass.Students.Remove(student);
                    Console.WriteLine("Student removed successfully");
                    found = true;
                    break;
                }
            }

            if (!found)
            {
                Console.WriteLine("Student not found.");
            }
        }
    }
}
