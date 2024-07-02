using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RestSharp;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GeoTimeZoneController : ControllerBase
    {

        [HttpGet("")]
        public async Task<IActionResult> GetGeoTimeZone(string latitude, string longitude)
        {
            var client = new RestClient($"https://api.geotimezone.com");
            var request = new RestRequest("/public/timezone", Method.Get);

            request.AddParameter("latitude", latitude);
            request.AddParameter("longitude", longitude);

            var response = client.Execute(request);

            return Ok(response.Content);
        }

    }
}
