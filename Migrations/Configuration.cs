
using System;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;

namespace PersonalWebPage_MVC.Migrations
{
    internal sealed class Configuration : DbMigrationsConfiguration<PersonalWebPage_MVC.Models.PersonPageContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }
    } 
}