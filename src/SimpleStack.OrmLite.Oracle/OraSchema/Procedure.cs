using System;
using SimpleStack.DataAnnotations;
using SimpleStack.OrmLite.Oracle.DbSchema;

namespace SimpleStack.OrmLite.Oracle
{
	public class Procedure : IProcedure
	{
		public Procedure()
		{
		}

		[Alias("PROCEDURE_NAME")]
		public string ProcedureName { get; set; }

        [Alias("OBJECT_NAME")]
        public string FunctionName { get; set; }

		[Alias("OWNER")]
		public string Owner { get; set; }

        [Alias("OBJECT_TYPE")]
        public string ObjectType { get; set; }

		//[Alias("INPUTS")]
		//public Int16 Inputs { get; set; }

		//[Alias("OUTPUTS")]
		//public Int16 Outputs { get; set; }

		[Ignore]
		public ProcedureType Type
		{
			get
			{
                return ProcedureType.Executable;
				//return Outputs == 0 ? ProcedureType.Executable : ProcedureType.Selectable;
			}
		}
	}
}

