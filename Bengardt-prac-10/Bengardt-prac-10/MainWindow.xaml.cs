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

namespace Bengardt_prac_10
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private static readonly List<int> list = new List<int>(10);
        List<int> array = list;

        private void Find_Click(object sender, RoutedEventArgs e)
        {
            positiveNumbers.Text = array.Where(x => x % 2 == 0).Count().ToString();
            negativeNumbers.Text = array.Where(x => x % 2 != 0).Count().ToString();
        }

        private void Fill_Click(object sender, RoutedEventArgs e)
        {
            Random random = new Random();

            for (int i = 0; i < 10; i++)
            {
                array.Add(random.Next(-100, 100));
                _ = allElements.Items.Add(array[i]);
            }
        }

        private void Clear_Click(object sender, RoutedEventArgs e)
        {
            positiveNumbers.Clear();
            negativeNumbers.Clear();
            allElements.Items.Clear();
        }

       

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
