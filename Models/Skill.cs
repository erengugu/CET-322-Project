using System.ComponentModel.DataAnnotations;

namespace PersonalWebPage_MVC.Models
{
    public class Skill
    {
        [Key] public int ID { get; set; }

        public string EntryType { get; set; }
        public string Description { get; set; }
    }
}