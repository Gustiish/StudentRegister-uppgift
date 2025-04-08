namespace DatabasutvecklingInlämningsuppgift
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StudentRegister studentRegister = new StudentRegister();

            AdminUser adminUser = new AdminUser("Isak", 1234);

            studentRegister.db.AdminUsers.Add(adminUser);
            studentRegister.db.SaveChanges();
            studentRegister.Meny.MenuDisplay();

            

           




        }
    }
}
