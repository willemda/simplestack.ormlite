using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using NUnit.Framework;

namespace SimpleStack.OrmLite.MySql.Tests.UseCase
{
	[TestFixture]
	public class SimpleUseCase
	{
		[TestFixtureSetUp]
		public void TestFixtureSetUp()
		{
			//Inject your database provider here
			OrmLiteConfig.DialectProvider = MySqlDialectProvider.Instance;
		}

		public class User
		{
			public long Id { get; set; }

			[SimpleStack.DataAnnotations.Index]
			public string Name { get; set; }

			public DateTime CreatedDate { get; set; }
		}

		[Test]
		public void Simple_CRUD_example()
		{
			using (IDbConnection db = ConfigurationManager.ConnectionStrings["testDb"].ConnectionString.OpenDbConnection())
			{
				db.CreateTable<User>(true);

				db.Insert(new User {Id = 1, Name = "A", CreatedDate = DateTime.Now});
				db.Insert(new User {Id = 2, Name = "B", CreatedDate = DateTime.Now});
				db.Insert(new User {Id = 3, Name = "B", CreatedDate = DateTime.Now});

				var rowsB = db.Select<User>("Name = {0}", "B");

				Assert.That(rowsB, Has.Count.EqualTo(2));

				var rowIds = rowsB.ConvertAll(x => x.Id);
				Assert.That(rowIds, Is.EquivalentTo(new List<long> {2, 3}));

				rowsB.ForEach(x => db.Delete(x));

				rowsB = db.Select<User>("Name = {0}", "B");
				Assert.That(rowsB, Has.Count.EqualTo(0));

				var rowsLeft = db.Select<User>();
				Assert.That(rowsLeft, Has.Count.EqualTo(1));

				Assert.That(rowsLeft[0].Name, Is.EqualTo("A"));
			}
		}
	}
}