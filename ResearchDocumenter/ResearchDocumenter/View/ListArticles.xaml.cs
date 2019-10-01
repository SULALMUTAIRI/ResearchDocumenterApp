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
    public partial class ListArticles : ContentPage
    {
        private Task<List<Article>> _fetchingArticles = null;
        public ListArticles()
        {
            _fetchingArticles = App.Database.GetArticlesAsync();
            InitializeComponent();
        }
        protected override void OnAppearing() //load the data in listview
        {
            base.OnAppearing();
            SetArticleSource();
        }
        private async void SetArticleSource()
        {
            var articles = await _fetchingArticles;
            listView.ItemsSource = articles;
        }
    }
}