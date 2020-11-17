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
            if (e.Source is Button x)
            {

                switch (x.Content)
                {
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
                        var Split_Input = Input.Text.Split('-', '+', '/', '*');
                        //Kod från StackOverflow frågan: "Convert string[] to int[] in one line of code using LINQ"
                        int[] Split_InputInt = Array.ConvertAll(Split_Input, int.Parse);
                        var Split_Operators = Input.Text.Split('1', '2', '3', '4', '5', '6', '7', '8', '9', '0');
                        double output = 0;
                        foreach (var y in Split_Operators)
                        {
                            switch (y)
                            {
                                case "-":
                                    output = Split_InputInt[0] - Split_InputInt[1];
                                    break;
                                case "+":
                                    output += Split_InputInt[0] + Split_InputInt[1];
                                    break;
                                case "/":
                                    output += Split_InputInt[0] / Split_InputInt[1];
                                    break;
                                case "*":
                                    output += Split_InputInt[0] * Split_InputInt[1];
                                    break;
                            }
                        }
                        string outputstring = output.ToString();
                        Output.Text = outputstring;
                        break;
                    case "Clear":
                        Input.Text = "";
                        Output.Text = "";
                        break;
                }
            }
        }
    }
}
