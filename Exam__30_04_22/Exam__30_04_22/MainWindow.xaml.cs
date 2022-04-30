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

namespace Exam__30_04_22
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    array[i, j] = rand.Next(-20, 20);
                    firstTextBox.Text += array[i, j] + " ";
                }
                firstTextBox.Text += "\n";

            }
        }
        Random rand = new Random();
        int n = 10;
        int m = 10;
        int[,] array = new int[10, 10];

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            lastTextBox.Text = " ";
            for (int i = 0; i < array.GetLength(0); i++)
            {
                int count = 0;
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (array[i, j] < 0) count++;
                    if (count == 3)
                    {
                        int divider = j + 1;
                        while (divider < array.GetLength(1))
                        {
                            int max = divider;
                            for (int t = divider; t < array.GetLength(1); t++)
                            {
                                if (array[i, t] < array[i, max]) max = t;
                            }
                            if (max != divider)
                            {
                                int tmp = array[i, max];
                                array[i, max] = array[i, divider];
                                array[i, divider] = tmp;
                            }
                            divider++;
                        }
                    }
                }
            }


            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    lastTextBox.Text += array[i, j] + " ";
                }
                lastTextBox.Text += "\n";
            }

        }
    }
}
