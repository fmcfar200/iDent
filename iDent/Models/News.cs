using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace iDent.Models
{
    [JsonObject(MemberSerialization.OptIn)]
    public class Blog
    {
        [JsonProperty]
        public string id { get; set; }
    }

    [JsonObject(MemberSerialization.OptIn)]
    public class Image
    {
        [JsonProperty]
        public string url { get; set; }
    }

    [JsonObject(MemberSerialization.OptIn)]
    public class Author
    {
        [JsonProperty]
        public string id { get; set; }
        [JsonProperty]
        public string displayName { get; set; }
        [JsonProperty]
        public string url { get; set; }
        [JsonProperty]
        public Image image { get; set; }
    }

    [JsonObject(MemberSerialization.OptIn)]
    public class Replies
    {
        [JsonProperty]
        public string totalItems { get; set; }
        [JsonProperty]
        public string selfLink { get; set; }
    }

    [JsonObject(MemberSerialization.OptIn)]
    public class Item
    {

        [JsonProperty]
        public string kind { get; set; }
        [JsonProperty]
        public string id { get; set; }
        [JsonProperty]
        public Blog blog { get; set; }
        [JsonProperty]
        public DateTime published { get; set; }
        [JsonProperty]
        public DateTime updated { get; set; }
        [JsonProperty]
        public string etag { get; set; }
        [JsonProperty]
        public string url { get; set; }
        [JsonProperty]
        public string selfLink { get; set; }
        [JsonProperty]
        public string title { get; set; }
        [JsonProperty]
        public string content { get; set; }
        [JsonProperty]
        public Author author { get; set; }
        [JsonProperty]
        public Replies replies { get; set; }
    }

    [JsonObject(MemberSerialization.OptIn)]
    public class RootObject
    {
        [JsonProperty]
        public string kind { get; set; }

        [JsonProperty]
        public List<Item> items { get; set; }

        [JsonProperty]
        public string etag { get; set; }
    }
}
