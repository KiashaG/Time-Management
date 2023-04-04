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
    /// Interaction logic for StudyHours.xaml
    /// </summary>
    public partial class StudyHours : Window
    {
        public StudyHours()
        {
            InitializeComponent();
        }

        private void Calculate(object sender, RoutedEventArgs e)
        {
            ModuleInfo moduleInfo = new ModuleInfo();

            int numcred, numweek, numhr;
            double selfstudyhours;
            numcred = Convert.ToInt32(TxbNumofcredits.Text);
            numweek = Convert.ToInt32(TxbNumofweeks.Text);
            numhr = Convert.ToInt32(TxbClasshoursperweek.Text);

            selfstudyhours = (numcred * 10 / numweek) - numhr;
            LblSelfstudyhoursperweek.Content = "Self Study Hours Per Week : " + selfstudyhours;


          //  StudyHoursInfo.studyhours(TxbmoduleStudied.Text, Convert.ToInt32(TxbNumofcredits.Text), Convert.ToInt32(TxbClasshoursperweek.Text), TxbDateStudied.Text, Convert.ToInt32(TxbNumofweeks.Text));

        }



        private void Back(object sender, RoutedEventArgs e)
        {
            StudentModule Stm = new StudentModule();
            Stm.Show();
            this.Close();
        }


        private void Next(object sender, RoutedEventArgs e)
        {
            Summary Sum = new Summary();
            Sum.Show();
            this.Close();  

        }
    }
}
