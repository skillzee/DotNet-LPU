using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Text;
using xUnitExample.Controllers;

namespace xunitExample.Tests.Controllers
{
    public class HomeControllerTest
    {
        [Fact]
        public void HomeController_Index_ValidResult()
        {
            //AAA

            //Arrange ->
            HomeController controller = new HomeController();
            string expectedResult = "I am in Home";

            //Act ->
            string res = controller.Index();

            //Assert ->
            res.Should().Be(expectedResult);

        }

    }
}
