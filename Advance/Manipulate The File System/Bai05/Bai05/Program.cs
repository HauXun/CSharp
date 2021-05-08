using System;
using System.IO;
using System.Text;

namespace Bai05
{
	class Program
	{
		class Product
		{
			public int ID { get; set; }
			public double Price { get; set; }
			public string Name { get; set; }
			public void Save(Stream stream)
			{
				// int --> 4 byte
				var byte_ID = BitConverter.GetBytes(ID);
				stream.Write(byte_ID, 0, 4);

				// double --> 8 byte
				var byte_Price = BitConverter.GetBytes(Price);
				stream.Write(byte_Price, 0, 8);

				var byte_Name = Encoding.UTF8.GetBytes(Name);
				var byte_Length = BitConverter.GetBytes(Name.Length);
				stream.Write(byte_Length, 0, 4);
				stream.Write(byte_Name, 0, byte_Name.Length);
			}

			public void Restore(Stream stream)
			{
				// int --> 4 byte
				var byte_ID = new byte[4];
				stream.Read(byte_ID, 0, 4);
				ID = BitConverter.ToInt32(byte_ID, 0);

				// double --> 8 byte
				var byte_Price = new byte[8];
				stream.Read(byte_Price, 0, 8);
				Price = BitConverter.ToDouble(byte_Price, 0);

				var byte_Length = new byte[4];
				stream.Read(byte_Length, 0, 4);
				int length = BitConverter.ToInt32(byte_Length);

				var byte_Name = new byte[length];
				stream.Read(byte_Name, 0, length);
				Name = Encoding.UTF8.GetString(byte_Name, 0, length);
			}
		}
		static void Main(string[] args)
		{
			string path = "data.txt";
			using FileStream fileStream = new FileStream(path: path, FileMode.OpenOrCreate);
			Product product = new Product();
			//Product product = new Product()
			//{
			//	ID = 10,
			//	Price = 12345,
			//	Name = "San pham Abc"
			//};

			//product.Save(fileStream);

			product.Restore(fileStream);

			Console.WriteLine($"{product.Name} - {product.ID} - {product.Price}");

			return;

			// Lưu dữ liệu
			byte[] buffer = { 1, 7, 2 };
			int offset = 0;
			int count = 3;

			fileStream.Write(buffer, offset, count);

			// Đọc dữ liệu
			int soByteDocDuoc = fileStream.Read(buffer, offset, count);

			// int, double,... --> bytes
			int abc = 1;
			var bytes = BitConverter.GetBytes(abc);

			// bytes --> int, double,...
			BitConverter.ToInt32(bytes, 0);

			string s = "Abc";
			var byte_s = Encoding.UTF8.GetBytes(s);

			Encoding.UTF8.GetString(byte_s, 0, 10);
		}
	}
}
