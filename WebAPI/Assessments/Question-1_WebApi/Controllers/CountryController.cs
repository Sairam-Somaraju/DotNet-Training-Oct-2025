using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    [RoutePrefix("api/Country")]

    public class CountryController : ApiController
    {
        static List<Country> countries = new List<Country>
        {
            new Country { ID = 1, CountryName = "India", Capital = "New Delhi" },
            new Country { ID = 2, CountryName = "England", Capital = "London" },

        };

        [HttpGet]
        [Route("All")]
        public IEnumerable<Country> GetAllCountries()
        {
            return countries;
        }
         
        [HttpGet]
        [Route("ById")]
        public IHttpActionResult GetCountryById(int pId)
        {
            Country country = countries.SingleOrDefault(c => c.ID == pId);
            if (country == null)
            {
                return NotFound();
            }
            return Ok(country.CountryName);
        }

        [HttpPost]
        [Route("Postall")]
        public List<Country> PostCountry([FromBody] Country country)
        {
            countries.Add(country);
            return countries;
        }

         

        [HttpPut]
         public IHttpActionResult PutCountry(int pid, Country updatedCountry)
        {
            var country = countries.FirstOrDefault(c => c.ID == pid);
            if (country == null || updatedCountry == null)
                return BadRequest();

            country.CountryName = updatedCountry.CountryName;
            country.Capital = updatedCountry.Capital;

            return Ok(country);
        }


        [HttpDelete]
        [Route("delete")]
        public IEnumerable<Country> DeleteCountry(int pid)
        {
            countries.RemoveAt(pid);
            return countries;
        }
    }
}
