using kaloian_37_b.Model;
using kaloian_37_b.ViewModel;
using System.Configuration;
using System.Data;
using System.Windows;

namespace kaloian_37_b
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            User user1 = new User("Ivan", "somepasswordtotest", "IvanIvanov@gmail.com", "Admin", "121223188");
            UserViewModel userViewModel1 = new UserViewModel(user1);
            View.MainWindow mainWindow1 = new View.MainWindow(userViewModel1);
            mainWindow1.DisplayUser();
            mainWindow1.Show();
            base.OnStartup(e);
        }
    }

}
