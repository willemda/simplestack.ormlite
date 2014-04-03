using System;
using SimpleStack.DataAnnotations;
using SimpleStack.OrmLite.Oracle.DbSchema;

namespace SimpleStack.OrmLite.Oracle
{
	public class Table : ITable
	{
		public Table()
		{
		}

        [Alias("TABLE_NAME")]
		public string Name { get; set; }

        [Alias("TABLE_SCHEMA")]
		public string Owner { get; set; }
	}
}

