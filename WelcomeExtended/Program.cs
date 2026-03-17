using System;
using kaloian_37_b.Model;
using kaloian_37_b.Others;
using kaloian_37_b.View;
using kaloian_37_b.ViewModel;
using WelcomeExtended.Others;

namespace WelcomeExtended
{
    internal class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            try
            {
                User user = new User(
                    "Ivan",
                    "somepasswordtotest",
                    "KvanIvanov@gmail.com",
                    UserRolesEnum.ADMIN,
                    "121223188"
                );

                UserViewModel userViewModel = new UserViewModel(user);
                MainWindow mainWindow = new MainWindow(userViewModel);

                mainWindow.DisplayUser();
                mainWindow.Show();
                // нарочно хвърля грешка
                mainWindow.DisplayError();
            }
            catch (Exception ex)
            {
                ActionOnError log = new ActionOnError(Delegates.Log);
                log(ex.Message);
            }
            finally
            {
                Console.WriteLine("Executed in any case!");
            }
        }
    }
}