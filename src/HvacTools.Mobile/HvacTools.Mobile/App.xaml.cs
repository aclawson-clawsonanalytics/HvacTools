﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Xamarin.Forms;
using Tools;
using Tools.Models;


namespace HvacTools.Mobile
{
    public partial class App : Application
    {
        public App()
        {
            
            InitializeComponent();
            
            MainPage = new NavigationPage(new HvacTools.Mobile.Pages.MainPage());
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
