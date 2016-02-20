using System;

namespace Task2
{


	class House
	{

		public int m_house_nr;
		public string m_street;


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


		public string getFamilieName()
		{
			return m_familie_name;
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
		
		}
	}






}
