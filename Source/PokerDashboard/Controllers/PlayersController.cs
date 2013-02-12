namespace PokerDashboard.Controllers
{
    using System.Web.Mvc;

    using Models;
    using Repository;

    public class PlayersController : Controller
    {
        public ActionResult Rating()
        {
            ViewBag.Message = "Modify this template to jump-start your ASP.NET MVC application.";

            IViewModelRepository<PlayerRating> repository = new PlayerRatingRepository();
            return View(repository.Get());
        }

        public ActionResult Player(int id)
        {
            ViewBag.Message = "Player page.";

            IModelRepository<Player> repository = new PlayerRepository();
            return View(repository.Get(id));
        }
    }
}
