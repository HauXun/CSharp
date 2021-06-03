using System;
using static System.Console;

namespace QuanLyNongTrai
{
	class FarmingController
	{
		private FarmingAnimalController dairyCow;
		private FarmingAnimalController chicken;
		private FarmingAnimalController pig;
		private FarmingAnimalController dog;

		/// <summary>
		/// Get or set value of dairy cow
		/// </summary>
		internal FarmingAnimalController DairyCow { get => dairyCow; set => dairyCow = value; }

		/// <summary>
		/// Get or set value of chicken
		/// </summary>
		internal FarmingAnimalController Chicken { get => chicken; set => chicken = value; }

		/// <summary>
		/// Get or set value of pig
		/// </summary>
		internal FarmingAnimalController Pig { get => pig; set => pig = value; }

		/// <summary>
		/// Get or set value of dog
		/// </summary>
		internal FarmingAnimalController Dog { get => dog; set => dog = value; }

		public FarmingController()
		{
			DairyCow = new FarmingAnimalController();
			Chicken = new FarmingAnimalController();
			Pig = new FarmingAnimalController();
			Dog = new FarmingAnimalController();
		}

		/// <summary>
		/// Add amount animal into list
		/// </summary>
		/// <param name="animalController"></param>
		/// <param name="name"></param>
		/// <param name="number"></param>
		private void Add(FarmingAnimalController animalController, string name, int number)
		{
			FarmingAnimal newAnimal = new FarmingAnimal();

			switch (name)
			{
				case var value when value == (Constant.DAIRY_COW_NAME):
					newAnimal = new DairyCow();
					break;
				case var value when value == (Constant.CHICKEN_NAME):
					newAnimal = new Chicken();
					break;
				case var value when value == (Constant.PIG_NAME):
					newAnimal = new Pig();
					break;
				case var value when value == (Constant.DOG_NAME):
					newAnimal = new Dog();
					break;
				default:
					return;
			}
			for (int i = 0; i < number; i++)
			{
				animalController.Add(newAnimal);
			}
		}

		/// <summary>
		/// Remove amount of animal
		/// If amount greater than animalList.Count => Clear animal list
		/// </summary>
		/// <param name="animalController"></param>
		/// <param name="name"></param>
		/// <param name="number"></param>
		private void Remove(FarmingAnimalController animalController, string name, int number)
		{
			if (animalController.AnimalList.Count >= number)
			{
				// Delete amount of animal
				FarmingAnimal newAnimal = new FarmingAnimal();

				switch (name)
				{
					case var value when value == (Constant.DAIRY_COW_NAME):
						newAnimal = new DairyCow();
						break;
					case var value when value == (Constant.CHICKEN_NAME):
						newAnimal = new Chicken();
						break;
					case var value when value == (Constant.PIG_NAME):
						newAnimal = new Pig();
						break;
					case var value when value == (Constant.DOG_NAME):
						newAnimal = new Dog();
						break;
					default:
						return;
				}
				for (int i = 0; i < number; i++)
				{
					animalController.Remove(newAnimal);
				}
			}
			else
			{
				// Remove all element in list
				animalController.AnimalList.Clear();
			}
		}

		/// <summary>
		/// Add animal
		/// </summary>
		/// <param name="animalName"></param>
		/// <param name="amount"></param>
		public void AddAnimal(string animalName, int amount)
		{
			switch (animalName)
			{
				case var value when value == (Constant.DAIRY_COW_NAME):
					Add(DairyCow, Constant.DAIRY_COW_NAME, amount);
					return;
				case var value when value == (Constant.CHICKEN_NAME):
					Add(Chicken, Constant.CHICKEN_NAME, amount);
					return;
				case var value when value == (Constant.PIG_NAME):
					Add(Pig, Constant.PIG_NAME, amount);
					return;
				case var value when value == (Constant.DOG_NAME):
					Add(Dog, Constant.DOG_NAME, amount);
					return;
				default:
					return;
			}
		}

		/// <summary>
		/// Remove amount of animal
		/// </summary>
		/// <param name="animalName"></param>
		/// <param name="amount"></param>
		public void RemoveAnimal(string animalName, int amount)
		{
			switch (animalName)
			{
				case var value when value == (Constant.DAIRY_COW_NAME):
					Remove(DairyCow, Constant.DAIRY_COW_NAME, amount);
					return;
				case var value when value == (Constant.CHICKEN_NAME):
					Remove(Chicken, Constant.CHICKEN_NAME, amount);
					return;
				case var value when value == (Constant.PIG_NAME):
					Remove(Pig, Constant.PIG_NAME, amount);
					return;
				case var value when value == (Constant.DOG_NAME):
					Remove(Dog, Constant.DOG_NAME, amount);
					return;
				default:
					return;
			}
		}

		/// <summary>
		/// Print spend amount of animal
		/// </summary>
		public void TotalAmount()
		{
			float sum = DairyCow.TotalAmount(Constant.FOOD_WEIGHT_DAIRY_COW_EAT_PER_DAY) +
				Chicken.TotalAmount(Constant.FOOD_WEIGHT_CHICKEN_EAT_PER_DAY) +
				Pig.TotalAmount(Constant.FOOD_WEIGHT_PIG_EAT_PER_DAY) +
				Dog.TotalAmount(Constant.FOOD_WEIGHT_DOG_EAT_PER_DAY);

			DairyCow.PrintTotalAmount(Constant.FOOD_WEIGHT_DAIRY_COW_EAT_PER_DAY);
			Chicken.PrintTotalAmount(Constant.FOOD_WEIGHT_CHICKEN_EAT_PER_DAY);
			Pig.PrintTotalAmount(Constant.FOOD_WEIGHT_PIG_EAT_PER_DAY);
			Dog.PrintTotalAmount(Constant.FOOD_WEIGHT_DOG_EAT_PER_DAY);
			WriteLine("\nTotal per day: {0, 10} price.", sum);
		}

		/// <summary>
		/// Show menu
		/// </summary>
		public void Menu()
		{
			string menu = "1. Total amount." +
				Environment.NewLine +
				"Remove animal: Remove <Animal code> <Amount>" +
				Environment.NewLine +
				"\t1: Dairy Cow | 2: Chicken | 3: Pig | 4: Dog" +
				Environment.NewLine +
				"Add Animal: Add <Animal code> <Amount>" +
				Environment.NewLine +
				"\t1. Dairy Cow | 2: Chicken | 3: Pig | 4: Dog";
			WriteLine(menu);
		}

		/// <summary>
		/// Execute user command
		/// </summary>
		public void UserCommand()
		{
			string command = ReadLine();
			int outto;

			if (Int32.TryParse(command, out outto))
			{
				if (outto == 1)
					TotalAmount();
			}
			else
			{
				if (command != "")
				{
					string[] arr = command.Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries);
					string userCommand = arr[0];
					int animal = int.Parse(arr[1]);
					int amount = int.Parse(arr[2]);
					switch (animal)
					{
						case 1:
							switch (userCommand.ToLower())
							{
								case var value when value == "add":
									AddAnimal("DairyCow", amount);
									break;
								case var value when value == "remove":
									RemoveAnimal("DairyCow", amount);
									break;
							}
							break;
						case 2:
							switch (userCommand.ToLower())
							{
								case var value when value == "add":
									AddAnimal("Chicken", amount);
									break;
								case var value when value == "remove":
									RemoveAnimal("Chicken", amount);
									break;
							}
							break;
						case 3:
							switch (userCommand.ToLower())
							{
								case var value when value == "add":
									AddAnimal("Pig", amount);
									break;
								case var value when value == "remove":
									RemoveAnimal("Pig", amount);
									break;
							}
							break;
						case 4:
							switch (userCommand.ToLower())
							{
								case var value when value == "add":
									AddAnimal("Dog", amount);
									break;
								case var value when value == "remove":
									RemoveAnimal("Dog", amount);
									break;
							}
							break;
						default:
							return;
					}
				}
			}
			ReadLine();
			Clear();
		}
	}
}
