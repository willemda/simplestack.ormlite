using System;
using System.Configuration;
using System.Data;
using System.IO;
using NUnit.Framework;
using SimpleStack.Common.Utils;
using SimpleStack.Logging;
using SimpleStack.Logging.Support.Logging;
using SimpleStack.OrmLite.PostgreSQL;


namespace SimpleStack.OrmLite.Tests
{
	public class OrmLiteTestBase
	{
		protected virtual string ConnectionString { get; set; }

		[TestFixtureSetUp]
		public void TestFixtureSetUp()
		{
			LogManager.LogFactory = new ConsoleLogFactory();

		    OrmLiteConfig.DialectProvider =  PostgreSQLDialectProvider.Instance;
			OrmLiteConfig.DialectProvider.NamingStrategy = new OrmLiteNamingStrategyBase();
			OrmLiteConfig.ClearCache();
		    ConnectionString = ConfigurationManager.ConnectionStrings["testDb"].ConnectionString;
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