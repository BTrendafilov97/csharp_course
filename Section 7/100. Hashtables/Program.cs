using System;
using System.Collections;
using System.Collections.Generic;

namespace ArraysSection
{
    class Program
    {
        
        static void Main(string[] args)
        {

            Hashtable studentTable = new Hashtable();
            Student studentOne = new Student(1, "Maria", 98);
            Student studentTwo = new Student(2, "Steve", 76);
            Student studentThree = new Student(3, "Greg", 60);
            Student studentFour = new Student(4, "Clara", 43);

            studentTable.Add(studentOne.ID, studentOne);
            studentTable.Add(studentTwo.ID, studentTwo);
            studentTable.Add(studentThree.ID, studentThree);
            studentTable.Add(studentFour.ID, studentFour);

            Student storedStudent1 = (Student)studentTable[studentOne.Id];

            System.Console.WriteLine(storedStudent1.Id, storedStudent1.Name, storedStudent1.GPA);
        }
        
    }

    class Student
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public float GPA { get; set; }

        public Student(int id, string name, float GPA)
        {
            this.Id = id;
            this.Name = name;
            this.GPA = GPA;
        }
        
    }
}