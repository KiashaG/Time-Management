using ClassLibraryTask1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using WpfAppPROGTask2.Models;

namespace WpfAppPROGTask2
{
    /// <summary>
    /// Interaction logic for Login.xaml
    /// </summary>
    public partial class Login : Window
    {
        public Login()
        {
            InitializeComponent();
        }

        // METHOD TO CHECK USER NAME AND PASSWORD UPON LOGIN
        private void LOGIN(object sender, RoutedEventArgs e)
        {
            if (LoginInfo.login(user.Text, pass.Password))
            {
                StudentModule Stm = new StudentModule();
                Stm.Show();
                this.Close();
            }

            login.IsEnabled = false;
            MultiThreading();
            login.IsEnabled = true;

        }

    

        private void Back(object sender, RoutedEventArgs e)
        {
            MainWindow MW = new MainWindow();
            MW.Show();
            this.Close();
        }

        public void MultiThreading()
        {
            Thread.Sleep(2000);
        }
    }
}
