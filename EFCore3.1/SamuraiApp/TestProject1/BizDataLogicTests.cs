using ConsoleApp1;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SamuraiApp.Data;
using SamuraiApp.Domain;
using System.Diagnostics;
using System.Linq;

namespace TestProject1
{
	[TestClass]
	public class BizDataLogicTests
	{
		[TestMethod]
		public void AddMultipleSamuraisReturnsCorrectNumberOfInsertedRows()
		{
			var builder = new DbContextOptionsBuilder();
			builder.UseInMemoryDatabase("AddMultipleSamurais");

			using (var context = new SamuraiContext(builder.Options))
			{
				var bizlogic = new BusinessDataLogic(context);
				var nameList = new string[] { "Kikuchiyo", "kyuzo", "Rikchi"};
				var result = bizlogic.AddMultipleSamurais(nameList);
				Assert.AreEqual(nameList.Count(), result);
			}
		}

		[TestMethod]
		public void CanInsertSingleSamurai()
		{
			var builder = new DbContextOptionsBuilder();
			builder.UseInMemoryDatabase("InsertNewSamurai");

			using (var context = new SamuraiContext(builder.Options))
			{
				var bizlogic = new BusinessDataLogic(context);
				bizlogic.InsertNewSamurai(new Samurai());
			}
			using (var context2 = new SamuraiContext(builder.Options))
			{
				Assert.AreEqual(1, context2.Samurais.Count());
			}
		}
	}
}
