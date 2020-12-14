using NavigationMVVM.Common;
using NavigationMVVM.Models;

namespace NavigationMVVM.ViewModels
{
    public class FirstViewModel : BaseViewModel
    {
        private DataManager _DataManager;
        public int Counter
        {
            get => _DataManager.FirstCounter;
            set
            {
                _DataManager.FirstCounter = value;
                RaisePropertyChanged(null);
            }
        }
        public FirstViewModel(DataManager sharedData)
        {
            _DataManager = sharedData;
            IncrementCounterCMD = new RelayCommand(param => IncrementCounter());
        }

        public RelayCommand IncrementCounterCMD { get; }

        public void IncrementCounter()
        {
            Counter += 1;
        }
    }
}
