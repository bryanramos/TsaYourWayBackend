using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Algolia.Search.Clients;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using TexasTSA.Services.TsaYourWay.Catalog.Contracts;

namespace TexasTSA.Services.TsaYourWay.Catalog.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EventsController : ControllerBase
    {
        // GET: api/Events
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Events/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(string id)
        {
            SearchClient client = new SearchClient(
                Environment.GetEnvironmentVariable("ALGOLIA_APP_ID"),
                Environment.GetEnvironmentVariable("ADMIN_API_KEY"));
            // save event in tsa events search index
            SearchIndex index = client.InitIndex("dev_TsaEvents");
            // get a single object
            TsaEvent tsaEvent = index.GetObject<TsaEvent>(
              id);

            return JsonConvert.SerializeObject(tsaEvent);
        }

        // POST: api/Events
        [HttpPost]
        public void Post([FromBody] object content)
        {
            TsaEvent tsaEvent = JsonConvert.DeserializeObject<TsaEvent>(content.ToString());

            tsaEvent.CreatedTimestamp = tsaEvent.ModifiedTimestamp = DateTime.Now;
            tsaEvent.Id = tsaEvent.ObjectID = Guid.NewGuid().ToString();
            tsaEvent.Version = 1;

            SearchClient client = new SearchClient(
                Environment.GetEnvironmentVariable("ALGOLIA_APP_ID"),
                Environment.GetEnvironmentVariable("ADMIN_API_KEY"));
            // save event in tsa events search index
            SearchIndex index = client.InitIndex("dev_TsaEvents");
            index.SaveObject(
                tsaEvent,
                autoGenerateObjectId: false);
        }

        // PUT: api/Events/5
        [HttpPut("{id}")]
        public void Put(string id, [FromBody] object content)
        {
            TsaEvent updatedEvent = JsonConvert.DeserializeObject<TsaEvent>(content.ToString());
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
