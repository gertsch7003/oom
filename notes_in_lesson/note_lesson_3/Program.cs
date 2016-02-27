using System;




namespace note_lesson_3
{



	class Person
	{

		public string Name { get; }

		public string Email { get; }


		// um das zu machen, muss die classe auch von abstract sein
		public abstract void DoSomething();


		//public virtuel void --> Kindklassen dürfen diese Methode ersetzen !!
		public virtual void DoSomethingCool()
		{

			Console.WriteLine ("COOOLE SACHE");

		}



	}


	class Kunde : Person
	{

		public int BonusPunkte { get; }

		// override braucht man um dann die Eltern Methode wirklich ersetzt
		public override void DoSomethingCool()
		{

			Console.WriteLine ("COOOLE SACHE -- different");

		}

	}




	class Angestellter : Person
	{

		public int SVN { get; }


	}






	class Programm
	{


//		public string Name
//		{
//
//			get { return "Sabeditsch";}
//
//		}

		public string Name => "Sabeditsch";



		public static double Sqr2(double x) => x * x;




		static double Sqr(double x)
		{

			return x * x;

		}


		static int[] Map(int[] data, Func<int, int> f )
		{

			var result = new int[data.Length];

			
			for (var i = 0; i < data.Length; i++) {
				result [i] = f (data [i]);
			}


			return result;

		}


		static T[] Map2<T>(int[] data, Func<int, int> f )
		{

			var result = new T[data.Length];


			for (var i = 0; i < data.Length; i++) {
				result [i] = f (data [i]);
			}


			return result;

		}



		public static void Main (string[] args)
		{

			var xs = new[] {1,2,3,4,5,6,7,8,9};

			var xsT = new[] {1.0,2,3,4,5,6,7,8,9};


			var ys = Map (xs, Sqr);

			var zs = Map2 (xsT,xx => xx + 1);



			var x = Math.Sin (Math.PI / 2);



			//Action  -- Wenn die Funktion keinen Rückgabewert besitzt
			Action<string> log = Console.WriteLine;

			// <Agumente uebergeben,Return Type>
			Func<double, double> f = Math.Sin;


			log ("HALLO");







			Console.WriteLine (x);
		}
	
	
	
	
	
	
	}








}
