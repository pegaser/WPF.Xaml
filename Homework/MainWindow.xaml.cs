﻿using System;
using System.Windows;
using System.Windows.Input;
using System.Xml.Linq;

namespace Homework
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
        private void btnAswer_Click(object sender, RoutedEventArgs e)
        {
            if (String.IsNullOrEmpty(txtQuestion.Text))
            {
                MessageBox.Show("Pregunta algo antes.");
            }
            else
            {
                this.Cursor = Cursors.Wait;
                System.Threading.Thread.Sleep(TimeSpan.FromSeconds(3));
                Random random = new Random();
                txtAnswer.Text = random.Next(0, 2) == 0 ? "No" : "Si";
                this.Cursor = null;
            }
        }
    }
}
