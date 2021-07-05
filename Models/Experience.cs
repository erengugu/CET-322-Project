using System.ComponentModel.DataAnnotations;

namespace PersonalWebPage_MVC.Models
{
    public class Experience
    {
        [Key] public int ID { get; set; }

        public string Corporation { get; set; }
        public string Position { get; set; }
        public string Date { get; set; }
        public string Description { get; set; }
    }
}