using System;

namespace GeneralComputing.Services
{
    using GeneralComputing.Models;
    using System.Collections.Generic;
    using System.Linq;
    using System.Net.Http;
    using System.Text;
    using System.Threading.Tasks;
    public static class FirebaseConnectService
    {
        static readonly HttpClient client = new HttpClient() { BaseAddress = new Uri("https://windows-utillity-app-default-rtdb.europe-west1.firebasedatabase.app/")};
        
        
        public static async Task<bool> CreateUser(string userName, string password)
        {
            throw new NotFiniteNumberException();
        //    User test = new User()
        //    {
        //        password = password,
        //        userName = userName
        //    };

        //    var stringContent = new StringContent(test.ToString());

        //    try
        //    {

        //        HttpResponseMessage response = await client.PostAsync("users", stringContent);
        //        return response.IsSuccessStatusCode;
        //    }
        //    catch (Exception ex)
        //    {
        //        Console.WriteLine(ex.Message);
        //    }
            


        //    return false;
        }
    }
}
