﻿using BluePillApp.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BluePillApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LandingPage : ContentPage
    {
        public LandingPage()
        {
            InitializeComponent();
            BindingContext = new LandingPageViewModel(Navigation);

            //Remove the navigation bar from NavigationPage
            NavigationPage.SetHasNavigationBar(this, false);
        }
    }
}