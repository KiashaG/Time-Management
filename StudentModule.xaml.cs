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
    /// Interaction logic for StudentModule.xaml
    /// </summary>
    public partial class StudentModule : Window
    {
        public StudentModule()
        {
            InitializeComponent();
        }

        private void Add(object sender, RoutedEventArgs e)
        {
            StudentModule Stm = new StudentModule();
            Stm.Show();
            this.Close();

            ModuleInfo moduleInfo = new ModuleInfo();

            moduleInfo.setModuleCode(TxbCode.Text);
            moduleInfo.setModuleName(TxbName.Text);
            moduleInfo.setModuleCredits(double.Parse(TxbNumberOfCredits.Text));
            moduleInfo.setmoduleClassHours(double.Parse(TxbClassperWeek.Text));
            moduleInfo.setmoduleStartDate(Txbdate.Text);
            moduleInfo.setmoduleNumWeeks(double.Parse(Txbnumweek.Text));

            moduleInfo.values();


            StudentModuleInfo.studentmodule(TxbCode.Text, TxbName.Text, Convert.ToInt32(TxbNumberOfCredits.Text), Convert.ToInt32(TxbClassperWeek.Text), Convert.ToInt32(Txbnumweek.Text), Txbdate.Text);

        }

        private void Next(object sender, RoutedEventArgs e)
        {
            StudyHours Sth = new StudyHours();
            Sth.Show();
            this.Close();

            foreach (var options in ModuleInfo.ListModules)
            {
               
                MessageBox.Show("YOUR MODULE HAS BEEN ADDED"
                    + "\nName :" + options.Name
                    + "\nCode :" + options.Code
                    + "\nNumber of credits :"
                    + options.NumberOfCredits
                    + "\nNumber of weeks :"
                    + options.NumberOfWeeks
                    + "\nClass hours per week : "
                    + options.ClassHoursPerWeek
                    + "\nStart date :" + options.startDate
                    + "\nSelf study hours :" + options.selfstudyhours
                    + "\nAmount of study hours left : " + options.studyhours);
            }
        }
    }
}