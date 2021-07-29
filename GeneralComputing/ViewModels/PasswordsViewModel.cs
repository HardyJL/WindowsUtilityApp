using GeneralComputing.Commands;
using GeneralComputing.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace GeneralComputing.ViewModels
{
    public class PasswordsViewModel : BaseViewModel
    {
        public ICommand PasswordChangedCommand { get { return new RelayCommand(OnPasswordChanged); } }
        public ICommand AddPasswordCommand { get { return new RelayCommand(OnAddPasswordClicked); } }
        private ObservableCollection<PasswordModel> passwords;

        public ObservableCollection<PasswordModel> Passwords

        {
            get { return passwords; }

            set { SetProperty(ref passwords, value); }
        }
        public PasswordsViewModel()
        {
            Passwords = new ObservableCollection<PasswordModel>();
            Passwords.Add(new PasswordModel() 
            { 
                Accountname = "Test",
                ExpirationDate = DateTime.Now,
                ID = 10,
                Name = "Testpassword",
                Password = new System.Security.SecureString()
            });
            Passwords[0].Password.AppendChar('L');
            Passwords[0].Password.AppendChar('e');
            Passwords[0].Password.AppendChar('o');
            Passwords[0].Password.AppendChar('n');
        }
        private void OnPasswordChanged(object obj)
        {

        }
        private void OnAddPasswordClicked(object obj)
        {
            var pwd = Passwords[0].Password;
            //throw new NotImplementedException();
        }
    }
}
