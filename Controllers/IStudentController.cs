using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabasutvecklingInlämningsuppgift.Controllers
{
    public interface IStudentController
    {
        public StudentDBContext db { get; set; }
        public StudentView studentView { get; set; }
        public bool IsProgramOn { get; set; }
        void UpdateStudentValues(Student student, string firstName, string lastName, string city, bool IsNew);
        void ErrorMainMenuCheckController(string userInput);
        void TerminateProgram();
        void MenuInputHandling(string userInput);
        void DeleteStudentController();
        void UpdateStudentController();
        void RegisterStudentController();
        List<Student> DisplayStudentController();
        Student CreateStudent();
        Student RetrieveStudent(string studentName);
        void DeleteStudent(Student student);



    }
}
