using System;
using SimpleStack.DataAnnotations;

namespace SimpleStack.Common.Tests.Models{
	
	[Alias("ModelWLISF")]
	public class ModelWithLongIdAndStringFields
	{
		public string AlbumId
		{
			get;
			set;
		}
	
		public string AlbumName
		{
			get;
			set;
		}
	
		public long Id
		{
			get;
			set;
		}
	
		public string Name
		{
			get;
			set;
		}
	
		public ModelWithLongIdAndStringFields()
		{
		}
	}
}