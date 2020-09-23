using Newtonsoft.Json;
using System;

namespace TexasTSA.Services.TsaYourWay.Catalog.Contracts
{
    public class TsaEvent
    {
        [JsonProperty(PropertyName = "active")]
        public string Active { get; set; }

        [JsonProperty(PropertyName = "attachments")]
        public string Attachments { get; set; }

        [JsonProperty(PropertyName = "alert")]
        public string Alert { get; set; }

        [JsonProperty(PropertyName = "archive")]
        public Boolean Archive { get; set; }

        [JsonProperty(PropertyName = "challenge")]
        public string Challenge { get; set; }

        [JsonProperty(PropertyName = "createdTimestamp")]
        public DateTime CreatedTimestamp { get; set; }

        [JsonProperty(PropertyName = "contact")]
        public string Contact { get; set; }

        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

        [JsonProperty(PropertyName = "details")]
        public string Details { get; set; }

        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        [JsonProperty(PropertyName = "individual")]
        public Boolean Individual { get; set; }

        [JsonProperty(PropertyName = "highschool")]
        public string HighSchool { get; set; }

        [JsonProperty(PropertyName = "middleschool")]
        public string MiddleSchool { get; set; }

        [JsonProperty(PropertyName = "modifiedTimestamp")]
        public DateTime ModifiedTimestamp { get; set; }

        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        // for Algolia search engine
        [JsonProperty(PropertyName = "objectID")]
        public string ObjectID { get; set; }

        [JsonProperty(PropertyName = "overview")]
        public string Overview { get; set; }

        [JsonProperty(PropertyName = "relatedCareers")]
        public string RelatedCareers { get; set; }

        [JsonProperty(PropertyName = "rubric")]
        public string Rubric { get; set; }

        [JsonProperty(PropertyName = "rules")]
        public string Rules { get; set; }

        [JsonProperty(PropertyName = "showAlert")]
        public Boolean ShowAlert { get; set; }

        [JsonProperty(PropertyName = "stemIntegration")]
        public string StemIntegration { get; set; }

        [JsonProperty(PropertyName = "submittableUri")]
        public string SubmittableUri { get; set; }

        [JsonProperty(PropertyName = "team")]
        public Boolean Team { get; set; }

        [JsonProperty(PropertyName = "type")]
        public string Type { get; set; }

        [JsonProperty(PropertyName = "version")]
        public int Version { get; set; }
    }
}
