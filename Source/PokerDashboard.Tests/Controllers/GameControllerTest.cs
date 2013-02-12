namespace PokerDashboard.Tests.Controllers
{
    using System.Web.Mvc;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using PokerDashboard.Controllers;

    [TestClass]
    public class GameControllerTest
    {
        [TestMethod]
        public void Games()
        {
            // Arrange
            GamesController controller = new GamesController();

            // Act
            ViewResult result = controller.List() as ViewResult;

            // Assert
            Assert.AreEqual("Modify this template to jump-start your ASP.NET MVC application.", result.ViewBag.Message);
        }
    }
}
