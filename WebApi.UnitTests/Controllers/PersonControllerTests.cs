using Application.Dto;
using Application.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Moq;
using NUnit.Framework;
using System.Collections.Generic;
using WebApi.Controllers;

namespace WebApi.Tests.Controllers
{
    public class PersonControllerTests
    {
        [Test]
        public void Get_Returns_NoFound()
        {
            //Arrange
            var personServiceMock = new Mock<IPersonService>();
            personServiceMock.Setup(x => x.GetAll()).Returns(new List<PersonDto>());

            //Act
            var controller = new PersonController(personServiceMock.Object);
            var data = controller.Get();

            //Assert
            Assert.That(data, Is.InstanceOf<NotFoundResult>());
        }
        [Test]
        public void Get_Returns_Ok()
        {
            //Arrange
            var personServiceMock = new Mock<IPersonService>();
            personServiceMock.Setup(x => x.GetAll()).Returns(new List<PersonDto>()
            {
                new PersonDto()
                {
                    Name = "Name1"
                }
            }
            ); 

            //Act
            var controller = new PersonController(personServiceMock.Object);
            var data = controller.Get();

            //Assert
            Assert.That(data, Is.InstanceOf<OkObjectResult>());
        }
    }
}
