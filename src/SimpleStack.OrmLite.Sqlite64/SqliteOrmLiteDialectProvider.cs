using System.Data;
using System.Data.SQLite;

namespace SimpleStack.OrmLite.Sqlite
{
	public class SqliteOrmLiteDialectProvider : SqliteOrmLiteDialectProviderBase
	{
		// what's the purpose of this Instance field? (It's like a pseudo-wanna-be singleton?)
		public static SqliteOrmLiteDialectProvider Instance = new SqliteOrmLiteDialectProvider();

		protected override IDbConnection CreateConnection(string connectionString)
		{
			return new SQLiteConnection(connectionString, parseViaFramework: ParseViaFramework);
		}
	}
}