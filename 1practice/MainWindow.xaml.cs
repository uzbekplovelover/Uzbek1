using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;

namespace RandomNumberSum
{
    public partial class MainWindow : Window
    {
        private int sum = 0;
        private int count = 0;
        private int K; // переменная K для суммы

        public MainWindow()
        {
            InitializeComponent();
            K = 100; // пример значения для K
        }

        private void GenerateNumbers_Click(object sender, RoutedEventArgs e)
        {
            Random rand = new Random();

            while (sum < K)
            {
                int number = rand.Next(2, 11);
                sum += number;
                count++;
                NumbersListBox.Items.Add(number);
            }

            SumValue.Text = sum.ToString();
            CountValue.Text = count.ToString();
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void About_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Программа генерирует случайные числа в диапазоне от 2 до 10, пока их сумма не превысит заданное число K , Кудинов ИСП-34");

        }
    }
}
