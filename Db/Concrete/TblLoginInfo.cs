using System.Security.Cryptography;
using System.Text;
using PersonalWebPage_MVC.Db.Abstract;
using PersonalWebPage_MVC.Models;

namespace PersonalWebPage_MVC.Db.Concrete
{
    public class TblLoginInfo : DatabaseOperations<LoginInfo, PersonPageContext>
    {
        public static int x;

        public string EncryptSha(string text, int repeatCount = 11)
        {
            try
            {
                x++;
                SHA512 sha = new SHA512CryptoServiceProvider();
                var shaAsByte = sha.ComputeHash(Encoding.UTF8.GetBytes(text));
                var sb = new StringBuilder();
                foreach (var item in shaAsByte) sb.Append(item.ToString("x2"));
                if (x <= repeatCount) EncryptSha(sb.ToString(), repeatCount);
                return sb.ToString();
            }
            catch
            {
                return "";
            }
        }

        public string EncryptMd5(string text, int repeatCount = 11)
        {
            try
            {
                x++;
                MD5 md5 = new MD5CryptoServiceProvider();
                var shaAsByte = md5.ComputeHash(Encoding.UTF8.GetBytes(text));
                var sb = new StringBuilder();
                foreach (var item in shaAsByte) sb.Append(item.ToString("x2"));
                if (x <= repeatCount) EncryptMd5(sb.ToString(), repeatCount);
                return sb.ToString();
            }
            catch
            {
                return "";
            }
        }
    }
}