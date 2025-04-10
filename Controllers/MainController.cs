using DatabasutvecklingInlämningsuppgift.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabasutvecklingInlämningsuppgift.Views
{
    public class MainController
    {
        public MainView mainView { get; set; }
        public StudentClassController StudentClassController { get; set; }
        private readonly IStudentController _studentController;
 
        public MainController(IStudentController studentController)
        {
            _studentController = studentController;
        }

        public void DisplayStudentMenu()
        {
            _studentController.studentView.DisplayStudentMainMenu();
        }




    }
}
