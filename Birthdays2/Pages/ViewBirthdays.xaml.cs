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
    /// Interaction logic for ViewBirthdays.xaml
    /// </summary>
    public partial class ViewBirthdays : Page
    {
        public ViewBirthdays()
        {
            InitializeComponent();
            List<Person> personList = ListCat.CreatePersonList();
            foreach (Person person in personList)
                Date.DaysUntilBirthday(person, textbox1);
        }
    }
}
