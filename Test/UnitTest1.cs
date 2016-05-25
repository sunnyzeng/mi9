using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CodingChallenge.Controllers;
using CodingChallenge.Models;
using System.Net;
using Newtonsoft.Json;
using System.Net.Http;
using System.Web.Http.Hosting;
using System.Web.Http;

namespace Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestEmptyJsonRequest()
        {
            ShowsController controller = new ShowsController();
 
            JsonRequest request = new JsonRequest();
            var response = controller.FilterShows(request);

            Assert.AreEqual(response.StatusCode, HttpStatusCode.OK);
        }

        [TestMethod]
        public void TestInvalidJson()
        {
            ShowsController controller = new ShowsController();
            controller.Request = new HttpRequestMessage();
            controller.Request.Properties.Add(HttpPropertyKeys.HttpConfigurationKey, new HttpConfiguration());
            // request will be null in case of bad json string
            JsonRequest request = null;
            //act 
            var response = controller.FilterShows(request);

            Assert.AreEqual(response.StatusCode, HttpStatusCode.BadRequest);
        }
    }
}
