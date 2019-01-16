using Application.Models;
using System;
using System.Collections.ObjectModel;
using System.Windows.Threading;

namespace Application.ViewModels
{
    class MainWindowViewModel : BaseViewModel
    {
        private DispatcherTimer timer;

        private ObservableCollection<ViewModelStruct> ViewModels { get; set; }

        private int SelectedIndex { get; set; }

        public bool ContentChanged { get; set; }

        public ViewModelStruct SelectedViewModel
        {
            get { return ViewModels[SelectedIndex]; }
            set
            {
                ViewModels[SelectedIndex] = value;
                NotifyPropertyChanged(nameof(SelectedViewModel));
            }
        }

        public MainWindowViewModel() : base(null)
        {
            ViewModels = new ObservableCollection<ViewModelStruct>()
            {
                new ViewModelStruct()
                {
                    Properties = new ViewModelProperties()
                    {
                        Title = "First"
                    },
                    ViewModel = new FirstViewModel(this)
                },
                new ViewModelStruct()
                {
                    Properties = new ViewModelProperties()
                    {
                        Title = "Second"
                    },
                    ViewModel = new SecondViewModel(this)
                }
            };

            SelectedIndex = 0;
            ContentChanged = true;

            timer = new DispatcherTimer();
            timer.Interval = new TimeSpan(0, 0, 5);
            timer.Tick += new EventHandler(SwitchView);
            timer.Start();
        }

        private void SwitchView(object state, EventArgs e)
        {
            ContentChanged = false;
            NotifyPropertyChanged(nameof(ContentChanged));

            SelectedIndex = (SelectedIndex + 1) % 2;
            NotifyPropertyChanged(nameof(SelectedViewModel));

            ContentChanged = true;
            NotifyPropertyChanged(nameof(ContentChanged));
        }
    }
}
