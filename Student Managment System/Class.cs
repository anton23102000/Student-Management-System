using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Managment_System
{
    public class Class
    {
        public string Name { get; set; }
        public List<Student> Students = new List<Student>();

        public Class(string name)
        {
            Name = name;
            Students = new List<Student>();
        }

        public void AddStudent(string studentName, int studentAge, int[] Marks)
        {
            var student = new Student(studentName, studentAge, Marks);
            Students.Add(student);
        }
        public void RemoveStudent(string studentName)
        {  
            var student=Students.First(s => s.Name == studentName);
            if (student == null)
            {
                Console.WriteLine("Student not found");
                return;
            }
            Students.Remove(student);
        }

        public void ShowDetailsOfStudent(string studentName)
        {
            foreach (var student in Students)
            {
                if (student.Name == studentName)
                {
                    Console.WriteLine($"Name: {student.Name}, Age: {student.Age}, Average Mark: {student.AverageMark()}");
                    return;
                }
            }
            Console.WriteLine("Student not found.");
        }

        public void ShowStudents()
        {
            foreach (var student in Students)
            {
                Console.WriteLine($"Name: {student.Name}, Age: {student.Age}, Average Mark: {student.AverageMark()}, Average Marks of the Class");
            }
        }

        
    }
}
