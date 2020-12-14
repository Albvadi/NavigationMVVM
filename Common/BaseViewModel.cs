using System.ComponentModel;

namespace NavigationMVVM.Common
{
    public class BaseViewModel : INotifyPropertyChanged
    {
        private BaseViewModel _ActualView;
        public BaseViewModel ActualView
        {
            get => _ActualView;
            set
            {
                _ActualView = value;
                RaisePropertyChanged(null);
            }
        }

        #region INotifyPropertyChanged

        public event PropertyChangedEventHandler PropertyChanged;
        public void RaisePropertyChanged(string PropertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(PropertyName));
        }

        #endregion
    }
}
