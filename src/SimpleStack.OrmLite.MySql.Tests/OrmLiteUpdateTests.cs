//using NUnit.Framework;
//using SimpleStack.Common.Tests.Models;

//namespace SimpleStack.OrmLite.MySql.Tests
//{
//	[TestFixture]
//	public class OrmLiteUpdateTests
//		: OrmLiteTestBase
//	{

//		[Test]
//		public void Can_update_ModelWithFieldsOfDifferentTypes_table()
//		{
//			using (var db = OpenDbConnection())
//			{
//				db.CreateTable<ModelWithFieldsOfDifferentTypes>(true);

//				var row = ModelWithFieldsOfDifferentTypes.Create(1);

//				db.Insert(row);

//				row.Name = "UpdatedName";

//				db.Update(row);

//				var dbRow = db.GetById<ModelWithFieldsOfDifferentTypes>(1);

//				ModelWithFieldsOfDifferentTypes.AssertIsEqual(dbRow, row);
//			}
//		}

//	}
//}
