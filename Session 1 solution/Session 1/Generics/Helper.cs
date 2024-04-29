using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_1.Generics
{
	internal class Helper
	{
		#region Before Generics
		public static void Swap(ref int x, ref int y)
		{
			int temp = x;
			x = y;
			y = temp;
		}

		public static void Swap(ref double x, ref double y)
		{
			double temp = x;
			x = y;
			y = temp;
		}
		public static void Swap(ref Points x, ref Points y)
		{
			Points temp = x;
			x = y;
			y = temp;
		}

		#endregion

		#region Generics

		// Generic Method
		// In case GenericType "T" is Declared on Method Level , Not Class
		// Compiler will Destect The Type of T Based on Input Parameters
		public static void Swap<T>(ref T x, ref T y)
		{
			T temp = x;
			x = y;
			y = temp;
		}

		#endregion

		#region Search on value in [] int
		public static int SearchArray(int[] arr, int Value)
		{
			if (arr != null)
			{
				for (int i = 0; i < arr.Length; i++)
				{
					if (Value == arr[i])
					{
						return i;
					}
				}
			}
			return -1;
		}
		#endregion
	}


	#region Generic class 

	internal class Helper2<T> where T : IComparable<T>
	{
		#region Swap Function

		public static void Swap(ref T x, ref T y)
		{
			T temp = x;
			x = y;
			y = temp;
		}

		#endregion

		#region Search on value in [] any Data Type <T>

		public static int SearchArray(T[] arr, T Value)
		{
			if (arr != null && Value != null)
			{
				for (int i = 0; i < arr.Length; i++)
				{
					//if (Value == arr[i]) 
					//{
					//    return i;
					//}

					// == not implemented in all Data Types, and you don't Oblige user to send Data Type Has == implementation
					// So we Use Equals() Because exists in All Data Types inherited from object
					// if you want use == must write Operator Overloading in User-difiendstruct So we use Equals() better than ==

					// == and Equals() implemented in Class but compare (references - addresses) Identity.
					// So we override on Equals() in class to compare Data and leave == to compare refrences

					if (Value.Equals(arr[i]))
					{
						return i;
					}
				}
			}
			return -1;
		}

		#endregion

		#region BubbleSort

		public static void BubbleSort(T[] arr)
		{
			if (arr is not null)
			{
				for (int i = 0; i < arr.Length; i++)
				{
					for (int j = 0; j < arr.Length - i - 1; j++)
					{
						if (arr[j].CompareTo(arr[j + 1]) == 1)
						{
							Swap(ref arr[j], ref arr[j + 1]); // where T : IComparable
						}
					}
				}
			}
		}

		#endregion
	}

	#endregion
}
