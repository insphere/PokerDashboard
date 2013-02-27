namespace PokerDashboard.Controllers
{
    using System.Web.Mvc;
    using Models;
    using Repository;

    public class GamesController : Controller
    {
        public ActionResult NewGame()
        {
            ViewBag.Message = "Create a new game.";

            return View();
        }

        public ActionResult List()
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
