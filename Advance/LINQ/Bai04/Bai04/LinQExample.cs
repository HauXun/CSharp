using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;
using static System.Console;

namespace Bai04
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

		public static void InsertToXMLDocument(string fileName, Dictionary<string, string> newFilm)
		{
			var xmlDocument = XDocument.Load(@fileName);
			var currentTimeStamp = ((DateTimeOffset)DateTime.Now).ToUnixTimeSeconds();

			//xmlDocument.Element("films").Add(new XElement("film",
			//	new XAttribute("id", currentTimeStamp),
			//	new XElement("name", newFilm["Name"]),
			//	new XElement("releaseYear", newFilm["ReleaseYear"])));

			xmlDocument.Element("films").AddFirst(new XElement("film",
				new XAttribute("id", currentTimeStamp),
				new XElement("name", newFilm["Name"]),
				new XElement("releaseYear", newFilm["ReleaseYear"])));

			xmlDocument.Save(@fileName);
		}

		public static void UpdateAnElement(string fileName, string id, Dictionary<string, string> updatedFilm)
		{
			// 1. Data Source
			var xmlDocument = XDocument.Load(@fileName);
			var existingElement = xmlDocument.Element("films").Elements("film")
				.Where(element => element.Attribute("id").Value == id)
				.FirstOrDefault();
			if (updatedFilm.ContainsKey("Name") && updatedFilm["Name"] != null)
			{
				existingElement.SetElementValue("name", updatedFilm["Name"]);
			}
			if (updatedFilm.ContainsKey("ReleaseYear") && updatedFilm["ReleaseYear"] != null)
			{
				existingElement.SetElementValue("releaseYear", updatedFilm["ReleaseYear"]);
			}
			xmlDocument.Save(@fileName);
		}

		public static void DeleteAnElement(string fileName, string id)
		{
			var xmlDocument = XDocument.Load(@fileName);
			var existingElement = xmlDocument.Element("films").Elements("film")
				.Where(element => element.Attribute("id").Value == id)
				.FirstOrDefault();
			if (existingElement != null)
			{
				existingElement.Remove();
				xmlDocument.Save(@fileName);
			}
			else
			{
				WriteLine("Cannot find element to delete !");
			}
		}
	}
}
