using Microsoft.EntityFrameworkCore.Storage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.WebSockets;
using System.Text;
using System.Threading.Tasks;

namespace DatabasutvecklingInlämningsuppgift
{
    internal class StudentRegister
    {
        public Meny Meny { get; set; }
        private StudentDBContext db = new StudentDBContext();
        public List<Student> StudentList = new List<Student>();


        public StudentRegister()
        {
            this.Meny = new Meny(this);
        }

        public void RegisterAStudent()
        {

            Console.WriteLine("First name?");
            string firstName = Console.ReadLine();
            Console.WriteLine("Last name?");
            string lastName = Console.ReadLine();
            Console.WriteLine("City?");
            string city = Console.ReadLine();

            Student student = new Student(firstName, lastName, city);
            db.Add(student);
            db.SaveChanges();
            Meny.MenuDisplay();
        }

        public void ChangeAStudent()
        {
            if (db.Students != null)
            {
                Console.WriteLine("Choose id of student you want to change");
                DisplayStudentList();
                int userInput = int.Parse(Console.ReadLine());
                Student selectedStudent = (Student)db.Students.Where(s => s.StudentId == userInput);

                Console.WriteLine("New first name?");
                string firstName = Console.ReadLine();
                Console.WriteLine("New last name?");
                string lastName = Console.ReadLine();
                Console.WriteLine("New city?");
                string city = Console.ReadLine();

                selectedStudent.FirstName = firstName;
                selectedStudent.LastName = lastName;
                selectedStudent.City = city;

                db.SaveChanges();
            }
            else
            {
                Console.WriteLine("Database is null");
            }

            Meny.MenuDisplay();
        }

        public void DisplayStudentList()
        {
            foreach (Student student in db.Students)
            {
                Console.WriteLine($"Id: {student.StudentId}\nFirstname: {student.FirstName}\nLastName: {student.LastName}\nCity {student.City}");
                Console.WriteLine("----------------------");
            }
        }



    }
}

