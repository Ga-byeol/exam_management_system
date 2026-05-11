using System.Windows;
using StudentView.LoginView;
using StudentView.ExamView;

namespace StudentView
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            MainFrame.Navigate(new LoginPage());
        }
    }
}