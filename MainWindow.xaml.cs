using ClassLibraryTask1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using WpfAppPROGTask2.Models;

namespace WpfAppPROGTask2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            LogicDAL logic = new LogicDAL();
            StudentModuleInfo.studentOutput = ((List<StudentModuleInfo>)logic.GetAllStudentModules());

        }

       

        private void Register(object sender, RoutedEventArgs e)
        {
            Register reg = new Register();
           reg.Show();
            this.Close();
        }

        private void Login(object sender, RoutedEventArgs e)
        {
            Login lgn = new Login();
            lgn.Show();
            this.Close();
        }
    }
  }

