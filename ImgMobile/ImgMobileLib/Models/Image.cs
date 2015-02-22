using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImgMobileLib.Models
{
    class Image
    {
        [JsonProperty("id")]
        public String Id { get; set; }

        [JsonProperty("title")]
        public String Title { get; set; }

        [JsonProperty("description")]
        public String Description { get; set; }

        [JsonProperty("datetime")]
        public long InsertedTime { get; set; }

        [JsonProperty("type")]
        public String Type { get; set; }

        [JsonProperty("animated")]
        public bool Animated { get; set; }

        [JsonProperty("width")]
        public int Width { get; set; }

        [JsonProperty("height")]
        public int Height { get; set; }

        [JsonProperty("size")]
        public long Size { get; set; }

        [JsonProperty("views")]
        public long ViewCount { get; set; }

        [JsonProperty("bandwidth")]
        public long BandwidthConsumed { get; set; }

        [JsonProperty("deletehash")]
        public String DeleteHash { get; set; }

        [JsonProperty("link")]
        public String Link { get; set; }

        [JsonProperty("gifv")]
        public String LinkGifv { get; set; }

        [JsonProperty("mp4")]
        public String LinkMp4 { get; set; }

        [JsonProperty("webm")]
        public String LinkWebm { get; set; }

        [JsonProperty("looping")]
        public bool Looping { get; set; }

        [JsonProperty("vote")]
        public String UsersVote { get; set; }

        [JsonProperty("favorite")]
        public bool UserFavorited { get; set; }

        [JsonProperty("nsfw")]
        public bool Nsfw { get; set; }

        [JsonProperty("comment_count")]
        public long CommentCount { get; set; }

        [JsonProperty("topic")]
        public String Topic { get; set; }

        [JsonProperty("topic_id")]
        public long TopicId { get; set; }

        [JsonProperty("section")]
        public String Section { get; set; }

        [JsonProperty("account_url")]
        public String UploaderName { get; set; }

        [JsonProperty("account_id")]
        public String UploaderId { get; set; }
    }
}
