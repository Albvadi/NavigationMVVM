using NavigationMVVM.Common;
using NavigationMVVM.Models;

namespace NavigationMVVM.ViewModels
{
    public class SecondViewModel : BaseViewModel
    {
        private DataManager _DataManager;
        public int Counter
        {
            get => _DataManager.SecondCounter;
            set
            {
                _DataManager.SecondCounter = value;
                RaisePropertyChanged(null);
            }
        }
        public SecondViewModel(DataManager sharedData)
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
