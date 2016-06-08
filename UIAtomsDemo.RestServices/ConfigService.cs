using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using UIAtomsDemo.RestServices;
using UIAtomsDemo.RestServices.Models;

[assembly: Xamarin.Forms.Dependency(typeof(ConfigService))]

namespace UIAtomsDemo.RestServices
{
    public class ConfigService: BaseService
    {

        public virtual Task<Country[]> GetCountriesAsync() {

            return JsonGetAsync<Country[]>("/config/countries",null);

        }


        public virtual Task<Movie[]> GetMoviesAsync() {
            return JsonGetAsync<Movie[]>("/config/movies", null);
        }


        public virtual Task<Person[]> GetPersonListAsync() {
            return JsonGetAsync<Person[]>("/config/persons",null);
        }

    }
}
