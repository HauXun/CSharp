using System;
using System.Collections.Generic;

namespace Bai01
{
	/// <summary>
	/// Quản lý danh sách bài hát và các thao tác trên bài hát này
	/// </summary>
	class SongManager
	{
		// Danh sách bài hát
		private List<Song> listSong = new List<Song>();

		/// <summary>
		/// Lấy ra danh sách các bài hát hiện có
		/// </summary>
		public string ShowListSong()
		{
			string result = "";
			foreach (Song item in listSong)
			{
				result += ShowSong(item) + Environment.NewLine;
			}
			return result;
		}

		public string ShowSong(Song item)
		{
			if (item != null)
				return $"{item.Code} - Bai hat: {item.Name} - {item.Singer}";
			return null;
		}

		/// <summary>
		/// Lấy ra một bài hát dựa vào index
		/// </summary>
		/// <param name="index"></param>
		/// <returns></returns>
		public Song GetSong(int index)
		{
			// Nếu Index OutOfRange thì trả về null
			if (index > listSong.Count || index < 0)
				return null;
			return listSong[index];
		}

		/// <summary>
		/// Lấy ra bài hát dựa theo mã bài hát
		/// </summary>
		/// <param name="name"></param>
		/// <returns></returns>
		public Song GetSong(string name)
		{
			// Check all songs in listSong
			foreach (Song item in listSong)
			{
				if (item.Name.ToUpper().Equals(name) || item.Code.ToUpper().Equals(name))
				{
					return item;
				}
			}
			return null;
		}

		/// <summary>
		/// Xóa bài hát tại vị trí mong muốn
		/// </summary>
		/// <param name="index"></param>
		/// <returns></returns>
		public bool RemoveSong(int index)
		{
			try
			{
				listSong.Remove(listSong[index]);
				//for (int i = index; i < listSong.Count - 1; i++)
				//{
				//	// Dồn phần tử sau lên trước để xóa
				//	listSong[i] = listSong[i + 1];
				//}
			}
			catch (Exception e)
			{
				return false;
			}
			return true;
		}

		/// <summary>
		/// Thêm 1 phần tử vào trong danh sách bài hát
		/// </summary>
		/// <param name="name"></param>
		/// <param name="singer"></param>
		/// <returns></returns>
		public bool InsertSong(string name, string singer)
		{
			try
			{
				listSong.Add(new Song(name, singer));
			}
			catch (Exception e)
			{
				return false;
			}
			return true;
		}

		/// <summary>
		/// Tạo danh sách bài hát có sẵn
		/// </summary>
		public void GeneratorSong()
		{
			InsertSong("Interconected", "Hard Driver");
			InsertSong("Project 1", "Project One");
			InsertSong("Depper In The Ocean", "Widlstylez");
			InsertSong("Faye", "Coone");
			InsertSong("Weekend Worriors", "Frontliner");
			InsertSong("Down Down", "Noisecontrollers");
		}

		/// <summary>
		/// Khi vừa khởi tạo SongManager thì khởi tạo luôn danh sách bài hát
		/// </summary>
		public SongManager()
		{
			GeneratorSong();
		}
	}
}