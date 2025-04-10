namespace DatabasutvecklingInlämningsuppgift
{
    internal class Program
    {
        static void Main(string[] args)
        {

            StudentDBContext studentDb = new StudentDBContext();

            StudentController controller = new StudentController(studentDb);


            while (controller.IsProgramOn)
            {
                controller.studentView.DisplayStudentMainMenu();
            }







        }
    }
}
