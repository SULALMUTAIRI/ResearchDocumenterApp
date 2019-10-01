using ResearchDocumenter.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ResearchDocumenter.View
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class signup : ContentPage
	{
		public signup ()
		{
			InitializeComponent ();
		}

        private async Task Button_ClickedAsync(object sender, EventArgs e)
        {
            var userInfo = (User)BindingContext;
            Task t =  App.Database.SaveUserAsync(userInfo);  
            if (t.Id > 0)
            {
                await Navigation.PushAsync(new home());
            }
        }
    }
}