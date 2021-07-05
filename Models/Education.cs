using System.ComponentModel.DataAnnotations;

namespace PersonalWebPage_MVC.Models
{
    public class Education
    {
        [Key] public int ID { get; set; }

        public string University { get; set; }
        public string Faculty { get; set; }
        public string Department { get; set; }
        public string Date { get; set; }
    }
}