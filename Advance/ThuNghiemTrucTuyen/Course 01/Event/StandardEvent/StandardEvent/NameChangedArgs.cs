using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StandardEvent
{
	class NameChangedArgs : EventArgs
	{
		public string Name { get; set; }
		public NameChangedArgs(string name)
		{
			Name = name;
		}
	}
}
