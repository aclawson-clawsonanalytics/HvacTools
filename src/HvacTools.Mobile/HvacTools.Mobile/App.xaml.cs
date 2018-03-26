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
using HvacTools.Mobile.Pages;


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
            ReferenceContext = new MobileReferenceContext(pathManager.ReferenceDatabasePath);
            
            ApplicationContext.Database.EnsureCreated();
            ReferenceContext.Database.EnsureCreated();

            MainPage = new MasterDetailPage()
            {
                Master = new MainMenuPage() { Title = "Welcome!" },
                Detail = new NavigationPage(new MainLandingPage())
            };
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
