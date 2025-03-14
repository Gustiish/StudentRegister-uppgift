using System;
using System.Collections.Generic;
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
            MenuInputHandling();

        }

        public void MenuInputHandling()
        {
            int userInput = Convert.ToInt32(Console.ReadLine());
            switch (userInput)
            {
                case 1:
                    StudentRegister.RegisterAStudent();
                    break;
                case 2:
                    // change a student
                    break;
                case 3:
                    StudentRegister.DisplayStudentList();
                    break;
            }

        }

        





    }
}
