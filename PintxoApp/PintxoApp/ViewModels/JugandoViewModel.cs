using PintxoApp.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace PintxoApp.ViewModels
{
    public class JugandoViewModel : INotifyPropertyChanged
    {
        private List<Puntos> puntos;
        private PuntosData puntosData;
        private bool _isRefreshing;

        public List<Puntos> Puntos
        {
            get
            {
                return puntos;
            }
            set
            {
                puntos = value;
                OnPropertyChanged(nameof(Puntos));
            }
        }
        public JugandoViewModel()
        {
            puntosData = new PuntosData();
            Puntos = puntosData.GetPuntos();
            RefreshCommand = new Command(CmdRefresh);
        }
        public async void CmdRefresh()
        {
            IsRefreshing = true;
            await Task.Delay(3000);
            IsRefreshing = false;
        }

        public bool IsRefreshing
        {
            get
            {
                return _isRefreshing;
            }
            set
            {
                _isRefreshing = value;
                OnPropertyChanged(nameof(IsRefreshing));
            }
        }
        public ICommand RefreshCommand { get; set; }
        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string property)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(property));
        }
    }
}
