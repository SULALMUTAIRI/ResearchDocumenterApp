using ResearchDocumenter.Model;
using ResearchDocumenter.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ResearchDocumenter
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            this.BindingContext = this;
            InitializeComponent();
        }
       async void LogIn_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new home());
            //String pass = password.Text;
            //String uname = username.Text;

            //Task t = App.Database.GetUserAsync(uname, pass);
            //if (t.Id > 0)
            //{
            //    await Navigation.PushAsync(new home());
            //} 
        }

        async void SignUp_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new signup
            {
                BindingContext = new User()
            });
        }
    }
}
