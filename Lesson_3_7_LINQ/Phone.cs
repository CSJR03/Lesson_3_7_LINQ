using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson_3_7_LINQ
{
	class Phone
	{
		public string Name { get; set; }
		public int Price { get; set; }

		public override string ToString()
		{
			return $"{Name } - {Price}";	
		}

	}
}
