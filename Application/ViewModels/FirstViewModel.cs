using Application.Interfaces;

namespace Application.ViewModels
{
    class FirstViewModel : BaseViewModel, IVisibleViewModel
    {
        public FirstViewModel(BaseViewModel Parent) : base(Parent) { }
    }
}
