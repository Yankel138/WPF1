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

namespace WPF1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        static string text = "";
        static double a = 0;
        static double b = 0;
        static string operation = "";
        static bool first = true;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (first)
            {
                textBlock.Text = "";
                first = false;
            }
            text += (sender as Button).Content;
            textBlock.Text += (sender as Button).Content;
        }

        private void Button_Click_Oper(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                if (text != "")
                {
                    a = Convert.ToDouble(text);
                }
                first = false;
                text = "";
            }
            else
            {
                Button_Click_Ravno(sender, e);
            }
            textBlock.Text += (sender as Button).Content;
            operation = (string)(sender as Button).Content;

        }

        private void Button_Click_Clear(object sender, RoutedEventArgs e)
        {
            a = 0;
            b = 0;
            text = "";
            operation = "";
            textBlock.Text = "0";
            first = true;
        }

        private void Button_Click_Ravno(object sender, RoutedEventArgs e)
        {
            b = Convert.ToDouble(text);
            text = "";
            switch (operation)
            {
                case "+":
                    a += b;
                    break;
                case "-":
                    a -= b;
                    break;
                case "*":
                    a *= b;
                    break;
                case "/":
                    a /= b;
                    break;
            }
            textBlock.Text = a.ToString();
            operation = "";
            first = true;
        }
    }
}
