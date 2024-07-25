using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Managment_System
{
    public class MainMenu
    {
        private List<Class> _classes;
        private ClassesMenu _classesMenu;
        private StudentsMenu _studentsMenu;

        public MainMenu(List<Class> classes)
        {
            _classes = classes;
            _classesMenu = new ClassesMenu(_classes);
            _studentsMenu = new StudentsMenu(_classes);
        }

        public void ShowMainMenu()
        {
            var exit = false;
            while (!exit)
            {
                Console.WriteLine("Main Menu");
                Console.WriteLine("1. Manage Classes");
                Console.WriteLine("2. Manage Students");
                Console.WriteLine("3. Log Out");
                Console.Write("Enter your choice: ");
                var choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        _classesMenu.ShowManageClassesMenu();
                        break;
                    case "2":
                        _studentsMenu.ManageStudents();
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
    }
}
