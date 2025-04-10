using Microsoft.EntityFrameworkCore.Query.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabasutvecklingInlämningsuppgift
{
    public class StudentView
    {
        public StudentController Controller { get; set; }

        public StudentView(StudentController controller)
        {
            this.Controller = controller;
        }

        public void DisplayStudentMainMenu()
        {
            Console.WriteLine("1: Register a student");
            Console.WriteLine("2: Display students");
            Console.WriteLine("3: Change a student");
            Console.WriteLine("4: Delete a student");
            Console.WriteLine("5: Close program");

            Controller.MenuInputHandling(Console.ReadLine());

        }
      
        

        public (string firstName, string lastName, string city) InsertStudentValues()
        {
            Console.WriteLine("First name?");
            string firstName = Console.ReadLine();
            Console.WriteLine("Last name?");
            string lastName = Console.ReadLine();
            Console.WriteLine("City?");
            string city = Console.ReadLine();

            return (firstName, lastName, city);
        }


        public void ErrorMainMenuCheckView()
        {
            Console.WriteLine("Wanna go back to main menu? (Y/N)");
            Controller.ErrorMainMenuCheckController(Console.ReadLine());
        }

        public void DisplayMessage(string message)
        {
            Console.WriteLine(message);
        }

        public void DisplayStudentListView()
        {
            foreach (var student in Controller.DisplayStudentController())
            {
                Console.WriteLine("---------------------------------------------------------------------------------------");
                Console.WriteLine($"Förnamn: {student.FirstName}\nEfternamn: {student.LastName}\nStad: {student.City}");
            }
        }
        
        public string UpdateStudentView()
        {
            DisplayStudentListView();
            Console.WriteLine("Which student do you want to update? State name");
            return Console.ReadLine();
        }

        public string DeleteStudentView()
        {
            DisplayStudentListView();
            Console.WriteLine("Which student do you want to delete? State name");
            return Console.ReadLine();
        }

    }
}
