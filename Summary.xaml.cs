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
using System.Windows.Shapes;
using WpfAppPROGTask2.Models;

namespace WpfAppPROGTask2
{
    /// <summary>
    /// Interaction logic for Summary.xaml
    /// </summary>
    public partial class Summary : Window
    {
        public Summary()
        {
            InitializeComponent();
        }

        private void Back(object sender, RoutedEventArgs e)
        {
            StudyHours Sh = new StudyHours();
            Sh.Show();
            this.Close();
        }

        private void Next(object sender, RoutedEventArgs e)
        {
            MainWindow MW = new MainWindow();
            MW.Show();
            this.Close();
        }

        // CALCULATE METHOD
        public double calculate(int numcred,int numweek, int numhr)
        {
 
           return (numcred * 10 / numweek) - numhr;
          
        }

        // RETRIVEING DATA FROM STORED PROCEDURE GET STUDENT MODULE BY ID 
        private void LstSR_Loaded(object sender, RoutedEventArgs e)
        {

            SummaryInfo sum = new SummaryInfo();

            foreach (SummaryInfo useroutput in sum.summary())
            {
               
                StudentModuleInfo stm = new StudentModuleInfo();
                LogicDAL logic = new LogicDAL();
                stm = logic.GetStudentModuleByID(useroutput.Code);

                LstSR.Items.Add("\nName :  " + stm.Module_Name
                             + "\nCode :  " + stm.Code
                             + "\nNumber of credits :  "
                             + stm.Number_of_Credits
                             + "\nNumber of weeks :  "
                             + stm.Number_of_weeks
                             + "\nClass hours per week : "
                             + stm.Class_hours_per_week
                             + "\nStart date :  " + stm.start_date
                             + "\nSelf study hours :  " + calculate(stm.Number_of_Credits, 50, stm.Class_hours_per_week));
              
            }
        }
    }
}