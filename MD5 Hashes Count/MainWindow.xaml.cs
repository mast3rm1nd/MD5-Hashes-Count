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

namespace MD5_Hashes_Count
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

        private void Button_Go_Click(object sender, RoutedEventArgs e)
        {
            int times = 1;
            string targetPassword = TextBox_Password.Text;
            string targetHash = TextBox_Hash.Text.ToLower();


            string calculatedHash = HashWorksHelper.CalculateMD5Hash(targetPassword);

            while(calculatedHash != targetHash)
            {
                  calculatedHash = HashWorksHelper.CalculateMD5Hash(calculatedHash);
                  times++;
            }

            TextBox_Times.Text = times.ToString();
            
        }
    }
}
