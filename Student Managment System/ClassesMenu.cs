using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Managment_System
{
    public class ClassesMenu
    {
        private List<Class> Classes;

        public ClassesMenu(List<Class> classes)
        {
            Classes = classes;
        }

        public void ShowManageClassesMenu()
        {
            var exit = false;
            while (!exit)
            {
                Console.WriteLine("Manage Classes");
                Console.WriteLine("1. Add Class");
                Console.WriteLine("2. Remove Class");
                Console.WriteLine("3. View Classes");
                Console.WriteLine("4. Back to Main Menu");
                Console.Write("Enter your choice: ");
                var choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        AddClass();
                        break;
                    case "2":
                        RemoveClass();
                        break;
                    case "3":
                        ViewClasses();
                        break;
                    case "4":
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
        }

        public void AddClass()
        {
            Console.Write("Enter class name: ");
            var className = Console.ReadLine();
            Classes.Add(new Class(className));
            Console.WriteLine("Class added successfully.");
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

        public void ViewClasses()
        {
            foreach (var schoolClass in Classes)
            {
                schoolClass.ShowStudents();
                Console.WriteLine($"Average Marks of the students:{AverageMarksOfStudents(schoolClass.Name)}");
            }
        }
        public double AverageMarksOfStudents(string className)
        {
            var schoolClass = Classes.Find(c => c.Name == className);
            if (schoolClass != null)
            {
                if (schoolClass.Students.Count == 0)
                {
                    Console.WriteLine($"No students found in class '{className}'.");
                    return 0;
                }

                double sum = 0;
                foreach (var student in schoolClass.Students)
                {
                    sum += student.AverageMark();
                }

                return sum / schoolClass.Students.Count;
            }
            else
            {
                Console.WriteLine($"Class '{className}' not found.");
                return 0; // Return a default value (0) in case class is not found
            }
        }

    
    }
}
