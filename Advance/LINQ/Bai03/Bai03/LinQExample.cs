using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;
using static System.Console;

namespace Bai03
{
	class LinQExample
	{
		public static void queryXMLFile(string fileName)
		{
			// 1. Data Source
			var xmlDocument = XDocument.Load(@fileName);

			// 2. Query Creation
			IEnumerable<string> filmNames = from film in xmlDocument.Descendants("film")
											//where (int)film.Element("releaseYear") == 1977
											//where (int)film.Element("releaseYear") > 1900
											select film.Element("name").Value;
			// Query result => object => contain name, releaseYear => how to do this ?
			var foundedFilms = from film in xmlDocument.Descendants("film")
							   //where (int)film.Element("releaseYear") > 1900
							   select new
							   {
								   Name = film.Element("name").Value,
								   ReleaseYear = film.Element("releaseYear").Value
							   };

			// 3. Query Execution
			foreach (var filmName in filmNames)
			{
				WriteLine($"{filmName} ");
			}

			WriteLine('\n');

			foreach (var foundedFilm in foundedFilms)
			{
				WriteLine($"Name: {foundedFilm.Name}, ReleaseYear: {foundedFilm.ReleaseYear}");
			}
		}
	}
}
