using System.Collections.Generic;
using PokerDashboard.Repository;
using System.Web.Mvc;
using PokerDashboard.Models;

namespace PokerDashboard.Controllers
{
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

        public ActionResult Player(int id)
        {
            ViewBag.Message = "Player page.";

            IPlayerRepository repository = new PlayerRepository();
            return View(repository.Get(id));
        }

        public ActionResult Games()
        {
            ViewBag.Message = "Games list.";

            return View(new List<GameEntry>());
        }
    }
}
