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
	public partial class home : ContentPage
	{
		public home ()
		{
			InitializeComponent ();
		}

        private async Task List_Articles_ClickedAsync(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ListArticles());
        }

        private async Task Add_Article_ClickedAsync(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new AddArticle
            {
                BindingContext = new Article()
            });
        }

        private async Task Serach_Articles_ClickedAsync(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new SearchArticles());
        }

        private void Sign_Out_Clicked(object sender, EventArgs e)
        {

        }
    }
}