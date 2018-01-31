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

namespace Birthdays2
{
    /// <summary>
    /// Interaction logic for BirthdayHome.xaml
    /// </summary>
    public partial class BirthdayHome : Page
    {
        public BirthdayHome()
        {
            InitializeComponent();
        }

        private void button1_click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Uri("ViewBirthdays.xaml", UriKind.Relative));
        }

        private void button2_click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Uri("AddPerson.xaml", UriKind.Relative));
        }

        private void button3_click(object sender, RoutedEventArgs e)
        {

        }
    }
}
