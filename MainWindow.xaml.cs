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

namespace Log2
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
        String User = "Nikilesh05";
        String Passwrd = "123456";
        int Retry = 0;
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (User == Userid.Text && Passwrd == Pass.Password)
            {
                MessageBox.Show("You have Successfully logged in");
            }
            else
            {
                if (Retry == 0)
                {
                    MessageBoxResult msgresult = MessageBox.Show("User id and Password Mismatch Do you wish to retry Attempts Remaining : 3 " , "Error",MessageBoxButton.YesNo,MessageBoxImage.Warning);
                    if (msgresult == MessageBoxResult.Yes)
                    {
                        Retry++;
                        Userid.Clear();
                        Pass.Clear();

                    }
                }
                else if (Retry == 1)
                {
                    MessageBoxResult msgresult1 = MessageBox.Show("User id and Password Mismatch Do you wish to retry Attempts Remaining : 2" , "Error", MessageBoxButton.YesNo,MessageBoxImage.Warning);
                    if (msgresult1 == MessageBoxResult.Yes)
                    {
                        Retry++;
                        Userid.Clear();
                        Pass.Clear();
                    }
                }
                else if (Retry == 2)
                {
                    MessageBoxResult msgresult2 = MessageBox.Show("User id and Password Mismatch Do you wish to retry Attempts Remaining : 1" , "Error", MessageBoxButton.YesNo, MessageBoxImage.Warning);
                    if (msgresult2 == MessageBoxResult.Yes)
                    {
                        Retry++;
                        Userid.Clear();
                        Pass.Clear();
                    }
                }
                else if (Retry == 3)
                {
                    MessageBox.Show("Sorry you exceed your limit","Error",MessageBoxButton.OK,MessageBoxImage.Error);


                    Userid.Visibility = Visibility.Hidden;
                    Pass.Visibility = Visibility.Hidden;
                    btnlog.IsEnabled = false;
                    btnSign.IsEnabled = false;

                }
                }

                
                }
            private void Button_Click_1(object sender, RoutedEventArgs e)
            {

            }
        }
    } 
