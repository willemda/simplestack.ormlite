﻿using System;
using SimpleStack.OrmLite;
using System.IO;
using System.Data;
using SimpleStack.Common.Utils;
using SimpleStack.OrmLite.Sqlite;

namespace SqliteExpressionsTest
{
	public class CountTest
	{
		private static string GetFileConnectionString()
		{
			var connectionString = "~/db.sqlite".MapAbsolutePath();
			if (File.Exists(connectionString))
				File.Delete(connectionString);

			return connectionString;
		}

		public static void Test()
		{
			OrmLiteConfig.DialectProvider = SqliteOrmLiteDialectProvider.Instance;

			var path = GetFileConnectionString();
			if (File.Exists(path))
				File.Delete(path);
			//using (IDbConnection db = ":memory:".OpenDbConnection())
			using (IDbConnection db = path.OpenDbConnection())
			{
				db.CreateTable<User>(true);

				db.Insert(new User {Id = 1, Name = "A", CreatedDate = DateTime.Now, UserDataId = 5, UserServiceId = 8});
				db.Insert(new User {Id = 2, Name = "B", CreatedDate = DateTime.Now, UserDataId = 5, UserServiceId = 9});
				db.Insert(new User {Id = 3, Name = "B", CreatedDate = DateTime.Now});

				SqlExpressionVisitor<User> ev = OrmLiteConfig.DialectProvider.ExpressionVisitor<User>();

				var count1 = db.Count<User>(x => x.Id == 1);
				var count2 = db.Count<User>(ev.Where(x => x.Id == 2));
				var count3 = db.Count<User>();

				count1 = db.Count<User>(x => x.Id == 1);
				count2 = db.Count<User>(ev.Where(x => x.Id == 2));
				count3 = db.Count<User>();
			}

			File.Delete(path);
		}
	}
}