using System;

namespace ArrayLists
{
	/// <summary>
	/// Lớp Person có 2 thuộc tính là Name và Age
	/// </summary>
	class Person
	{
		private string name;
		private int age;

		public string Name { get => name; set => name = value; }
		public int Age { get => age; set => age = value; }

		public Person(string name, int age)
		{
			Name = name;
			Age = age;
		}

		public override string ToString()
		{
			return "Name: " + name + " | Age: " + Age;
		}
	}
}
