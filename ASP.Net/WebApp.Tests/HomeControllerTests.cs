using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
using WebApp.Controllers;
using WebApp.Models;

namespace WebApp.Tests
{
  [TestClass]
  public class HomeControllerTests
  {
    [TestMethod]
    public void IndexTest()
    {
      var mockData = new FakeDbSet<ValuesTable>();
      var mock = new Mock<Entities>();

      mock.Setup(m => m.ValuesTable).Returns(mockData);
      HomeController controller = new HomeController(mock.Object);
      ActionResult result = controller.Index();
      Assert.IsNotNull(result);
    }
  }
}
