using kaloian_37_b.ViewModel;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace kaloian_37_b.View
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    internal partial class MainWindow : Window
    {
        private UserViewModel _viewModel;

        public void DisplayUser()
        {
            TextBlock textBlockUser = new TextBlock();
            textBlockUser.Text = $"WELCOME\r\nUser: {UserNames}\r\n" + $"Role: {Role}\r\n" + $"Email: {UserEmail}\r\n";
            this.Content = textBlockUser;
        }

        public MainWindow(UserViewModel ViewModel)
        {
            InitializeComponent();
            _viewModel = ViewModel;


        }
        public string UserEmail
        {
            get { return _viewModel.Email ; }
        }
        public string UserNames
        {
            get { return _viewModel.Name; }
        }

        public string Role
        {
            get { return _viewModel.IsAdmin; }
        }
    } 
}