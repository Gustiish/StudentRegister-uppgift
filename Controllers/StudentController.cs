using DatabasutvecklingInlämningsuppgift.Controllers;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace DatabasutvecklingInlämningsuppgift
{
    public class StudentController : IStudentController
    {

        public StudentDBContext db { get; set; }
        public StudentView studentView { get; set; }
        public bool IsProgramOn { get; set; }
        public StudentController(StudentDBContext db)
        {
            this.db = db;
            this.studentView = new StudentView(this);
            this.IsProgramOn = true;
        }
        public void UpdateStudentValues(Student student, string firstName, string lastName, string city, bool IsNew)
        {
            if (!firstName.IsNullOrEmpty() || !lastName.IsNullOrEmpty() || !city.IsNullOrEmpty())
            {
                try
                {
                    student.FirstName = firstName;
                    student.LastName = lastName;
                    student.City = city;
                    if (IsNew)
                    {
                        db.Add(student);
                        db.SaveChanges();
                    }
                    else
                    {
                        db.SaveChanges();
                    }
                   
                   
                }
                catch (Exception e)
                {
                    studentView.DisplayMessage("Something went wrong");
                    studentView.ErrorMainMenuCheckView();
                }
            }
            else
            {
                studentView.DisplayMessage("Invalid values");
                studentView.ErrorMainMenuCheckView();
            }
        }

   


        public void ErrorMainMenuCheckController(string userInput)
        {
            if (userInput.ToUpper() == "Y")
            {
                studentView.DisplayStudentMainMenu();
            }
            else
            {
                TerminateProgram();
            }
        }

        public void TerminateProgram()
        {
            IsProgramOn = false;

        }


        public void MenuInputHandling(string userInput)
        {
            switch (userInput)
            {
                case "1":
                    RegisterStudentController();
                    break;
                case "2":
                    studentView.DisplayStudentListView();
                    break;
                case "3":
                    UpdateStudentController();
                    break;
                case "4":
                    DeleteStudentController();
                    break;
                case "5":
                    studentView.DisplayMessage("Program terminates");
                    TerminateProgram();
                    break;
            }
        }

        public void DeleteStudentController()
        {
            studentView.DisplayStudentListView();
            string studentToDelete = studentView.DeleteStudentView();
            Student student = RetrieveStudent(studentToDelete);
            DeleteStudent(student);
        }

        public void UpdateStudentController()
        {
            string studentToUpdate = studentView.UpdateStudentView();
            Student student = RetrieveStudent(studentToUpdate);
            var (firstName, lastName, city) = studentView.InsertStudentValues();
            UpdateStudentValues(student, firstName, lastName, city, false);
        }

        public void RegisterStudentController()
        {
            studentView.DisplayMessage("State the following for your new student");
            var (firstName, lastName, city) = studentView.InsertStudentValues();
            var student = CreateStudent();
            UpdateStudentValues(student, firstName, lastName, city, true);
        }



        public List<Student> DisplayStudentController()
        {
            return db.Students.ToList();
        }

       

        public Student CreateStudent()
        {
            Student student = new Student();
            return student;
        }

        public Student RetrieveStudent(string studentName)
        {
            try
            {
                Student student = db.Students.FirstOrDefault(s => s.FirstName == studentName);
                return student;
            }
            catch(Exception e)
            {
                studentView.DisplayMessage("That student does not exist");
                studentView.ErrorMainMenuCheckView();
                return null;
            }
           
        }

        public void DeleteStudent(Student student)
        {
            db.Remove(student);
            db.SaveChanges();
            studentView.DisplayMessage($"{student.FirstName} has been deleted from database");
        }






    }
}
