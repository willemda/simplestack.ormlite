﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using NUnit.Framework;
using SimpleStack.DataAnnotations;
using SimpleStack.DesignPatterns.Model;
using SimpleStack.OrmLite.MySql.DataAnnotations;

namespace SimpleStack.OrmLite.MySql.Tests
{
	[TestFixture]
	public class StringColumnTests
		: OrmLiteTestBase
	{
		[Test]
		public void Can_create_primary_key_varchar_with_string_length_255()
		{
			using (var db = OpenDbConnection())
			{
				db.CreateTable<TypeWithStringId_255>(true);
			}
		}

		[Test]
		public void Can_create_primary_key_varchar_without_setting_string_length()
		{
			using (var db = OpenDbConnection())
			{
				db.CreateTable<TypeWithStringId>(true);
			}
		}

		[Test]
		public void Can_create_unique_key_on_varchar_without_setting_string_length()
		{
			using (var db = OpenDbConnection())
			{
				db.CreateTable<TypeWithUniqeKeyOnVarchar>(true);
			}
		}

		[ExpectedException(typeof (MySqlException))]
		[Test]
		public void Cannot_create_unique_key_on_varchar_greater_than_255()
		{
			using (var db = OpenDbConnection())
			{
				db.CreateTable<TypeWithUniqeKeyOnVarchar_256>(true);
			}
		}

		[ExpectedException(typeof (MySqlException))]
		[Test]
		public void Cannot_create_primary_key_varchar_with_string_length_greater_than_255()
		{
			using (var db = OpenDbConnection())
			{
				db.CreateTable<TypeWithStringId_256>(true);
			}
		}

		[Test]
		public void Can_store_and_retrieve_string_with_8000_characters_from_varchar_field()
		{
			using (var db = OpenDbConnection())
			{
				db.CreateTable<TypeWithStringId>(true);

				var obj = new TypeWithStringId
					          {
						          Id = "a",
						          Value = CreateString(8000)
					          };

				Assert.AreEqual(8000, obj.Value.Length);

				db.Save(obj);
				var target = db.GetById<TypeWithStringId>(obj.Id);

				Assert.AreEqual(obj.Value, target.Value);
				Assert.AreEqual(8000, obj.Value.Length);
			}
		}

		[Test]
		public void Can_store_and_retrieve_string_with_8000_characters_from_text_field()
		{
			using (var db = OpenDbConnection())
			{
				db.CreateTable<TypeWithTextField>(true);

				var obj = new TypeWithTextField()
					          {
						          Value = CreateString(8000)
					          };

				Assert.AreEqual(8000, obj.Value.Length);

				db.Save(obj);
				obj.Id = (int) db.GetLastInsertId();

				var target = db.GetById<TypeWithTextField>(obj.Id);

				Assert.AreEqual(obj.Value, target.Value);
				Assert.AreEqual(8000, obj.Value.Length);
			}
		}

		#region classes

		private class TypeWithUniqeKeyOnVarchar
		{
			public int Id { get; set; }

			[Index(true)]
			public string Value { get; set; }
		}

		private class TypeWithUniqeKeyOnVarchar_256
		{
			public int Id { get; set; }

			[StringLength(256)]
			[Index(true)]
			public string Value { get; set; }
		}

		private class TypeWithStringId : IHasStringId
		{
			public string Id { get; set; }

			[StringLength(8000)]
			public string Value { get; set; }
		}

		private class TypeWithUniqueIndexOnTextField
		{
			[AutoIncrement]
			public int Id { get; set; }

			[Index(true)]
			[Text]
			public string Value { get; set; }
		}

		private class TypeWithTextField
		{
			[AutoIncrement]
			public int Id { get; set; }

			[Text]
			public string Value { get; set; }
		}

		private class TypeWithStringId_255 : IHasStringId
		{
			[StringLength(255)]
			public string Id { get; set; }

			public string Value { get; set; }
		}

		private class TypeWithStringId_256 : IHasStringId
		{
			[StringLength(256)]
			public string Id { get; set; }

			public string Value { get; set; }
		}

		#endregion

		private static string CreateString(int length)
		{
			const string loremIpsum =
				"Lorem ipsum dolor sit amet, consetetur sadipscing elitr, sed diam nonumy eirmod tempor invidunt ut labore et dolore magna aliquyam erat, sed diam voluptua. At vero eos et accusam et justo duo dolores et ea rebum. Stet clita kasd gubergren, no sea takimata sanctus est Lorem ipsum dolor sit amet. Lorem ipsum dolor sit amet, consetetur sadipscing elitr, sed diam nonumy eirmod tempor invidunt ut labore et dolore magna aliquyam erat, sed diam voluptua. At vero eos et accusam et justo duo dolores et ea rebum. Stet clita kasd gubergren, no sea takimata sanctus est Lorem ipsum dolor sit amet.";

			var retVal = "";

			for (int i = 0; i < length/loremIpsum.Length; i++)
				retVal += loremIpsum;

			return retVal + loremIpsum.Substring(0, length - retVal.Length);
		}
	}
}