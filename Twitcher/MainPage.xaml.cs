using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using Twitcher.Resources;
using Microsoft.Phone.Tasks;

namespace Twitcher
{
    public partial class MainPage : PhoneApplicationPage
    {
        // Constructor


        public MainPage()
        {
            InitializeComponent();
        }

        private void mapViewTap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            NavigationService.Navigate(new Uri("/tweetMap.xaml", UriKind.Relative));
        }
       
        private void listViewTap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            NavigationService.Navigate(new Uri("/tweetList.xaml", UriKind.Relative));
        }
        
        private void InputField_GotFocus(object sender, System.Windows.Input.GestureEventArgs e)
        {
            InputField.Text = "";
        }
        
        private void AppBarIconBtn(object sender, EventArgs e)
        {
            NavigationService.Navigate(new Uri("/AboutPage.xaml", UriKind.Relative));
        }
        
        private void closeKB(object sender, EventArgs e)
        {
            this.Focus();
        }

        private void tweetDetail(object sender, System.Windows.Input.GestureEventArgs e)
        {
            NavigationService.Navigate(new Uri("/tweetDetails.xaml", UriKind.Relative));
        }


        private void phoneTap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            PhoneCallTask phoneTask = new PhoneCallTask();
            phoneTask.DisplayName = "Art Is In";
            phoneTask.PhoneNumber = "555-5555";
            phoneTask.Show();
        }

        private void emailTap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Send Email?", "Message to support", MessageBoxButton.OKCancel);
            if (result == MessageBoxResult.OK)
            {
                // user respondid "ok"
                EmailComposeTask emailComposeTask = new EmailComposeTask();
                emailComposeTask.Subject = "Request for info";
                emailComposeTask.To = "artisin@bakery.com";
                emailComposeTask.Show();
            }
        }
    }
}