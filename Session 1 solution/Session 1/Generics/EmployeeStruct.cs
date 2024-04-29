using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_1.Generics
{
	// Equals() ==> IN Struct compare (Object State) actual values.

	public struct EmployeeStruct : IComparable<EmployeeStruct>
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public double Salary { get; set; }

		public override string ToString()
		{
			return $"Id : {Id},Name : {Name}, Salary : {Salary} ";
		}

		#region If u use operator overeloading but we use Equals() 

		public static bool operator ==(EmployeeStruct left, EmployeeStruct right)
		{
			return left.Equals(right);
			// return left.Id == right.Id && left.Name == right.Name && left.Salary == left.Salary;

		}
		public static bool operator !=(EmployeeStruct left, EmployeeStruct right)
		{
			return !left.Equals(right);
			// return left.Id != right.Id || left.Name != right.Name || left.Salary != left.Salary;
		}

		#endregion

		public int CompareTo(EmployeeStruct other)
		{
			return this.Salary.CompareTo(other.Salary);
		}


	}
}
