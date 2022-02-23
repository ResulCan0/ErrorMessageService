using System.Web.Helpers;

namespace ErrorMessageService.Business.Helper
{
    public class HashingPassword
    {
        public string PassWordHash(string passWord)
        {
            string salt = Crypto.GenerateSalt();
            string pass = passWord + salt;
            string hash = Crypto.HashPassword(pass);

            return hash;
        }
    }
}
