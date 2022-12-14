using Microsoft.EntityFrameworkCore;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SamuraiApp.Data;
using SamuraiApp.Domain;
using System.Diagnostics;

namespace TestProject1
{
	[TestClass]
	public class InMemorryDatabaseTests
	{
		[TestMethod]
		public void CanInsertSamuraiIntoDatabase()
		{
			var builder = new DbContextOptionsBuilder();
			builder.UseInMemoryDatabase("CanInsertSamurai");

			using (var context = new SamuraiContext(builder.Options))
			{
				var samurai = new Samurai();
				context.Samurais.Add(samurai);
				Assert.AreEqual(EntityState.Added, context.Entry(samurai).State);
			}
		}
	}
}
