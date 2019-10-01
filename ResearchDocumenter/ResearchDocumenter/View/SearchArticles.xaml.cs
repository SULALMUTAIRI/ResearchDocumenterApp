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
	public partial class SearchArticles : ContentPage
	{
		public SearchArticles ()
		{
            _fetchingArticles = App.Database.GetArticlesByTextAsync();
            InitializeComponent();
        }

        private async Task Search_ClickedAsync(object sender, EventArgs e)
        {
            var articles = await _fetchingArticles;
            if (sText.Text.Trim().Length > 0)
            {
                listView.ItemsSource = articles.FindAll(a => a.Title.ToLower().Contains(sText.Text)).ToList<Article>();
            }
            else
            {
                listView.ItemsSource = articles;
            }
        }
        private Task<List<Article>> _fetchingArticles = null;  
        private async void SetArticleSource()
        {
            var articles = await _fetchingArticles;
            listView.ItemsSource = articles;
        }
    }
}