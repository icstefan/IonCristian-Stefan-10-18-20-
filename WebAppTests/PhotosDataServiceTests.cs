using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WebApp.DataServices;

namespace WebAppTests
{
    [TestClass]
    public class PhotosDataServiceTests
    {
        [TestMethod]
        public void TestGetPhotosForAlbum()
        {
            //-- Arrange
            var dataService = new PhotosDataService();

            //-- Act
            var photos = dataService.GetPhotosForAlbum(1).Result;

            //-- Assert
            Assert.IsTrue(photos.Count() == 50);
        }
    }
}
