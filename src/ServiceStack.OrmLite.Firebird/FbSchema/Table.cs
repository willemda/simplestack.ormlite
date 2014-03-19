using System;
using SimpleStack.DataAnnotations;
using SimpleStack.OrmLite.Firebird.DbSchema;

namespace SimpleStack.OrmLite.Firebird
{
	public class Table : ITable
	{
		public Table()
		{
		}

		[Alias("NAME")]
		public string Name { get; set; }

		[Alias("OWNER")]
		public string Owner { get; set; }
	}
}

