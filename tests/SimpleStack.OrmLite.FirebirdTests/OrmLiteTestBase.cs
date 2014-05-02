using System;
using System.Configuration;
using System.Data;
using System.IO;
using System.Configuration;
using NUnit.Framework;
using SimpleStack.Common.Utils;
using SimpleStack.Logging;
using SimpleStack.Logging.Support.Logging;
using SimpleStack.OrmLite.Firebird;

namespace SimpleStack.OrmLite.FirebirdTests
{
	public class OrmLiteTestBase
	{
		protected virtual string ConnectionString { get; set; }

		protected string GetFileConnectionString()
		{
			return ConfigurationManager.ConnectionStrings["testDb"].ConnectionString;
		}

		protected void CreateNewDatabase()
		{
			ConnectionString = GetFileConnectionString();
		}

		[TestFixtureSetUp]
		public void TestFixtureSetUp()
		{
			LogManager.LogFactory = new ConsoleLogFactory();

			OrmLiteConfig.DialectProvider = FirebirdOrmLiteDialectProvider.Instance;
			ConnectionString = GetFileConnectionString();
		}

		public void Log(string text)
		{
			Console.WriteLine(text);
		}

		public IDbConnection OpenDbConnection(string connString = null)
		{
			connString = connString ?? ConnectionString;
			return connString.OpenDbConnection();
		}
	}
}