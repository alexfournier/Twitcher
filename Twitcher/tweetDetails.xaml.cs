using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;

namespace Twitcher
{
    public partial class tweetDetails : PhoneApplicationPage
    {
        public tweetDetails()
        {
            InitializeComponent();
            menuItemList.ItemsSource = tweetList.menuData.selectedItem.Items;
            detailsTitle.Text = tweetList.menuData.selectedItem.Title;
        }
    }
}

