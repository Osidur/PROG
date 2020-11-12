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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp1
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (sender is Button banana) {

                switch (banana.Content) {
                    case "3":
                    case "54":
                    case "632":
                    case "7183":
                    case "countdown":

                        break;
                    case "6":
                    case "+":
                        My_Text.Text += banana.Content;
                        break;
                    case "?":
                        string[] num_to_be_sum = My_Text.Text.Split('+');
                        int[] num_to_be_sum_int = Array.ConvertAll(num_to_be_sum, int.Parse);
                        int sum = num_to_be_sum_int.Sum();
                        string a = sum.ToString();
                        Output.Text = a;
                        break;
                    case "Clear":
                        My_Text.Text = "";
                        Output.Text = "";
                        break;
                }
            }
        }
    }
}
