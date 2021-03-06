﻿using System;
using SimpleStack.DataAnnotations;
using SimpleStack.DesignPatterns.Model;
using System.ComponentModel.DataAnnotations;

namespace Northwind.Common.DataModel
{
	[Alias("Demographics")]
	public class CustomerDemographic : IHasStringId, IHasId<string>
	{
		public string CustomerDesc { get; set; }

		[StringLength(10)]
		[Alias("TypeID")]
		public string Id { get; set; }

		public CustomerDemographic()
		{
		}
	}
}