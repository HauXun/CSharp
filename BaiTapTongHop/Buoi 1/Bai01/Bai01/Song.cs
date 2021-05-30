using System;

namespace Bai01
{
	class Song
	{
		private string name;
		private string singer;
		private string code;

		public string Name { get => name; set => name = value; }
		public string Singer { get => singer; set => singer = value; }
		public string Code { get => code; set => code = value; }

		/// <summary>
		/// Hàm dựng cho lớp Song
		/// </summary>
		/// <param name="name"></param>
		/// <param singer="singer"></param>
		public Song(string name, string singer)
		{
			this.name = name;
			this.singer = singer;
			this.code = CodeGenerator.GeneratorCode();

		}
	}
}