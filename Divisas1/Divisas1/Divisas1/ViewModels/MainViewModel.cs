using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Divisas1.ViewModels
{
    public class MainViewModel : INotifyPropertyChanged
    {
        #region Events
        public event PropertyChangedEventHandler PropertyChanged;
        #endregion

        #region Attributes
        private string dollars;
        private string pounds;
        private string euros;
        #endregion

        #region Properties
        public decimal Pesos { get; set; }

        public string Dollars
        {
            set
            {
                if (dollars != value)
                {
                    dollars = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Dollars"));
                }
            }
            get
            {
                return dollars;
            }
        }

        public string Pounds
        {
            set
            {
                if (pounds != value)
                {
                    pounds = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Pounds"));
                }
            }
            get
            {
                return pounds;
            }
        }

        public string Euros
        {
            set
            {
                if (euros != value)
                {
                    euros = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Euros"));
                }
            }
            get
            {
                return euros;
            }
        }
        #endregion

        #region Constructor
        public MainViewModel()
        { }
        #endregion

        #region Commands
        public ICommand ConvertCommand
        {
            get { return new RelayCommand(Convert); }
        }

        private async void Convert()
        {
            if (Pesos <= 0)
            {
                await App.Current.MainPage.DisplayAlert(
                    "Error",
                    "Debe digitar un valor en pesos",
                    "Aceptar");
                return;
            }

            Dollars = string.Format("${0:N2}", Pesos / 2915.4519M);
            Euros = string.Format("€{0:N2}", Pesos / 3249.41691M);
            Pounds = string.Format("£{0:N2}", Pesos / 3742.27405M);
        }
        #endregion

    }
}
