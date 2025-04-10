using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabasutvecklingInlämningsuppgift.Views
{
    public class MainView
    {
        public MainController mainController { get; set; }
        public StudentView StudentView { get; set; }
        public StudentClassView StudentClassView { get; set; }

        public MainView(MainController main)
        {
            this.mainController = main;
        }

    }
}
