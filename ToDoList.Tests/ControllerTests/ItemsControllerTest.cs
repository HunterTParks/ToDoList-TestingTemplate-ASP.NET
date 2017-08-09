using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using ToDoList.Controllers;
using ToDoList.Models;
using Xunit;

namespace ToDoList.Tests.ControllerTests
{
    public class ItemsControllerTest
    {
        //Tests to see if returning a correct View Page
        [Fact]
        public void Get_ViewResult_Index_Test()
        {
            //Arrange
            ItemsController controller = new ItemsController();

            var result = controller.Index();

            Assert.IsType<ViewResult>(result);
        }

        //Test to see if View Page returns a List of 'Items'
        [Fact]
        public void Get_ModelList_Index_Test()
        {
            //Arrange
            ItemsController controller = new ItemsController();
            ViewResult indexView = controller.Index() as ViewResult;

            //Act
            var result = indexView.ViewData.Model;

            //Assert
            Assert.IsType<List<Item>>(result);
        }
    }
}
