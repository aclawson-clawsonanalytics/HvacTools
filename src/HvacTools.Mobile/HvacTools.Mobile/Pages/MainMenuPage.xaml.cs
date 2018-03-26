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
        #region Member Variables        
        #endregion
        public MainMenuPage()
        {
            InitializeComponent();
        }

        public void OnServiceRecordOptionSelected(object sender, EventArgs e)
        {
            //await Navigation.PushAsync(new ServiceRecordMainPage());
            MasterDetailPage mdp = Application.Current.MainPage as MasterDetailPage;
            mdp.Detail = new ServiceRecordMainPage();
        }

        public void OnReferenceDocumentsOptionSelected(object sender, EventArgs e)
        {
            var mdp = Application.Current.MainPage as MasterDetailPage;
            mdp.Detail = new ReferenceDocumentMainPage();         
        }

        public void OnCalculationsOptionSelected(object sender, EventArgs e)
        {
            var mdp = Application.Current.MainPage as MasterDetailPage;
            mdp.Detail = new CalculationsMainPage();
        }
    }
}