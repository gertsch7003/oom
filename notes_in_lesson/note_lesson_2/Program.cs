using System;





namespace note_lesson_2
{
	class Buch
	{
		//public = jeder darf in dieses Feld preis reinschreiben
		//public double preis;

		// man sieht nur in aktueller klasse
		//private double preis;

		private string titel;
		private decimal preis;

		public Buch(string derTitel, decimal derPreis)
		{

			titel = derTitel;
			SetPreis(derPreis);



		}



		public string ISBN { get; private set;}




		public string Titel
		{

			get {
				return titel;
			}
			set{
				if (string.IsNullOrEmpty (value) || value.Length < 3) {
					throw new Exception ("muss groesser 3 sein");
				}
			}
		



		public decimal GetPreis()
		{

			return preis;

		}


		public void SetPreis(decimal neuerPreis)
		{

			if (neuerPreis < 0) throw new Exception ("Preis muss positiv sein");
			preis = neuerPreis;

		}





	}



	class Programm
	{




		static void Main(string[] args)
		{


			var a = new Buch (9);

			a.SetPreis (100);



		

			Console.WriteLine (a.GetPreis());


		}






	}




}
