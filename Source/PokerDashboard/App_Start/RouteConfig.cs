namespace PokerDashboard
{
    using System.Web.Mvc;
    using System.Web.Routing;

    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            // To view single Game
            routes.MapRoute(
                name: "NewGameRoute",
                url: "NewGame/",
                defaults: new { controller = "Games", action = "NewGame" });

            // To view single Game
            routes.MapRoute(
                name: "GameDefault",
                url: "Games/{id}",
                defaults: new {controller = "Games", action = "Game"});

            // To view single Player
            routes.MapRoute(
                name: "PlayersDefault",
                url: "Players/{id}",
                defaults: new {controller = "Players", action = "Player"});

            // Always show list for /Games
            routes.MapRoute(
                name: "GamesDefault",
                url: "Games/{action}/{id}",
                defaults: new {controller="Games", action = "List", id = UrlParameter.Optional});

            // Default about
            routes.MapRoute(
                name: "AboutDefault",
                url: "About/{action}",
                defaults: new {controller = "Home", action = "About"});

            // Default route and default page is Players Rating
            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Players", action = "Rating", id = UrlParameter.Optional });
        }
    }
}