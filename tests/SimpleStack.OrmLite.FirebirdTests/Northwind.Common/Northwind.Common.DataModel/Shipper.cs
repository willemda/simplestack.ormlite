﻿using SimpleStack.DataAnnotations;
using SimpleStack.DesignPatterns.Model;
using System.ComponentModel.DataAnnotations;
using System;

namespace Northwind.Common.DataModel
{
	[Alias("Shippers")]
	public class Shipper : IHasIntId, IHasId<int>
	{
		[Required]
		[Index(Unique = true)]
		[StringLength(40)]
		public string CompanyName { get; set; }

		[Alias("ShipperID")]
		[AutoIncrement]
		public int Id { get; set; }

		[StringLength(24)]
		public string Phone { get; set; }

		public Shipper()
		{
		}
	}
}