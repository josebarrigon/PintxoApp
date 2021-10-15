using PintxoApp.Models;
using PintxoApp.ViewModels;
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
        public JugandoViewModel jugandoViewModel;
        public Libreta(Partida partida)
        {
            Partida = partida;
            SetValue(NavigationPage.HasNavigationBarProperty, false);
            SetValue(NavigationPage.HasBackButtonProperty, false);

            InitializeComponent();
            jugandoViewModel = new JugandoViewModel();
            BindingContext = jugandoViewModel;
            IniciarVista();

        }
        public void IniciarVista()
        {
            ColumnCollection listaColumnas = new ColumnCollection();

            listaColumnas.Add(new DataGridColumn { Title = "#", PropertyName = "Ronda" });
            foreach (Jugador j in Partida.Jugadores)
            {
                listaColumnas.Add(new DataGridColumn { Title = j.Nombre, PropertyName = "PuntosJ" + (j.Index+1)});
            }

            cDataGrid.Columns = listaColumnas;
            cDataGrid.HeaderLabelStyle = headerStyle;
            cDataGrid.ActiveRowColor = Color.White;

            grid.Children.Add(cDataGrid);

            cDataGrid.RowsBackgroundColorPalette = pale;

            jugandoViewModel.Puntos.Add(new Puntos { Ronda = "0", PuntosJ1 = 0, PuntosJ2 = 0, PuntosJ3 = 0, PuntosJ4 = 0, PuntosJ5 = 0 });
            grid.Children.Clear();
            grid.Children.Add(cDataGrid);
        }



    }
}