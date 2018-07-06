using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using GameCorner.Controllers;
using GameCorner.Models;

namespace GameCorner.Tests
{
  [TestClass]
  public class HomeControllerTest
  {
    [TestMethod]
    public void HomeIndex_ReturnsCorrectView_True()
    {
      //Arrange
      HomeController controller = new HomeController();

      //Act
      ActionResult indexView = controller.Index();

      //Assert
      Assert.IsInstanceOfType(indexView, typeof(ViewResult));
    }
  }
}
