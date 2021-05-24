
namespace SanPham
{
	partial class Product
	{
		public string Name { get; set; }
		public decimal Price { get; set; }
		public string GetInfo() => $"{Name} / {Price} : {Description}"; 
	}
}
