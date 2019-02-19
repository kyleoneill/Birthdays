using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace Birthday
{

    public class Output
    {
        public string Name { get; set; }
        public string Birthday { get; set; }
        public string DaysRemaining { get; set; }
    }

    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class ViewBirthdays : Page
    {
        public ViewBirthdays()
        {
            this.InitializeComponent();
            var personList = DataAccess.GetPeople();

            List<Output> outputList = new List<Output>();
            foreach (Person person in personList)
            {
                string birthday = person.Birthday.ToString("MMMM dd");
                string outputDaysRemaining = GetDaysRemaining(person.Birthday, person.Name);
                Output output = new Output {Name=person.Name, Birthday=birthday, DaysRemaining=outputDaysRemaining};
                outputList.Add(output);
            }

            Output.ItemsSource = outputList;
        }

        private void HyperlinkButton_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(AddBirthday));
        }

        private void HyperlinkButton_Click_1(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(MainPage));
        }

        private void HyperlinkButton_Click_2(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(RemoveBirthday));
        }

        private string GetDaysRemaining(DateTime input, string name)
        {
            DateTime birthday = DateTime.Parse(input.Month + "/" + input.Day + "/" + DateTime.Now.Year);
            int daysRemaining = (birthday - DateTime.Now).Days;
            string output;
            if(daysRemaining > 0)
            {
                output = daysRemaining + (daysRemaining == 1 ? " day " : " days ") + "left until " + name + "'s birthday.";
            }
            else if (daysRemaining == 0)
            {
                output = $"{name}'s birthday is today.";
            }
            else
            {
                output = $"{name}'s birthday has already passed.";
            }
            return output;
        }
    }
}
