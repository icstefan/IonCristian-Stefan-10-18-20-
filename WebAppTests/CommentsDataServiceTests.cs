using Microsoft.VisualStudio.TestTools.UnitTesting;
using WebApp.DataServices;
using System.Collections.Generic;
using System.Linq;

namespace WebAppTests
{
    [TestClass]
    public class CommentsDataServiceTests
    {
        [TestMethod]
        public void TestGetCommentsForPhoto()
        {
            //-- Arrange
            var dataService = new CommentsDataService();

            //-- Act
            var albums = dataService.GetCommentsForPost(1).Result;

            //-- Assert

            Assert.IsTrue(albums.Count() == 5);
        }
    }
}
