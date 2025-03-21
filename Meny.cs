using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabasutvecklingInlämningsuppgift
{
    internal class Meny
    {
        private StudentRegister StudentRegister;

        public Meny(StudentRegister studentRegister)
        {
            this.StudentRegister = studentRegister;

        }

        public void MenuDisplay()
        {
            Console.WriteLine("1: Register a student");
            Console.WriteLine("2: Change a student");
            Console.WriteLine("3: List all students");
            Console.WriteLine("4: Delete a student");
            Console.WriteLine("5: Close program");
            MenuInputHandling();

        }

        public void MenuInputHandling()
        {
            int userInput = 0;

            while (true)
            {
                if (int.TryParse(Console.ReadLine(), out int value))
                {
                    userInput = value;
                    break;
                }
                else
                {
                    Console.WriteLine("Must be an int");
                }
            }

            switch (userInput)
            {
                case 1:
                    StudentRegister.RegisterAStudent();
                    MenuDisplay();
                    break;
                case 2:
                    StudentRegister.ChangeAStudent();
                    MenuDisplay();
                    break;
                case 3:
                    StudentRegister.DisplayStudentList();
                    MenuDisplay();
                    break;
                case 4:
                    StudentRegister.DeleteStudent();
                    MenuDisplay();
                    break;
                case 5:
                    break;
            }

        }














    }
}
