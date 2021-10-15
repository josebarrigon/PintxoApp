using PintxoApp.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace PintxoApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            NavigationPage.SetHasNavigationBar(this, false);
            NavigationPage.SetHasBackButton(this, false);
            InitializeComponent();
        }

        public async void Hasi(object sender, EventArgs args)
        {
            NavigationPage IzenakPage = new NavigationPage(new GordeIzenak());
            await Navigation.PopAsync();
            await Navigation.PushAsync(IzenakPage);
        }
    }
}
