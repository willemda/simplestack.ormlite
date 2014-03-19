using System;
namespace SimpleStack.OrmLite
{
	public interface INamingStrategy
	{
		string GetTableName(string name);
		string GetColumnName(string name);
	}
}
