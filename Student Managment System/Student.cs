using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Managment_System
{
    public class Student
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public int[] Marks { get; set; } // Initialize Marks array

        public Student(string name, int age, int[] marks)
        {
            Name = name;
            Age = age;
            Marks = marks;
        }

        public double AverageMark()
        {
            int sum = 0;
            foreach (int mark in Marks)
            {
                sum =sum+ mark;
            }
            return (double)sum / Marks.Length;
        }

    }
}
