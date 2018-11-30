using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using WordCounterSpace.Controllers;
using WordCounterSpace.Models;

namespace WordCounterSpace.Tests
{
  [TestClass]
  public class WordCounterControllerTest
  {
    [TestMethod]
    public void Create_ReturnsCorrectActionType_RedirectToActionResult()
    {
        //Arrange
        WordCounterController controller = new WordCounterController();

        //Act
        IActionResult view = controller.Create("walk", "Walk the dog") as ViewResult;

        //Assert
        Assert.IsInstanceOfType(view, typeof(ActionResult));
    }
  }
}
