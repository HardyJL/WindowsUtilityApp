using System;

namespace GeneralComputing.ViewModel
{
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Collections.Generic;
    using System.Windows.Input;
    using GeneralComputing.Commands;

    public class MainViewModel : BaseViewModel
    {
        public ICommand GeneratePasswordCommand { get { return new RelayCommand(OnGeneratePassword); } }

        private void OnGeneratePassword(object obj)
        {
            PasswordText = password(14);
        }

        private String _passwordText;

        public String PasswordText
        {
            get { return _passwordText; }

            set { SetProperty(ref _passwordText, value); }
        }

        private string password(int length)
        {
            StringBuilder SB = new StringBuilder();
            string Content = "1234567890ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvw!öäüÖÄÜß\"§$%&/()=?*#-";
            Random rnd = new Random();
            for (int i = 0; i < length; i++)
                SB.Append(Content[rnd.Next(Content.Length)]);
            return SB.ToString();
        }
    }
}