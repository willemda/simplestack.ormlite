using System;
using SimpleStack.DataAnnotations;

namespace SimpleStack.Common.Tests.Models{
	
	[Alias("ModelWIF")]
	public class ModelWithIndexFields
	{
		public string AlbumId
		{
			get;
			set;
		}
	
		public string Id
		{
			get;
			set;
		}
	
		[Index]
		public string Name
		{
			get;
			set;
		}
	
		[Index(true)]
		public string UniqueName
		{
			get;
			set;
		}
	
		public ModelWithIndexFields()
		{
		}
	}
}