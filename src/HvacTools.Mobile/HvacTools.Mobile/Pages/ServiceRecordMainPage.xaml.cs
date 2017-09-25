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
	public partial class ServiceRecordMainPage : ContentPage
	{
		public ServiceRecordMainPage ()
		{
			InitializeComponent ();
		}

        async void OnAddServiceRecord(object sender, EventArgs e)
        {
            ServiceRecordDetailModal modal = new ServiceRecordDetailModal();
            await Navigation.PushModalAsync(modal);
        }
	}
}