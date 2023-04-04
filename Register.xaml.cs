using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
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
    /// Interaction logic for Register.xaml
    /// </summary>
    public partial class Register : Window
    {
        public Register()
        {
            InitializeComponent();
        } 

        // METHOD TO REGISTER,  MD5HASH METHOD TO CONVERT STRING PASSWPRD TO BYTE IMPLEMETATION

        private void REGISTER(object sender, RoutedEventArgs e)
        {
          
            string converter = LoginInfo.MD5Hash(pass.Password.ToString()); ;

            RegisterInfo.register(user.Text, email.Text, converter);

            Login Lgn = new Login();
            Lgn.Show();
            this.Close();
            LoginInfo.currentuser = user.Text;
            MessageBox.Show("YOU HAVE SUCESSFULLY REGISTERED","INFORMATION",MessageBoxButton.OK,MessageBoxImage.Information);
        }

        private void Back(object sender, RoutedEventArgs e)
        {
            MainWindow MW = new MainWindow();
            MW.Show();
            this.Close();
        }
    }
}
