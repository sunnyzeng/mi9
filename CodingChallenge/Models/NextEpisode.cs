using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CodingChallenge.Models
{
    public class NextEpisode
    {
        public string channel { get; set; }
        public string channelLogo { get; set; }
        public DateTime date { get; set; }
        public string html { get; set; }
        public string url { get; set; }
    }
}