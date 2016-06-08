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

        public override Task<Movie[]> GetMoviesAsync()
        {
            return Task.Run(() => new Movie[] {
                new Movie { Category = "Action", Title = "Terminator" }
            });
        }

        public override Task<Person[]> GetPersonListAsync()
        {
            return Task.Run(() => new Person[] {
                new Person { FirstName = "Akash", LastName = "Kava" },
                new Person { FirstName = "Jack", LastName = "Wayne" },
                new Person { FirstName = "Phill", LastName = "Maurice" },
                new Person { FirstName = "Maria", LastName = "Lopez" },
                new Person { FirstName = "Bill", LastName = "Twain" },
                new Person { FirstName = "Adams", LastName = "Whitman" },
            });
        }

    }
}
