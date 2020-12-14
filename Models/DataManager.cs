using NavigationMVVM.Common;

namespace NavigationMVVM.Models
{
    public class DataManager : BaseViewModel
    {
        private int _firstCounter;
        public int FirstCounter
        {
            get => _firstCounter;
            set
            {
                _firstCounter = value;
                RaisePropertyChanged(null);
            }
        }

        private int _secondCounter;
        public int SecondCounter
        {
            get => _secondCounter;
            set
            {
                _secondCounter = value;
                RaisePropertyChanged(null);
            }
        }

        public int TotalCounter
        {
            get => FirstCounter + SecondCounter;
        }

        private User _user = new User();
        public User User
        {
            get => _user;
            set
            {
                _user = value;
                RaisePropertyChanged(null);
            }
        }
    }
}
