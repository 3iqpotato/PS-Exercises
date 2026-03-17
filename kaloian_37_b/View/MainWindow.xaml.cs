using kaloian_37_b.ViewModel;
using System;
using System.Windows;
using System.Windows.Controls;

namespace kaloian_37_b.View
{
    public partial class MainWindow : Window
    {
        private UserViewModel _viewModel;

        public MainWindow(UserViewModel viewModel)
        {
            InitializeComponent();
            _viewModel = viewModel;
        }

        public void DisplayUser()
        {
            TextBlock textBlockUser = new TextBlock();
            textBlockUser.Text =
                $"WELCOME\r\nUser: {UserNames}\r\nRole: {Role}\r\nEmail: {UserEmail}\r\n";

            this.Content = textBlockUser;
        }

        public void DisplayError()
        {
            throw new Exception("Test logger works");
        }

        public string UserEmail
        {
            get { return _viewModel.Email; }
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