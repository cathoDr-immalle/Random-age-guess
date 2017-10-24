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

namespace H6_Random
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Random ageGuesser = new Random();
        private int tries = 0;

        public MainWindow()
        {
            InitializeComponent();

            GuessLabel.Content = Convert.ToString(ageGuesser.Next(5, 110));
        }

        private void CorrectKnop_Click(object sender, RoutedEventArgs e)
        {
            tries = tries + 1;
            MessageBox.Show("Number of tries was: " + tries);
            tries = 0;
            GuessLabel.Content = Convert.ToString(ageGuesser.Next(5, 110));
        }

        private void WrongKnop_Click(object sender, RoutedEventArgs e)
        {
            GuessLabel.Content = Convert.ToString(ageGuesser.Next(5, 110));
            tries = tries + 1;
        }
    }
}
