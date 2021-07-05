using System.ComponentModel.DataAnnotations;

namespace PersonalWebPage_MVC.Models
{
    public class Person
    {
        [Key] public int ID { get; set; }

        public string Name { get; set; }
        public string Surname { get; set; }
        public string Address { get; set; }
        public string Mail { get; set; }
        public string Description { get; set; }
        public string Linkedin { get; set; }
        public string Github { get; set; }
        public string Twitter { get; set; }
        public string Facebook { get; set; }
        public string Youtube { get; set; }
        public string Instagram { get; set; }
        public string Photo { get; set; }
    }
}