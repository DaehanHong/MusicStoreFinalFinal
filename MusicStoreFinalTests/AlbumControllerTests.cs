using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MusicStore.Controllers;
using MusicStore.Models;
using System.Web.Mvc;
using System.Linq;
using System.Collections.Generic;

namespace MusicStoreFinalTests
{
    [TestClass]
    public class AlbumControllerTests
    {
        AlbumsController controller;
        List<Album> albums;
        
        [TestMethod]
        public void DetailReturnsErrorWithInvalidId()
        {
            //Act
            ViewResult result = controller.Details(500) as ViewResult;
            //Assert
            Assert.AreEqual("Error", result.ViewName);

        }
    }
}
