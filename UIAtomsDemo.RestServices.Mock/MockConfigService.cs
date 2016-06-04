using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using UIAtomsDemo.RestServices.Models;

namespace UIAtomsDemo.RestServices.Mock
{
    public class MockConfigService: ConfigService
    {

        public override Task<Country[]> GetCountriesAsync()
        {
            return Task.Run(()=> new Country[] {
                new Country { CountryName = "India", CountryCode = "IN" },
                new Country { CountryName = "United States", CountryCode = "US" },
                new Country { CountryName = "United Kingdom", CountryCode = "UK" }
            });
        }


    }
}
