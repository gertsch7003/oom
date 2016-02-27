using System;

namespace Task3
{



	public interface ICity
	{

		string setFamilieName(string Name);

		string getFamilieName();


	}



	class House :ICity
	{

		//Fields public
		public int m_house_nr;
		public string m_street;

		//Fields privat
		private string m_familie_name;




		//Constructor
		public House(int house_nr, string street, string familie_name)
		{


			m_house_nr = house_nr;
			m_street = street;
			m_familie_name = setFamilieName(familie_name);

		}


		//Methode for Set m_familie_name
		public string setFamilieName(string Name)
		{
			m_familie_name = Name;


			return m_familie_name;
		}



		//Methode for get Familie Name
		public string getFamilieName()
		{
			return m_familie_name;
		}
			
	}




	class Adds : ICity
	{

		//Fields public
		public int m_house_nr;
		public string m_street;

		//Fields privat
		private string m_familie_name;
		private string[] m_adds;
	


		//Constructor
		public Adds(int house_nr, string street, string familie_name, string new_add_name)
		{


			m_house_nr = house_nr;
			m_street = street;
			m_familie_name = setFamilieName(familie_name);
			set_adds(new_add_name);
		}
			

		//Methode for Set m_familie_name
		public string setFamilieName(string Name)
		{
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

			m_adds = new string[1];

			m_adds[0] = add_name;

		}


		public void get_adds()
		{

			for(int i=0;i< m_adds.Length;i++)
			{
				Console.WriteLine("Add Abo {0} is {1}",i,m_adds[i]);
			}


		}




	}






	class Programm
	{
		public static void Main (string[] args)
		{

			House myhouse = new House(11,"Hauptstraße","Hummer");


			Console.WriteLine ("\n\nHAUS_NR: {0}  STRASSE: {1}  Fam.Name: {2}\n\n",myhouse.m_house_nr,myhouse.m_street,myhouse.getFamilieName());


			Console.WriteLine ("Fam.Name geaendert auf: {0}",myhouse.setFamilieName("Baglawatsch"));


			Console.WriteLine ("\n\nHAUS_NR: {0}  STRASSE: {1}  Fam.Name: {2}\n\n",myhouse.m_house_nr,myhouse.m_street,myhouse.getFamilieName());




			Adds add1 = new Adds (12, "Uferstraße", "Neumaier", "Obbi");

			add1.get_adds();



		}
	}







}
