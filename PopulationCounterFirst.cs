using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Homework_Population_Counter_first_option
{
    class PopulationCounterFirst
    {
        static void Main(string[] args)
        {
            var country_city = new Dictionary<string, Dictionary<string, long>>();

            string input = Console.ReadLine();

            while (!input.Equals("report"))
            {
                string[] data = input.Split('|').ToArray();
                string countryName = data[1];
                string cityName = data[0];
                long population = long.Parse(data[2]);

                if (!country_city.ContainsKey(countryName))
                {
                    country_city.Add(countryName, new Dictionary<string, long>());
                }
                if (!country_city[countryName].ContainsKey(cityName))
                {
                    country_city[countryName].Add(cityName, population);
                }
                input = Console.ReadLine();

            }
            var orderedCountries = country_city.OrderByDescending(x => x.Value.Values.Sum());

            foreach (var state in orderedCountries)
            {
                var orderedCities = state.Value.OrderByDescending(x => x.Value);
                Console.WriteLine("{0} (total population: {1})", state.Key, state.Value.Sum(x => x.Value));

                foreach (var city in orderedCities)
                {
                    Console.WriteLine("=>" + city.Key + ": " + city.Value);
                }
            }
        }
    }
}
        