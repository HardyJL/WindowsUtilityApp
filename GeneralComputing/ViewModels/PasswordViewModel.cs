using System;

namespace GeneralComputing.ViewModels
{
    using GeneralComputing.Commands;
    using GeneralComputing.Models;
    using GeneralComputing.Services;
    using Newtonsoft.Json;
    using System.Net;
    using System.Net.Http;
    using System.Security;
    using System.Text;
    using System.Threading.Tasks;
    using System.Windows.Input;

    public class PasswordViewModel : BaseViewModel
    {
        public ICommand GeneratePasswordCommand { get { return new RelayCommand(OnGeneratePassword); } }
        public ICommand CreateUserCommand { get { return new RelayCommand(OnCreateUser); } }

        private void OnCreateUser(object obj)
        {
            APIService api = new APIService();
            User usr = new User() { userName = UserName, password = PasswordText };

            if (!string.IsNullOrEmpty(UserName) && !string.IsNullOrEmpty(PasswordText))
            {
                var requestmessage = new HttpRequestMessage(HttpMethod.Post, "user.json")
                {
                    Content = new StringContent(JsonConvert.SerializeObject(usr.GetToken()), Encoding.UTF8, "application/json")
                };

                Task.Run(async () => { await api.SendAsync<SecureString>(requestmessage); });
            }
        }

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

        private string _userName;

        public string UserName
        {
            get { return _userName; }
            set
            {
                SetProperty(ref _userName, value);
            }
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