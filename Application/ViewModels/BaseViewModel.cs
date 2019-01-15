using System.ComponentModel;

namespace Application.ViewModels
{
    abstract class BaseViewModel : INotifyPropertyChanged
    {
        protected BaseViewModel Parent { get; set; }

        protected BaseViewModel(BaseViewModel Parent)
        {
            this.Parent = Parent;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void NotifyPropertyChanged(string name)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}
