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
            MenuDisplay();
        }

        public void MenuDisplay()
        {
            Console.WriteLine("1: Register a student");
            Console.WriteLine("2: Change a student");
            Console.WriteLine("3: List all students");
            StudentRegister.RegisterAStudent();


        }

        public  VerifyInput(ref )





    }
}
