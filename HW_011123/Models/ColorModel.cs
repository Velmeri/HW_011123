﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_011123.Models
{
	public class ColorModel
	{
		public byte Alpha { get; set; }
		public byte Red { get; set; }
		public byte Green { get; set; }
		public byte Blue { get; set; }

		public ColorModel() { 
			Alpha = 0;
			Red = 0;
			Green = 0;
			Blue = 0;
		}

		public ColorModel(byte alpha, byte red, byte green, byte blue)
		{
			Alpha = alpha;
			Red = red;
			Green = green;
			Blue = blue;
		}

		public static bool operator ==(ColorModel A, ColorModel B)
		{
			return
				A.Alpha == B.Alpha &&
				A.Blue == B.Blue &&
				A.Red == B.Red &&
				A.Green == B.Green;
		}
		public static bool operator !=(ColorModel A, ColorModel B)
		{
			return 
				A.Alpha != B.Alpha ||
				A.Blue != B.Blue ||
				A.Red != B.Red ||
				A.Green	!= B.Green;
		}

		public override bool Equals(object obj)
		{
			return obj is ColorModel model &&
				   Alpha == model.Alpha &&
				   Red == model.Red &&
				   Green == model.Green &&
				   Blue == model.Blue;
		}

		public override int GetHashCode()
		{
					int hashCode = -1096401256;
					hashCode = hashCode * -1521134295 + Alpha.GetHashCode();
					hashCode = hashCode * -1521134295 + Red.GetHashCode();
					hashCode = hashCode * -1521134295 + Green.GetHashCode();
					hashCode = hashCode * -1521134295 + Blue.GetHashCode();
					return hashCode;
				}

		public override string ToString() 
		{
			return $"Alpha: {Alpha}, Blue: {Blue}, Red {Red}, Green: {Green}";
		}
	}
}
