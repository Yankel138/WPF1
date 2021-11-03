﻿using System;
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
        static double c = 0;
        static string operation;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            text += (sender as Button).Content;
        }

        private void DataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Button1_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_oper(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                a = Convert.ToDouble(text);
            }
            else
            {

                b = Convert.ToDouble(text);
            }
            operation = (string)(sender as Button).Content;
            
        }

        private void Button_Click_Clear(object sender, RoutedEventArgs e)
        {
            a = 0;
            b = 0;
            c = 0;
            text = "";
            operation = "";
            textBlock.Text = "";
        }

        private void Button_Click_ravno(object sender, RoutedEventArgs e)
        {
            switch (operation)
            {
                case "+":
                    c = a + b;
                    break;
                case "-":
                    c = a - b;
                    break;
                case "*":
                    c = a * b;
                    break;
                case "/":
                    c = a / b;
                    break;
            }
        }

       
    }
}