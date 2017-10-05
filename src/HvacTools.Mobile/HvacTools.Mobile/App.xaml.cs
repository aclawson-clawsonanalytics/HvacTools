using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Xamarin.Forms;
using Tools;
using Tools.Models;
using HvacTools.Mobile.Device;
using HvacTools.Mobile.Database;


namespace HvacTools.Mobile
{
    public partial class App : Application
    {
        MobileContext ApplicationContext { get; set; }
        MobileReferenceContext ReferenceContext { get; set; }

        public App(IPathManager pathManager)
        {
                        
            InitializeComponent();
            ApplicationContext = new MobileContext(pathManager.ApplicationDatabasePath);
            ApplicationContext.Database.EnsureCreated();
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
