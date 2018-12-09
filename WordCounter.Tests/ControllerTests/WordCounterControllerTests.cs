// using Microsoft.AspNetCore.Mvc;
// using System.Collections.Generic;
// using WordCounter.Controllers;
// using WordCounter.Models;
//
// namespace WordCounter.Tests
// {
//     [TestClass]
//     public class HomeControllerTest
//     {
//         [TestMethod]
//     public void Create_ReturnsCorrectActionType_RedirectToActionResult()
//     {
//         //Arrange
//         HomeController controller = new HomeController();
//
//         //Act
//         ActionResult view = controller.SetWord("dog");
//
//         //Assert
//         Assert.IsInstanceOfType(view, typeof(RedirectToActionResult));
//     }
//
//     [TestMethod]
//     public void Create_RedirectsToCorrectAction_Index()
//     {
//         //Arrange
//         ItemsController controller = new ItemsController();
//         RedirectToActionResult actionResult = controller.SetWord("dog") as RedirectToActionResult;
//
//         //Act
//         string result = actionResult.ActionName;
//
//         //Assert
//         Assert.AreEqual(result, "Index");
//     }
//   }
// }
