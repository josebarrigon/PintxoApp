using PintxoApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
using Xamarin.Forms.Xaml;

namespace PintxoApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class GordeIzenak : ContentPage
    {
        private int nJugadores;

        public GordeIzenak()
        {
            NavigationPage.SetHasNavigationBar(this, false);
            NavigationPage.SetHasBackButton(this, false);
            InitializeComponent();
        }

        private void picker_SelectedIndexChanged(object sender, EventArgs e)
        {
            var item = sender as Picker;
            var selectedItem = item.SelectedItem as String;
            string[] subs = selectedItem.Split(' ');
            nJugadores = Int32.Parse(subs[0]);
            string[] defaultNombres = new string[] { "Iosu", "Eneko", "Hodei", "Aritz","Xabi" };

            Nombres.Children.Clear();
            for(int i = 0; i < nJugadores; i++)
            {
                Entry nombre = new Entry
                {
                    Text = defaultNombres[i],
                    Placeholder = "Nombre Jugador " + (i + 1),
                    FontSize = 20
                };
                Nombres.Children.Add(nombre);
            }
            Button enviar = new Button
            {
                Text = "Enviar"
            };
            enviar.Clicked += GuardarNombres;
            Nombres.Children.Add(enviar);

        }
        private async void GuardarNombres(object sender, EventArgs e)
        {
            string[] names = new string[nJugadores];
            for (int i = 0; i < nJugadores; i++)
            {
                var entry = (Entry)Nombres.Children[i];
                names[i] = entry.Text;
            }
            Partida partida = new Partida(nJugadores, names);

            NavigationPage libretaPage = new NavigationPage(new Libreta(partida));
            await Navigation.PushModalAsync(libretaPage);
        }
    }
}