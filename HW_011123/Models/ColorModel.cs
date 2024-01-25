using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_011123.Models
{
	public class ColorModel : IEquatable<ColorModel>
	{
		/// <summary>
		/// Представляет цвет в модели ARGB (Альфа, Красный, Зелёный, Синий).
		/// </summary>

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

		public static bool operator ==(ColorModel a, ColorModel b)
		{
			if (ReferenceEquals(a, b)) {
				return true;
			}

			if (ReferenceEquals(a, null) || ReferenceEquals(b, null)) {
				return false;
			}

			return a.Equals(b);
		}

		public static bool operator !=(ColorModel a, ColorModel b)
		{
			return !(a == b);
		}

		public override bool Equals(object obj)
		{
			if (obj is ColorModel other) {
				return Equals(other);
			}

			return false;
		}

		public bool Equals(ColorModel other)
		{
			if (other is null) {
				return false;
			}

			return Alpha == other.Alpha &&
				   Red == other.Red &&
				   Green == other.Green &&
				   Blue == other.Blue;
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
