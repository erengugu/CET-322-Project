using PersonalWebPage_MVC.Db.Abstract;
using PersonalWebPage_MVC.Models;

namespace PersonalWebPage_MVC.Db.Concrete
{
    public class TblPerson : DatabaseOperations<Person, PersonPageContext>
    {
        public int ExecuteQuery(string sqlStatement)
        {
            int returnValue;
            try
            {
                using (var ctx = new PersonPageContext())
                {
                    var person = ctx.Database.ExecuteSqlCommand(sqlStatement);
                    returnValue = person;
                }

                return returnValue;
            }
            catch
            {
                returnValue = 0;
                return returnValue;
            }
        }
    }
}