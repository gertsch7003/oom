using System;
using System.Collections.Generic;
using System.Globalization;
using Newtonsoft.Json;
using System.IO;


namespace Task4
{
	

	public interface ICity
	{

		string setFamilieName(string Name);

		string getFamilieName();


	}


	//old House Class integrates interface ICity
	class House :ICity
	{

		//Fields public
		private int m_house_nr;
		private string m_street;

		//Fields privat
		private string m_familie_name;


		//Constructor
		public House(int house_nr, string street, string familie_name)
		{
			if (house_nr < 0) throw new ArgumentException("House Number should be positiv", nameof(house_nr));
			if (street == "") throw new ArgumentException("House Number should be positiv", nameof(street));

			m_house_nr = house_nr;
			m_street = street;
			m_familie_name = setFamilieName(familie_name);

		}


		//Methode for Set m_familie_name
		public string setFamilieName(string Name)
		{

			if (Name == "") throw new ArgumentException("Family Name should be more than nothing", nameof(Name));
			m_familie_name = Name;
			return getFamilieName();
		}


		//Methode for get Familie Name
		public string getFamilieName()
		{
			return m_familie_name;
		}


		public int house_nr
		{

			get {
				return m_house_nr;
			}

		}


		public string street
		{

			get {
				return m_street;
			}

		}


	}



	//new Class Adds
	class Adds : ICity
	{

		//Fields public
		private int m_house_nr;
		private string m_street;

		//Fields privat
		private string m_familie_name;
		private string m_adds;



		//Constructor
		public Adds(int house_nr, string street, string familie_name, string new_add_name)
		{

			if (house_nr < 0) throw new ArgumentException("House Number should be positiv", nameof(house_nr));


			m_house_nr = house_nr;
			m_street = street;
			m_familie_name = setFamilieName(familie_name);
			set_adds(new_add_name);
		}


		//Methode for Set m_familie_name
		public string setFamilieName(string Name)
		{
			if (string.IsNullOrWhiteSpace(Name)) throw new ArgumentException("Name should be more than nothing", nameof(Name));

			m_familie_name = Name;
			return m_familie_name;
		}



		//Methode for get Familie Name
		public string getFamilieName()
		{
			return m_familie_name;
		}


		public void set_adds(string add_name)
		{
			if (string.IsNullOrWhiteSpace(add_name)) throw new ArgumentException("Advertisement Name should be more than nothing", nameof(add_name));
			//if (add_name == "") throw new ArgumentException("Advertisement Name should be more than nothing", nameof(add_name));
			m_adds = add_name;

		}


		public string get_adds()
		{

			Console.WriteLine("Advertisement Abo {0}",m_adds);

			return m_adds;
		}



		public int house_nr
		{

			get {
				return m_house_nr;
			}

		}


		public string street
		{

			get {
				return m_street;
			}

		}






	}



	class Programm
	{
		public static void Main (string[] args)
		{

			House myhouse = new House(11,"Hauptstraße","Hummer");


			Console.WriteLine ("\n\nHAUS_NR: {0}  STRASSE: {1}  Fam.Name: {2}\n\n",myhouse.house_nr,myhouse.street,myhouse.getFamilieName());


			Console.WriteLine ("Fam.Name geaendert auf: {0}",myhouse.setFamilieName("Baglawatsch"));


			Console.WriteLine ("\n\nHAUS_NR: {0}  STRASSE: {1}  Fam.Name: {2}\n\n",myhouse.house_nr,myhouse.street,myhouse.getFamilieName());




			Adds add1 = new Adds (12, "Uferstraße", "Neumaier", "Obbi");
			Adds add2 = new Adds (13, "Bahnstraße", "Hugo", "Billa");

			add1.get_adds();
			add2.get_adds();


			/*
			var items = new ICity[]
			{
				new House(1,"Hauptstraße","Hummer"),
				new House(5,"Bahnstraße","Sabeditsch"),
				new House(14,"Bahnstraße","Sabeditsch"),
				new Adds (12, "Uferstraße", "Neumaier", "Obbi"),
				new Adds (13, "Bahnstraße", "Hugo", "Billa"),

			};
			*/


			var items2 = new House[]
			{
				new House(1,"Hauptstraße","Hummer"),
				new House(5,"Bahnstraße","Sabeditsch"),
				new House(14,"Bahnstraße","Sabeditsch"),
			
			};
				

			var settings1 = new JsonSerializerSettings() { Formatting = Formatting.Indented, TypeNameHandling = TypeNameHandling.Auto };
			Console.WriteLine(JsonConvert.SerializeObject(items2, settings1));

		
			//string json = JsonConvert.SerializeObject(items2, settings1);

			//Console.WriteLine (json);


			// serialize JSON to a string and then write string to a file
			File.WriteAllText("/Users/gerhard/Downloads/temp_test1.txt", JsonConvert.SerializeObject(items2,settings1));



			var textFromFile = File.ReadAllText("/Users/gerhard/Downloads/temp_test1.txt");
			var re_items = JsonConvert.DeserializeObject<House[]>(textFromFile, settings1);


			Console.WriteLine ("\n\n{0}", re_items[0].house_nr);


		}
	


	
	}







}
