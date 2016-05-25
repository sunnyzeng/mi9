using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CodingChallenge.Controllers;
using CodingChallenge.Models;
using System.Net;
using Newtonsoft.Json;

namespace Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestInvalidJsonRequest()
        {
            ShowsController controller = new ShowsController();
 
            JsonRequest request = new JsonRequest();
            JsonConvert.DeserializeObject<JsonRequest>("dsfkhsdfjsf");
            var response = controller.FilterShows(request);

            Assert.AreEqual(response, HttpStatusCode.BadRequest);
        }
    }
}
