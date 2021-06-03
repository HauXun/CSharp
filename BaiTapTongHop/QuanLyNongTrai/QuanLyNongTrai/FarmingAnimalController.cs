using System;
using System.Collections.Generic;
using static System.Console;

namespace QuanLyNongTrai
{
	/// <summary>
	/// Quản lý danh sách một loại động vật
	/// <Chuồng>
	/// </summary>
	class FarmingAnimalController
	{
		private List<FarmingAnimal> animalList;

		/// <summary>
		/// Get or set value for animal list
		/// Danh sách động vật trong chuồng
		/// </summary>
		internal List<FarmingAnimal> AnimalList { get => animalList; set => animalList = value; }

		/// <summary>
		/// Initial value for animal list
		/// </summary>
		public FarmingAnimalController()
		{
			AnimalList = new List<FarmingAnimal>();
		}

		/// <summary>
		/// Add animal into list
		/// </summary>
		/// <param name="animal"></param>
		public void Add(FarmingAnimal animal)
		{
			AnimalList.Add(animal);
		}

		/// <summary>
		/// Remove animal outto list
		/// </summary>
		/// <param name="animal"></param>
		public void Remove(FarmingAnimal animal)
		{
			if (AnimalList != null)
				AnimalList.Remove(AnimalList.Find(x => x.Name == animal.GetType().Name));
		}

		public float TotalAmount(float weight)
		{
			if (AnimalList.Count > 0)
			{
				return AnimalList[0].EatFood.Amount(weight) * AnimalList.Count;
			}
			return 0;
		}

		public void PrintTotalAmount(float weight)
		{
			if (AnimalList.Count > 0)
			{
				WriteLine("{0, 5} {1, 10} | eat {2, 7}kg {3, 10} | spend | {4, 10} price", AnimalList.Count, AnimalList[0].Name, weight * AnimalList.Count, AnimalList[0].EatFood.Name, TotalAmount(weight));
			}
			else
			{
				WriteLine("Nothing to show!");
			}
		}
	}
}
