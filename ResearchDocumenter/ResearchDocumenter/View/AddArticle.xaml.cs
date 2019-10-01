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
	public partial class AddArticle : ContentPage
	{
		public AddArticle ()
		{
			InitializeComponent ();
		}

        private async Task Add_Article_ClickedAsync(object sender, EventArgs e)
        {
            var articleInfo = (Article) BindingContext;
            Task t = App.Database.SaveArticleAsync(articleInfo);
            if (t.Id > 0)
            {
                await Navigation.PushAsync(new ListArticles());
            }
        }
    }
}