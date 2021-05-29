using System;

namespace HandlerEvent
{
	class DuLieuNhap : EventArgs
	{
		public int Data { get; set; }
		public DuLieuNhap(int x) => Data = x;
	}
}
