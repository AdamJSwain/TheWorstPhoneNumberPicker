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

namespace TheWorstPhoneNumberPicker
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        

        public MainWindow()
        {
            InitializeComponent();
            
        }
        
        private void sldNumber_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            var rawNumber = Convert.ToInt64(sldNumber.Value);
            var PhoneNumber = String.Format("{0:(###) ###-####}", rawNumber);
            lblNumber.Content = PhoneNumber;
        }

        private void chkBoxAdvanced_Checked(object sender, RoutedEventArgs e)
        {
            if (chkBoxAdvanced.IsChecked == true)
            {
                sldNumber.Width = 1500;
            }
            else if (chkBoxAdvanced.IsChecked == false)
            {
                sldNumber.Width = 199;
            }
            else
            {
                MessageBox.Show("Lmao its broken");
            }
            
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show( "Your phone number is: " + lblNumber.Content.ToString());
        }

        private void btnPlus_Click(object sender, RoutedEventArgs e)
        {
            sldNumber.Value++;
        }

        private void btnMinus_Click(object sender, RoutedEventArgs e)
        {
            sldNumber.Value--;  
        }
    }
}
