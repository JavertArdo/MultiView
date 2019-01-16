using Application.Interfaces;

namespace Application.ViewModels
{
    class SecondViewModel : BaseViewModel, IVisibleViewModel
    {
        public SecondViewModel(BaseViewModel Parent) : base(Parent) { }
    }
}
