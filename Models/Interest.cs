using System.ComponentModel.DataAnnotations;

namespace PersonalWebPage_MVC.Models
{
    public class Interest
    {
        [Key] public int ID { get; set; }

        public string Description { get; set; }
    }
}