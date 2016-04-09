using System;
using NUnit.Framework;
using Task6;

namespace Task6
{


	[TestFixture]
	public class Tests
	{

		[Test]
		public void CanCreateHouse()
		{
			var x = new House(11, "Hauptstraße", "Hummer");
			Assert.IsTrue(x.house_nr == 11);
			Assert.IsTrue(x.street == "Hauptstraße");

		}

		[Test]
		public void CanGetFamilieName()
		{
			var x = new House(11, "Hauptstraße", "Hummer");
			Assert.IsTrue(x.getFamilieName() == "Hummer");
		}

		[Test]
		public void ItIsNotPossibleToCreateNegativHouseNumbers()
		{
			Assert.Catch(() =>
				{
					var x = new House(-11, "Hauptstraße", "Hummer");

				});

		}

		[Test]
		public void ItIsNotPossibleToleaveFamilieNameBlank()
		{
			Assert.Catch(() =>
				{
					var x = new House(11, "Hauptstraße", "");

				});

		}

		[Test]
		public void ItIsNotPossibleToleaveStreetNameBlank()
		{
			Assert.Catch(() =>
				{
					var x = new House(11, "", "Hummer");

				});

		}



		[Test]
		public void CanCreateAdds()
		{
			var x = new Adds(11, "Hauptstraße", "Hummer", "Billa");
			Assert.IsTrue(x.house_nr == 11);
			Assert.IsTrue(x.street == "Hauptstraße");
			Assert.IsTrue(x.getFamilieName() == "Hummer");
			Assert.IsTrue(x.get_adds() == "Billa");

		}



		[Test]
		public void ItIsNotPossibleToleaveAddsBlank()
		{
			Assert.Catch(() =>
				{
					var x = new Adds(11, "Hauptstraße", "Hummer", "");

				});

		}


		[Test]
		public void ItIsNotPossibleToleaveAddsFamNameBlank()
		{
			Assert.Catch(() =>
				{
					var x = new Adds(11, "Hauptstraße", "", "Billa");

				});

		}



	}
}

