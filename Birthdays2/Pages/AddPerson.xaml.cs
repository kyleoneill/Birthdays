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
    /// Interaction logic for AddPerson.xaml
    /// </summary>
    public partial class AddPerson : Page
    {
        public AddPerson()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, RoutedEventArgs e)
        {
            string name = text1.Text;
            string date = text2.Text;
            if (name != null && date != null)
            {
                string[] birthdays = FileManipulation.ReadFile();
                string fileInfo = name + ',' + date;
                bool nameExists = ListCat.checkIfNameExists(name);
                if(nameExists)
                {
                    text1.Text = "";
                    text2.Text = "";
                    MessageBoxResult nameTaken = MessageBox.Show("Name already exists.", "Error", MessageBoxButton.OK);
                }
                else
                {
                    FileManipulation.WriteToFile(fileInfo);
                    text1.Text = "";
                    text2.Text = "";
                }
            }
        }
    }
}
