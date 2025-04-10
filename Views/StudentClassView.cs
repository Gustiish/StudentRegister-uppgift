using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabasutvecklingInlämningsuppgift.Views
{
    public class StudentClassView
    {
        public StudentClassController StudentClassController {get; set;}

        public StudentClassView(StudentClassController studentClassController)
        {
            this.StudentClassController = studentClassController;
        }

        


    }
}

