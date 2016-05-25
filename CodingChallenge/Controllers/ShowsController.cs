using CodingChallenge.Models;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace CodingChallenge.Controllers
{
    public class ShowsController : ApiController
    {

        [Route("")]
        [HttpPost]
        public HttpResponseMessage FilterShows([FromBody] JsonRequest model)
        {
            var response = new HttpResponseMessage();

            if (model == null) { 
                response=Request.CreateResponse(HttpStatusCode.BadRequest, new { error = "Could not decode request: JSON parsing failed" });
            }
            // filter the shows
            else if (model.payload != null)
            {
                var shows = model.payload.Where(x => x.drm == true && x.episodeCount > 0)
                            .Select(x=> new Show(){image = x.image.showImage, slug = x.slug, title = x.title}).ToList();

                if (shows != null && shows.Count() > 0)
                {
                   response = Request.CreateResponse(HttpStatusCode.OK, new JsonResponse(){response = shows});
                }
            }

            return response;
        }
    }
}
