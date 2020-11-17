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
            if (e.Source is Button x) {

                switch (x.Content) {
                    case "1":
                    case "2":
                    case "3":
                    case "4":
                    case "5":
                    case "6":
                    case "7":
                    case "8":
                    case "9":
                    case "0":
                    case "-":
                    case "+":
                    case "/":
                    case "*":
                        Input.Text += x.Content;
                        break;
                    case "=":
                        //Need to save the split operators
                        var Split_Input = Input.Text.Split('-', '+', '/', '*');
                        foreach (var i in Split_Input)
                        {
                            Output.Text += i;
                        }
                        break;
                    case "Clear":
                        break;
                }
            }
        }
    }
}
