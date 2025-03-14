using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabasutvecklingInlämningsuppgift
{
    internal class StudentRegister 
    {
        private Meny Meny { get; set; }
        public List<Student> StudentList = new List<Student>();
        public StudentRegister()
        {
            this.Meny = new Meny(this);
        }

        public void RegisterAStudent(StudentDBContext db)
        {
            

            Console.WriteLine("")



            Student student = new Student();
            db.Add(student);
            db.SaveChanges();
        }

        


    }
}
