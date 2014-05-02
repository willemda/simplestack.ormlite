using SimpleStack.OrmLite.Oracle;

namespace SimpleStack.OrmLite
{
	public static class OracleDialect
	{
		public static IOrmLiteDialectProvider Provider
		{
			get { return OracleOrmLiteDialectProvider.Instance; }
		}
	}
}