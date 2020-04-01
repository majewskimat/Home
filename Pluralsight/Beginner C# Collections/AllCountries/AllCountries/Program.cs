using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pluralsight.BegCShCollections.ReadAllCountries
{
	class Program
	{
		static void Main(string[] args)
		{
			string filePath = @"C:\Users\matma\Desktop\PopbyLargestFinal.csv";
			CsvReader reader = new CsvReader(filePath);

			List<Country> countries = reader.ReadAllCountries();
			reader.RemoveCommaCountries(countries);

			/*Country lilliput = new Country("Lilliput", "LIL", "Somewhere", 2_000_000);
			int lilliputIndex = countries.FindIndex(x=> x.Population < 2_000_000);
			countries.Insert(lilliputIndex, lilliput);
			// countries.RemoveAt(lilliputIndex);
			*/

			Console.Write("Enter no. of countries to display> ");
			bool inputIsInt = int.TryParse(Console.ReadLine(), out int userInput);

			if (!inputIsInt || userInput <= 0)
			{
				Console.WriteLine("You must type in +ve integer. Exiting");
				return;
			}

			int maxToDisplay = userInput;

			//foreach (Country country in countries)  // wyświetlanie danych za pomocą pętli foreach
			for(int i = 0; i < countries.Count; i++)  // wyświetlanie danych od najwyższej wartości 
			{
				if (i > 0 && (i % maxToDisplay == 0))
				{
					Console.WriteLine("Hit return to continue, anything else to quit>");
					if (Console.ReadLine() != "")
						break;
				}
				Country country = countries[i]; //wczytuje wszystkie dane z pliku za pomocą pętli for
				Console.WriteLine($"{i+1}: {PopulationFormatter.FormatPopulation(country.Population).PadLeft(15)}: {country.Name}");
			}
			//Console.WriteLine($"{countries.Count} countries");

            Console.ReadKey();
		}
	}
}