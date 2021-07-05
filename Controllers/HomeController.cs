using System.Linq;
using System.Web.Mvc;
using PersonalWebPage_MVC.Db.Concrete;

namespace PersonalWebPage_MVC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.About = new TblPerson().GetAll().OrderBy(a => a.ID).FirstOrDefault();
            ViewBag.Experience = new TblExperience().GetAll().OrderByDescending(a => a.ID);
            ViewBag.Education = new TblEducation().GetAll().OrderByDescending(a => a.ID);
            ViewBag.TechSkill = new TblSkill().GetAll().Where(a => a.EntryType == "tech").OrderByDescending(a => a.ID)
                .ToList();
            ViewBag.WorkSkill = new TblSkill().GetAll().Where(a => a.EntryType == "work").OrderByDescending(a => a.ID)
                .ToList();
            ViewBag.Interest = new TblInterest().GetAll();
            ViewBag.Award = new TblAward().GetAll();
            return View();
        }
    }
}