using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StandardEvent
{
	class HocSinh
	{
		private string name;

		public string Name 
		{ 
			get => name;
			set
			{
				name = value;
				OnNameChange(value);
			}
		}

		private event EventHandler<NameChangedArgs> _NameChanged;
		public event EventHandler<NameChangedArgs> NameChanged
		{
			add
			{
				_NameChanged += value;
			}
			remove
			{
				_NameChanged -= value;
			}
		}

		private void OnNameChange(string name)
		{
			if (_NameChanged != null)
			{
				_NameChanged(this, new NameChangedArgs(name));
			}	
		}
	}
}
