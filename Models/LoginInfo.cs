using System.ComponentModel.DataAnnotations;

namespace PersonalWebPage_MVC.Models
{
    public class LoginInfo
    {
        [Key] public int ID { get; set; }

        public string UserName { get; set; }
        public string Password { get; set; }
        public string TransactionDate { get; set; }
    }
}