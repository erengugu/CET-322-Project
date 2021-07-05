using System;
using System.Data.Entity;
using PersonalWebPage_MVC.Db.Concrete;

namespace PersonalWebPage_MVC.Models
{
    public class PersonPageContext : DbContext
    {
        public PersonPageContext() : base("name=PersonalPageDBConnectionString")
        {
            //standart initializer eğer db yok ise oluşturulur başka işlem yapılmaz.
            //Database.SetInitializer<PersonPageContext>(new CreateDatabaseIfNotExists<PersonPageContext>());

            //custom initializer. eğer db oluşturulduktan sonra ilk veriler girilecekse bu yöntem kullanılabilir.
            Database.SetInitializer(new CustomDBInitializer());
        }

        public DbSet<Award> Awards { get; set; }
        public DbSet<Education> Educations { get; set; }
        public DbSet<Experience> Experiences { get; set; }
        public DbSet<Interest> Interests { get; set; }
        public DbSet<LoginInfo> LoginInfos { get; set; }
        public DbSet<Person> Persons { get; set; }

        public DbSet<Skill> Skills { get; set; }

        //özelleştirilmiş initializer
        public class CustomDBInitializer : CreateDatabaseIfNotExists<PersonPageContext>
        {
            protected override void Seed(PersonPageContext context)
            {
                var defaultPerson = new Person
                    {Name = "Ziya", Surname = "Orhan", Photo = "/Files/Images/profile-avatar.jpg"};
                context.Persons.Add(defaultPerson);
                //
                var info = new TblLoginInfo();
                var defaultLoginInfo = new LoginInfo
                {
                    UserName = "admin", Password = info.EncryptSha(info.EncryptMd5("1234")),
                    TransactionDate = DateTime.Now.ToString()
                };
                context.LoginInfos.Add(defaultLoginInfo);
                //
                context.SaveChanges();
            }
        }
    }
}