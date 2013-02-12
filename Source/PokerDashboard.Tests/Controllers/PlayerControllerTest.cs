namespace PokerDashboard.Tests.Controllers
{
    using System.Web.Mvc;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using PokerDashboard.Controllers;

    [TestClass]
    public class PlayerControllerTest
    {
        [TestMethod]
        public void Rating()
        {
            // Arrange
            PlayersController controller = new PlayersController();

            // Act
            ViewResult result = controller.Rating() as ViewResult;

            // Assert
            Assert.AreEqual("Modify this template to jump-start your ASP.NET MVC application.", result.ViewBag.Message);
        }
    }
}
