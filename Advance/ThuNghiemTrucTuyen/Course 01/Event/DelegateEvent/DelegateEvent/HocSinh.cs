using System;

namespace DelegateEvent
{
	class HocSinh
	{
		public event UpdateNameHandler NameChanged;

		private string name;
		public string Name
		{
			get => name;
			set
			{
				name = value;
				if (NameChanged != null)
					NameChanged(name);
			}
		}
	}
}
