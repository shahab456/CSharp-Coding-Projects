using CarInsurance.Models;
using System.Linq;
using System.Web.Mvc;

namespace CarInsurance.Controllers
{
    public class AdminController : Controller
    {
        private InsuranceEntities db = new InsuranceEntities();
        // GET: Insuree
      
        public ActionResult Index()
        {
            return View(db.Insurees.ToList());
        }

       


    }
}