using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace HvacTools.Mobile
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            
        }

        async void OnStartClick(object sender, EventArgs e)
        {
            await DisplayAlert("Alert", "The 'Start' button was clicked!", "OK");
        }
    }
}
