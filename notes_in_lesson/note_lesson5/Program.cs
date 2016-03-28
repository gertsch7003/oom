using System;
using System.Collections.Generic;

namespace note_lesson5
{










	class MainClass
	{




		public static void Main (string[] args)
		{


			var xs= new List<int> {1,2,3,4,5,6,7,8,9};



			foreach (var x in xs)
			{
				Console.WriteLine (x);
			}

			//= hinter den kolissen:
			var e = xs.GetEnumerator ();


			while (e.MoveNext ()) {
			
			
				Console.WriteLine (e.Current);
			
			
			}









			Console.WriteLine ("Hello World!");
		}
	}
}
