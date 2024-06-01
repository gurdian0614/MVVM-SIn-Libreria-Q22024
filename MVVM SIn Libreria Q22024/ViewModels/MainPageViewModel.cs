
using System.ComponentModel;
using System.Windows.Input;

namespace MVVM_SIn_Libreria_Q22024.ViewModels
{
    //INotifyPropertyChanged: Se utiliza en IU para notificar a XAML cuando las propiedades de un objeto han cambiado
    public class MainPageViewModel : INotifyPropertyChanged
    {
        // notificar el cambio de propiedad a la interfaz
        public event PropertyChangedEventHandler? PropertyChanged;

        private int _count;

        public int Count
        {
            get
            {
                return _count;
            }
            set
            {
                _count = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Count"));
            }
        }

        // Nos permite ejecutar acciones
        public ICommand IncrementarCommand => new Command(Incrementar);

        public void Incrementar()
        {
            Count++;
        }
    }
}
