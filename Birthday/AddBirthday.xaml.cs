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
    public sealed partial class AddBirthday : Page
    {
        public AddBirthday()
        {
            this.InitializeComponent();
            DateTime maxYear = new DateTime(2018, 12, 25, 0, 0, 0);
            Input_Date.MaxYear = new DateTimeOffset(maxYear);
        }

        private void HyperlinkButton_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(ViewBirthdays));
        }

        private void HyperlinkButton_Click_1(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(MainPage));
        }

        private void AddData(object sender, RoutedEventArgs e)
        {
            if(Input_Name.Text != "" && Input_Date.SelectedDate != null)
            {
                DateTimeOffset date = Input_Date.Date;
                String stringDate = date.Year + "-" + date.Month + "-" + date.Day + " 00:00:00";
                DataAccess.AddPerson(Input_Name.Text, DateTime.Parse(stringDate));
                Input_Name.Text = "";
                Input_Date.SelectedDate = null;
            }
        }
    }
}
