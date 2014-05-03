using System;

namespace SimpleStack.DataAnnotations
{
	/// <summary>
	/// Decimal length attribute.
	/// 
	/// </summary>
	[AttributeUsage(AttributeTargets.Property)]
	public class DecimalLengthAttribute : Attribute
	{
		public int Precision { get; set; }
		public int Scale { get; set; }

		public DecimalLengthAttribute(int precision, int scale)
		{
			Precision = precision;
			Scale = scale;
		}

		public DecimalLengthAttribute(int precision) : this(precision, 0)
		{
		}

		public DecimalLengthAttribute() : this(18, 0)
		{
		}
	}
}