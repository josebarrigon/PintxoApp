using PintxoApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.DataGrid;
using Xamarin.Forms.Xaml;

namespace PintxoApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Libreta : ContentPage
    {
        private Partida Partida;
        public Libreta(Partida partida)
        {
            NavigationPage.SetHasNavigationBar(this, false);
            NavigationPage.SetHasBackButton(this, false);
            this.Partida = partida;
            InitializeComponent();
            IniciarVista();

        }
        public void IniciarVista()
        {
            foreach(Jugador j in Partida.Jugadores)
            {
                DataGridColumn dataGridColumn = new DataGridColumn
                {
                    Title = j.Nombre,
                };
                colNombres.RemoveAll();
            }
        }
    }
}