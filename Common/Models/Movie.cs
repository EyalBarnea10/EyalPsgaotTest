using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TestEyal.Models
{
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public class Movie
    {
        [JsonProperty(PropertyName = "image")]
        public string Image { get; set; }
        [JsonProperty(PropertyName = "title")]
        public string Title { get; set; }
        [JsonProperty(PropertyName = "seasons")]
        public string Seasons { get; set; }
        [JsonProperty(PropertyName = "views")]
        public string Views { get; set; }

        [JsonProperty(PropertyName = "details")]
        public string Details { get; set; }
    }


public class MoviesList
{
    public List<Movie> Movies { get; set; }
}
}