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
using Windows.UI.Xaml.Media.Animation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace Birthday
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }
        private void NavView_Loaded(object sender, RoutedEventArgs e)
        {
            NavView.SelectedItem = NavView.MenuItems[0];
        }

        private void NavView_ItemInvoked(NavigationView sender, NavigationViewItemInvokedEventArgs args)
        {
            if (args.InvokedItem != null)
            {
                switch (args.InvokedItem)
                {
                    case "Main Page":
                        this.Frame.Navigate(typeof(MainPage), null, new SuppressNavigationTransitionInfo());
                        break;

                    case "Add Birthday":
                        this.Frame.Navigate(typeof(AddBirthday), null, new SuppressNavigationTransitionInfo());
                        break;

                    case "Remove Birthday":
                        this.Frame.Navigate(typeof(RemoveBirthday), null, new SuppressNavigationTransitionInfo());
                        break;

                    case "View Birthdays":
                        this.Frame.Navigate(typeof(ViewBirthdays), null, new SuppressNavigationTransitionInfo());
                        break;
                }
            }
        }
    }
}
