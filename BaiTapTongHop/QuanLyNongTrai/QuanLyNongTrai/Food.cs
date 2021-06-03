using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNongTrai
{
	class Food
	{
		private string name;
		private float price;

		/// <summary>
		/// Get or set food name
		/// </summary>
		public string Name { get => name; set => name = value; }

		/// <summary>
		/// Get or set food price
		/// </summary>
		public float Price { get => price; set => price = value; }

		/// <summary>
		/// Calculator total amount of food weight
		/// </summary>
		/// <param name="weight"></param>
		/// <returns></returns>
		public float Amount(float weight)
		{
			return Price * weight;
		}
	}
}
