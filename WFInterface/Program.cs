using WFInterface;

namespace InterfaceLogin
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            DatabaseInitializer.InitializeDatabase();

            AddUser.AddUserToDatabase("testlogin", "testpassword", "Test1", "User1", true);

            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }
    }
}