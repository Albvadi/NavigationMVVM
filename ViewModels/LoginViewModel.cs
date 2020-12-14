using NavigationMVVM.Common;
using NavigationMVVM.Models;
using System.Diagnostics;
using System.Windows.Input;

namespace NavigationMVVM.ViewModels
{
    public class LoginViewModel : BaseViewModel
    {
        private DataManager _DataManager;

        public ICommand LoginCmd;
        public RelayCommand DoLoginCmd { get; }


        private string _Username;
        public string Username
        {
            get => _Username;
            set
            {
                _Username = value;
                RaisePropertyChanged(null);
            }
        }

        private string _Password;
        public string Password
        {
            get => _Password;
            set
            {
                _Password = value;
                RaisePropertyChanged(null);
            }
        }

        private string _MessageInfo;
        public string MessageInfo
        {
            get => _MessageInfo;
            set
            {
                _MessageInfo = value;
                RaisePropertyChanged(null);
            }
        }

        public LoginViewModel(DataManager sharedData)
        {
            _DataManager = sharedData;
            DoLoginCmd = new RelayCommand(param => DoLogin(), canExec => (!string.IsNullOrEmpty(Username) && !string.IsNullOrEmpty(Password)));
        }

        public void DoLogin()
        {
            if (Username == "admin" && Password == "password")
            {
                _DataManager.User.Name = "Administrator";
                _DataManager.User.Mail = "admin@company.com";

                MessageInfo = "Login OK!... How to redirect??";
            }
            else
            {
                MessageInfo = "Username or Password incorrect!";
            }

        }
    }
}
