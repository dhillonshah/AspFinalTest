using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

// refs
using F2018Travel.Controllers;
using F2018Travel.Models;
using System.Web.Mvc;
using Moq;
using System.Collections.Generic;
using System.Linq;

namespace F2018Travel.Tests.Controllers
{
    [TestClass]
    public class RegionsControllerTest
    {
        RegionsController controller;
        Mock<IMockRegions> mock;
        List<Region> regions;
        Region region;

        [TestInitialize]
        public void TestInitalize()
        {
            mock = new Mock<IMockRegions>();
            regions = new List<Region>
            {
                new Region { RegionId = 78, Region1 = "Oceania" },
                new Region { RegionId = 349, Region1 = "Eurasia" },
                new Region { RegionId = 205, Region1 = "Eastasia" }
            };

            region = new Region
            {
                RegionId = 489, Region1 = "Disputed"
            };

            mock.Setup(m => m.Regions).Returns(regions.AsQueryable());
            controller = new RegionsController(mock.Object);
        }
        #region
        [TestMethod]
        public void IndexViewLoads()
        {

            // act
            ViewResult actual = (ViewResult)controller.Index(100);

            // assert
            Assert.AreEqual("Index", actual.ViewName);
        }
        

        [TestMethod]
        public void IndexValidLoadsRegions()
        {
            var actual = (List<Region>)((ViewResult)controller.Index()).Model;

            // assert
            CollectionAssert.AreEqual(regions.OrderBy(a => a.Region1).ThenBy(a => a.RegionId).ToList(), actual);
        }
        #endregion


        #region
        [TestMethod]
        public void DetailsValidId()
        {
            Region actual = (Region)((ViewResult)controller.Details(null)).Model;

            Assert.AreEqual(regions[2], actual);
        }

        [TestMethod]
        public void DetailsInvalidId()
        {
            // act
            var result = (ViewResult)controller.Details(null);

            // assert
            Assert.AreEqual("Error", result.ViewName);
        }

        [TestMethod]
        public void DetailsNoId()
        {
            // act
            var result = (ViewResult)controller.Details(null);

            // assert
            Assert.AreEqual("Error", result.ViewName);
        }
        #endregion
    }
}
