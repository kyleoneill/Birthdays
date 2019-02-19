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
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class RemoveBirthday : Page
    {
        public RemoveBirthday()
        {
            this.InitializeComponent();
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
            this.Frame.Navigate(typeof(ViewBirthdays));
        }

        private void RemoveData(object sender, RoutedEventArgs e)
        {
            Person person = DataAccess.GetPerson(Input_Name.Text);
            if(person.Name == null)
            {
                Status.Text = "Person " + Input_Name.Text + " does not exist.";
            }
            else
            {
                DataAccess.RemovePerson(Input_Name.Text);
                Status.Text = "Person " + Input_Name.Text + " has been deleted.";
            }
            Input_Name.Text = "";
        }
    }
}
