using Microsoft.EntityFrameworkCore.Storage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.WebSockets;
using System.Reflection.Metadata.Ecma335;
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

        }

        public void ChangeAStudent()
        {
            if (db.Students != null)
            {

                Console.WriteLine("Choose id of student you want to change");
                DisplayStudentList();
                if (int.TryParse(Console.ReadLine(), out int value))
                {
                    int userInput = value;
                    Student selectedStudent = db.Students.SingleOrDefault(s => s.StudentId == userInput);
                    if (selectedStudent != null)
                    {
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
                        Console.WriteLine("Invalid student id");
                    }

                }  
                else
                {
                    Console.WriteLine("Must be a string");
                }
            }
            else
            {
                Console.WriteLine("Database is null");
            }
        }

        public void DisplayStudentList()
        {
            foreach (Student student in db.Students)
            {
                Console.WriteLine($"Id: {student.StudentId}\nFirstname: {student.FirstName}\nLastName: {student.LastName}\nCity: {student.City}");
                Console.WriteLine("----------------------");
            }

        }

        public void DeleteStudent()
        {
            DisplayStudentList();
            Console.WriteLine("Choose Id of the student you want to delete");
            int userInput = Convert.ToInt32(Console.ReadLine());
            var studentToDelete = db.Students.SingleOrDefault(student => student.StudentId == userInput);
            if (studentToDelete != null)
            {
                db.Remove(studentToDelete);
                db.SaveChanges();
            }
            else
            {
                Console.WriteLine("Invalid student id");
            }

        }



    }
}

