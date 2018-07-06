using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using GameCorner.Controllers;
using GameCorner.Models;

namespace GameCorner.Tests
{
  [TestClass]
  public class ScrabbleScoreControllerTest
  {
    [TestMethod]
    public void ScrabbleScoreIndex_ReturnsCorrectView_True()
    {
      //Arrange
      ScrabbleScoreController controller = new ScrabbleScoreController();

      //Act
      ActionResult indexView = controller.Index();

      //Assert
      Assert.IsInstanceOfType(indexView, typeof(ViewResult));
    }

    [TestMethod]
    public void CreateForm_ReturnsCorrectView_True()
    {
      //Arrange
      ScrabbleScoreController controller = new ScrabbleScoreController();

      //Act
      ActionResult indexView = controller.CreateForm();

      //Assert
      Assert.IsInstanceOfType(indexView, typeof(ViewResult));
    }
  }
}
