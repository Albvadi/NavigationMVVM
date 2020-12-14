using NavigationMVVM.Common;
using NavigationMVVM.Models;
using System.Windows.Input;

namespace NavigationMVVM.ViewModels
{
    public class MainViewModel : BaseViewModel
    {
        public DataManager SharedData = new DataManager();

        public InitialViewModel InitialVM;
        public FirstViewModel FirstVM;
        public SecondViewModel SecondVM;
        public LoginViewModel LoginVM;

        public MainViewModel()
        {
            LoginVM = new LoginViewModel(SharedData);
            InitialVM = new InitialViewModel(SharedData);
            FirstVM = new FirstViewModel(SharedData);
            SecondVM = new SecondViewModel(SharedData);

            ActualView = InitialVM;
            //ActualView = LoginVM;
        }

        public ICommand DisplayFirstView
        {
            get
            {
                return new RelayCommand(action => ActualView = FirstVM,
              canExecute => true);
            }
        }

        public ICommand DisplaySecondView
        {
            get
            {
                return new RelayCommand(action => ActualView = SecondVM,
              canExecute => true);
            }
        }

        public ICommand DisplayInitialView
        {
            get
            {
                return new RelayCommand(action => ActualView = InitialVM,
              canExecute => true);
            }
        }
    }
}
