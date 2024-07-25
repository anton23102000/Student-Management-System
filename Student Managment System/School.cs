using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Managment_System
{
    public class School
    {
        public List<Class> Classes { get; set; }

        public void AddClass()
        {
            Console.WriteLine("Enter name of the new class:");
            var className = Console.ReadLine();
            var Nclass = new Class(className);
            Classes.Add(Nclass);
            Console.WriteLine("Class successfully added!");
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
            studentMarks[2] = MG1;
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
            
        }

        public void RemoveClass()
        {
            Console.Write("Enter class name to remove: ");
            var className = Console.ReadLine();
            var schoolClass = Classes.Find(c => c.Name == className);
            if (schoolClass != null)
            {
                Classes.Remove(schoolClass);
                Console.WriteLine("Class removed successfully.");
            }
            else
            {
                Console.WriteLine("Class not found.");
            }
        }
    }
}
