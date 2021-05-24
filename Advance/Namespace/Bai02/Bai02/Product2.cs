
namespace SanPham
{
	partial class Product
	{
		public Manufactory manufactory { get; set; }
		public class Manufactory
		{
			public string Name { get; set; }
			public string Address { get; set; }
		}
		public string Description { get; set; }
	}
}
