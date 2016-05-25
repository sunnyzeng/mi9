using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http.ModelBinding;

namespace CodingChallenge.Models
{
    public class JsonRequest
    {
        public List<Payload> payload { get; set; }
        public int skip { get; set; }
        public int take { get; set; }
        public int totalRecords { get; set; }
    }
}