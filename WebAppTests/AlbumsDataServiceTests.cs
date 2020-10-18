using Microsoft.VisualStudio.TestTools.UnitTesting;
using WebApp.DataServices;
using System.Collections.Generic;
using System.Linq;

namespace WebAppTests
{
    [TestClass]
    public class AlbumsDataServiceTests
    {
        [TestMethod]
        public void TestGetAllAlbums()
        {
            //-- Arrange
            var dataService = new AlbumsDataService();

            //-- Act
            var albums = dataService.GetAlbums().Result;

            //-- Assert
            Assert.IsTrue(albums.Count() == 100);
        }
    }
}
