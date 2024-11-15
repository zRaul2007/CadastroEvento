namespace CadastroEvento.ViewModel;

using System.ComponentModel;
using System.Runtime.CompilerServices;

public class EventoViewModel : INotifyPropertyChanged
{
    private Evento _evento;

    public Evento Evento
    {
        get => _evento;
        set
        {
            _evento = value;
            OnPropertyChanged();
        }
    }

    public EventoViewModel()
    {
        Evento = new Evento
        {
            DataInicio = DateTime.Today,
            DataTermino = DateTime.Today
        };
    }

    public event PropertyChangedEventHandler PropertyChanged;

    protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}
