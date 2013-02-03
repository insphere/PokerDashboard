using System.Web.Razor;

namespace PokerDashboard.Controllers
{
    using System.Collections.Generic;
    using System.Web.Mvc;

    using PokerDashboard.Models;
    using PokerDashboard.Repository;

    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Modify this template to jump-start your ASP.NET MVC application.";

            IViewModelRepository<PlayerRating> repository = new PlayerRatingRepository();
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

            IModelRepository<Player> repository = new PlayerRepository();
            return View(repository.Get(id));
        }

        public ActionResult Games()
        {
            ViewBag.Message = "Games list.";

            IViewModelRepository<GameEntry> repository = new GameEntryRepository();

            return View(repository.Get());
        }

        public ActionResult Game()
        {
            ViewBag.Message = "Game page.";

            return View(new Game());
        }
    }
}
