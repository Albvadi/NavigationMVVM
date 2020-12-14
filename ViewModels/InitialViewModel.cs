using NavigationMVVM.Common;
using NavigationMVVM.Models;

namespace NavigationMVVM.ViewModels
{
    public class InitialViewModel : BaseViewModel
    {
        private DataManager _DataManager;

        public string UserLoggedInName
        {
            get => _DataManager.User.Name;
        }
        public int Counter
        {
            get => _DataManager.TotalCounter;
        }
        public InitialViewModel(DataManager sharedData)
        {
            _DataManager = sharedData;
        }
    }
}
