using Application.Models;
using System.Collections.ObjectModel;

namespace Application.ViewModels
{
    class MainWindowViewModel : BaseViewModel
    {
        private ObservableCollection<ViewModelStruct> ViewModels { get; set; }

        private int SelectedIndex { get; set; }

        public ViewModelStruct SelectedViewModel
        {
            get { return ViewModels[SelectedIndex]; }
            set
            {
                ViewModels[SelectedIndex] = value;
                NotifyPropertyChanged("SelectedViewModel");
            }
        }

        public MainWindowViewModel()
        {

        }
    }
}
