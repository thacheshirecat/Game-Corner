using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using WordCounter.Controllers;
using WordCounter.Models;

namespace WordCounter.Tests
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

    [TestMethod]
    public void WordCounterIndex_ReturnsCorrectView_True()
    {
      //Arrange
      WordCounterController controller = new WordCounterController();

      //Act
      ActionResult indexView = controller.Index();

      //Assert
      Assert.IsInstanceOfType(indexView, typeof(ViewResult));
    }

    [TestMethod]
    public void CreateForm_ReturnsCorrectView_True()
    {
      //Arrange
      WordCounterController controller = new WordCounterController();

      //Act
      ActionResult indexView = controller.CreateForm();

      //Assert
      Assert.IsInstanceOfType(indexView, typeof(ViewResult));
    }

  }
}
