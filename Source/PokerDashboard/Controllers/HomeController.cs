using System.Collections.Generic;
using System.Web.Mvc;

namespace PokerDashboard.Controllers
{
    using PokerDashboard.Repository;

    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Modify this template to jump-start your ASP.NET MVC application.";

            IPlayerRatingRepository repository = new PlayerRatingRepository();
            return this.View(repository.Get());
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your app description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Player()
        {
            ViewBag.Message = "Player page.";

            return View();
        }
    }
}
