using Application.Interfaces;

namespace Application.Models
{
    struct ViewModelStruct
    {
        public ViewModelProperties Properties { get; set; }
        public IVisibleViewModel ViewModel { get; set; }
    }
}
