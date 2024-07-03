using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RestSharp;
using System.Text.Json;
using Domain;
using Newtonsoft.Json;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GeoTimeZoneController : ControllerBase
    {

        [HttpGet("")]
        public async Task<IActionResult> GetGeoTimeZone(string latitude, string longitude)
        {
            int countryId = 0;           

            var client = new RestClient($"https://api.geotimezone.com");
            var request = new RestRequest("/public/timezone", Method.Get);

            request.AddParameter("latitude", latitude);
            request.AddParameter("longitude", longitude);

            var response = client.Execute(request);

            var obj = JsonConvert.DeserializeObject<GeoTmZone>(response.Content);

            switch (obj.location)
            {
                case "Mexico": 
                    countryId =1;
                    break;
                case "Peru":
                    countryId = 2;
                    break;
                case "Ecuador":
                    countryId = 3;
                    break;
                case "Argentina":
                    countryId = 4;
                    break;
            }

            Country c = new Country 
            { 
                Id = countryId,
                location = obj.location,
                country_iso = obj.country_iso                
            };

            return Ok(c);
        }

    }
}
