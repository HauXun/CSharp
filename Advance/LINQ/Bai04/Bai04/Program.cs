using System;
using System.Collections.Generic;

namespace Bai04
{
	class Program
	{
		static void Main(string[] args)
		{
			//LinQExample.queryXMLFile("films.xml");
			//Dictionary<string, string> newFilm = new Dictionary<string, string>();

			//newFilm.Add("Name", "The Blind Side");
			//newFilm.Add("ReleaseYear", "2009");

			//newFilm.Add("Name", "The Greatest Game Ever Played");
			//newFilm.Add("ReleaseYear", "2005");

			//LinQExample.InsertToXMLDocument("films.xml", newFilm);

			//Dictionary<string, string> updatedFilm = new Dictionary<string, string>();
			//updatedFilm.Add("Name", "Star Wars");
			//updatedFilm.Add("ReleaseYear", "1977");
			//LinQExample.UpdateAnElement("films.xml", "1", updatedFilm);

			//1621946616
			LinQExample.DeleteAnElement("films.xml", "1621946616");
		}
	}
}
