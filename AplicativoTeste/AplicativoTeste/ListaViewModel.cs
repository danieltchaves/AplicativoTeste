using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using Xamarin.Forms;

namespace AplicativoTeste
{
    public class ListaViewModel : INotifyPropertyChanged
    {

        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void NotifyPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private bool _template1;
        public bool Template1
        {
            get { return _template1; }
            set 
            { 
                _template1 = value;
                NotifyPropertyChanged("Template1");
            }
        }

        public Command MudarCommand { get; set; }

        public ListaViewModel()
        {
            Template1 = true;
            MudarCommand = new Command(executeMudar);
        }

        private void executeMudar(object obj)
        {
            Template1 = !Template1;
        }
    }
}
