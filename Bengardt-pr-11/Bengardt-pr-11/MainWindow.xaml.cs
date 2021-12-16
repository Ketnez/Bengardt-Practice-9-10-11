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
using System.Text.RegularExpressions;

namespace Bengardt_pr_11
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
        private void FindLetters_Click(object sender, RoutedEventArgs e)
        {
            result.Items.Clear();
            string phrase = Letters.Text;
            Regex regex = new Regex(@"a(b{4,})a");
            MatchCollection match = regex.Matches(phrase);
            object[] array = new object[match.Count];
            match.CopyTo(array, 0);
            for (int i = 0; i < match.Count; i++)
            {
                _ = result.Items.Add(match[i]);
            }
        }

        private void FindLettersAndNumbers_Click(object sender, RoutedEventArgs e)
        {
            result.Items.Clear();
            string phrase = LettersAndNumbers.Text;
            Regex regex = new Regex(@"a\Db");
            MatchCollection match = regex.Matches(phrase);
            object[] array = new object[match.Count];
            match.CopyTo(array, 0);
            for (int i = 0; i < match.Count; i++)
            {
                _ = result.Items.Add(match[i]);
            }
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
