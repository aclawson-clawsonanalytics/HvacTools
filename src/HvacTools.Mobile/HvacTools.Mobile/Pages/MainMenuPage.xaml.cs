using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HvacTools.Mobile.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainMenuPage : ContentPage
    {
        public MainMenuPage()
        {
            InitializeComponent();
        }

        async void OnServiceRecordOptionSelected(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ServiceRecordMainPage());
        }

        async void OnReferenceDocumentsOptionSelected(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ReferenceDocumentMainPage());
        }

        async void OnCalculationsOptionSelected(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new CalculationsMainPage());
        }
    }
}