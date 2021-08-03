using GeneralComputing.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace GeneralComputing.ViewModels
{
    public class PasswordDetailsViewModel : BaseViewModel
    {
        public ICommand CloseDialogCommand { get { return new RelayCommand(OnCloseDialogClicked); } }
        public ICommand SavePasswordCommand { get { return new RelayCommand(OnSavePasswordClicked); } }
        private PasswordDetailsWindow window;
        private string name;
        public string Name
        {
            get { return name; }
            set { SetProperty(ref name, value); }
        }
        private string accountname;
        public string Accountname
        {
            get { return accountname; }
            set { SetProperty(ref accountname, value); }
        }
        private string comment;
        public string Comment
        {
            get { return comment; }
            set { SetProperty(ref comment, value); }
        }
        private DateTime expirationDate = DateTime.Now;
        public DateTime ExpirationDate
        {
            get { return expirationDate; }
            set { SetProperty(ref expirationDate, value); }
        }
        public PasswordDetailsViewModel(PasswordDetailsWindow window)
        {
            this.window = window;
        }
        private void OnCloseDialogClicked(object obj)
        {
            window.DialogResult = false;
            window.Close();
        }
        private void OnSavePasswordClicked(object obj)
        {
            window.DialogResult = true;
            window.Close();
        }
    }
}