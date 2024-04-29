using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_1.Generics
{
	// Equals() ==> IN class compare (references - addresses) Identity.

	internal class EmplyeeClass : IComparable<EmplyeeClass>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Salary { get; set; }

        public override string ToString()
        {
            return $"Id : {Id},Name : {Name}, Salary : {Salary} ";
        }

        public override bool Equals(object? obj)
        {
            EmplyeeClass PassedEmplyee = (EmplyeeClass)obj;
            return (this.Id == PassedEmplyee.Id && this.Name == PassedEmplyee.Name && this.Salary == PassedEmplyee.Salary);
        }

        //public int CompareTo(object? obj)
        //{
        //    EmplyeeClass passedEmp = (EmplyeeClass)obj;

        //    //if (this.Salary > passedEmp.Salary) { return 1; }

        //    //else if (this.Salary < passedEmp.Salary) { return -1; }
        //    //else { return 0; }

        //    return this.Salary.CompareTo(passedEmp.Salary);
        //    // This line in stead of the last 3 lines because salary from type "double" and double have compareTo function
        //}

        public int CompareTo(EmplyeeClass? other)
        {
            return this.Salary.CompareTo(other.Salary);
        }
    }
}
