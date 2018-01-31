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
    /// Interaction logic for RemovePerson.xaml
    /// </summary>
    public partial class RemovePerson : Page
    {
        public RemovePerson()
        {
            InitializeComponent();
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string name = RemoveTextbox.Text;
            if(name != null)
            {
                FileManipulation.RemovePerson(name);
                RemoveTextbox.Text = "";
                MessageBoxResult nameTaken = MessageBox.Show(string.Format("{0} has been removed.", name), "Status", MessageBoxButton.OK);
            }
        }
    }
}
