using Session_1.Generics;

namespace Session_1
{
    internal class Program
    {
        static void Main(string[] args)
        {

			#region Before Generics & Generics Method

			//// int
			//int A = 5;
			//int B = 10;
			//Console.WriteLine($"A = {A}");
			//Console.WriteLine($"B = {B}");
			//Helper.Swap/*<int>*/(ref A, ref B);
			//Console.WriteLine("After Swaping");
			//Console.WriteLine($"A = {A}");
			//Console.WriteLine($"B = {B}");

			//// double
			//double X = 5;
			//double Z = 10;
			//Console.WriteLine($"X = {X}");
			//Console.WriteLine($"Z = {Z}");
			//Helper.Swap/*<double>*/(ref X, ref Z);
			//Console.WriteLine("After Swaping");
			//Console.WriteLine($"X = {X}");
			//Console.WriteLine($"Z = {Z}");

			//// point
			//Points M = new Points(5, 10);
			//Points N = new Points(10, 20);
			//Console.WriteLine($"M = {M}");
			//Console.WriteLine($"N = {N}");
			//Helper.Swap/*<point>*/(ref M, ref N);
			//Console.WriteLine("After Swaping");
			//Console.WriteLine($"M = {M}");
			//Console.WriteLine($"N = {N}");

			#endregion

			#region After Generics & Generics Method

			//// int
			//int A = 5;
			//int B = 10;
			//Console.WriteLine($"A = {A}");
			//Console.WriteLine($"B = {B}");
			//Helper.Swap<int>(ref A, ref B);
			//Console.WriteLine("After Swaping");
			//Console.WriteLine($"A = {A}");
			//Console.WriteLine($"B = {B}");

			//// double
			//double X = 5;
			//double Z = 10;
			//Console.WriteLine($"X = {X}");
			//Console.WriteLine($"Z = {Z}");
			//Helper.Swap<double>(ref X, ref Z);
			//Console.WriteLine("After Swaping");
			//Console.WriteLine($"X = {X}");
			//Console.WriteLine($"Z = {Z}");

			//// point
			//Points M = new Points(5, 10);
			//Points N = new Points(10, 20);
			//Console.WriteLine($"M = {M}");
			//Console.WriteLine($"N = {N}");
			//Helper.Swap<Points>(ref M, ref N);
			//Console.WriteLine("After Swaping");
			//Console.WriteLine($"M = {M}");
			//Console.WriteLine($"N = {N}");

			#endregion

			#region After Generics & Generics Class

			//// int
			//int A = 5;
			//int B = 10;
			//Console.WriteLine($"A = {A}");
			//Console.WriteLine($"B = {B}");
			//Helper2<int>.Swap(ref A, ref B);
			//Console.WriteLine("After Swaping");
			//Console.WriteLine($"A = {A}");
			//Console.WriteLine($"B = {B}");

			//// double
			//double X = 5;
			//double Z = 10;
			//Console.WriteLine($"X = {X}");
			//Console.WriteLine($"Z = {Z}");
			//Helper2<double>.Swap(ref X, ref Z);
			//Console.WriteLine("After Swaping");
			//Console.WriteLine($"X = {X}");
			//Console.WriteLine($"Z = {Z}");

			//// point
			//Points M = new Points(5, 10);
			//Points N = new Points(10, 20);
			//Console.WriteLine($"M = {M}");
			//Console.WriteLine($"N = {N}");
			//Helper2<Points>.Swap(ref M, ref N);
			//Console.WriteLine("After Swaping");
			//Console.WriteLine($"M = {M}");
			//Console.WriteLine($"N = {N}");

			#endregion

			#region Search on value in [] int without generic
			//int[] arr = { 10, 20, 30, 1, 2, 3 };
			//int value = Helper.SearchArray(arr, 30);
			//Console.WriteLine(value);
			#endregion

			#region Search on value in [] int with generic

			//int[] arr = { 10, 20, 30, 1, 2, 3 };
			//int value = Helper2<int>.SearchArray(arr, 30);
			//Console.WriteLine(value);

			#endregion

			#region Search on object from type struct in [] with generic → Generic IComparable

			//EmployeeStruct emp1 = new EmployeeStruct()
			//{
			//    Id = 1,
			//    Name = "Ali",
			//    Salary = 20_000
			//};
			//EmployeeStruct emp2 = new EmployeeStruct()
			//{
			//    Id = 2,
			//    Name = "Mai",
			//    Salary = 10_000
			//};
			//EmployeeStruct emp3 = new EmployeeStruct()
			//{
			//    Id = 3,
			//    Name = "Mia",
			//    Salary = 15_000
			//};

			//EmployeeStruct[] employees =
			//{
			//    emp1, emp2, emp3,
			//};

			//int res = Helper2<EmployeeStruct>.SearchArray(employees, emp1);
			//Console.WriteLine(res);


			//if (emp1 == emp2)
			//{
			//    Console.WriteLine("EQual");
			//}
			//else
			//{
			//    Console.WriteLine("Not EQual");
			//}

			// or

			//if (emp1.Equals(emp2))
			//{
			//	Console.WriteLine("Equals");
			//}
			//else
			//{
			//	Console.WriteLine("Not Equals");
			//}

			#endregion

			#region Search on object from type class in [] with generic → Generic IComparable

			//// in Class u must override on Equals() but in struct doesn't matter

			//EmplyeeClass emp1 = new EmplyeeClass()
			//{
			//	Id = 1,
			//	Name = "Ali",
			//	Salary = 20_000
			//};
			//EmplyeeClass emp2 = new EmplyeeClass()
			//{
			//	Id = 1,
			//	Name = "Ali",
			//	Salary = 20_000
			//};
			//EmplyeeClass emp3 = new EmplyeeClass()
			//{
			//	Id = 3,
			//	Name = "Mia",
			//	Salary = 15_000
			//};

			//EmplyeeClass[] employees =
			//{
			//		emp1, emp2, emp3,
			//	};

			//int res = Helper2<EmplyeeClass>.SearchArray(employees, emp1);
			//Console.WriteLine(res);


			//if (emp1.Equals(emp2))
			//{
			//	Console.WriteLine("Equals");
			//}
			//else
			//{
			//	Console.WriteLine("Not Equals");
			//}

			#endregion

			#region BubbleSort 0n objects from type EmplyeeClass  → Generic IComparable

			//EmplyeeClass emp1 = new EmplyeeClass()
			//{
			//	Id = 1,
			//	Name = "Ali",
			//	Salary = 20_000
			//};
			//EmplyeeClass emp2 = new EmplyeeClass()
			//{
			//	Id = 2,
			//	Name = "Ali",
			//	Salary = 50_000
			//};
			//EmplyeeClass emp3 = new EmplyeeClass()
			//{
			//	Id = 3,
			//	Name = "Mia",
			//	Salary = 15_000
			//};
			//EmplyeeClass emp4 = new EmplyeeClass()
			//{
			//	Id = 4,
			//	Name = "omar",
			//	Salary = 25_000
			//};

			//EmplyeeClass[] employees =
			//{
			//			emp1, emp2, emp3,emp4
			//	};
			//Helper2<EmplyeeClass>.BubbleSort(employees); // EmplyeeClass must implement Icomparable
			//foreach (EmplyeeClass emp in employees)
			//{
			//	Console.WriteLine(emp);
			//}

			#endregion

			#region BubbleSort 0n objects from type points → Generic IComparable

			//Points[] points =
			//{
			//		new Points(1,2),
			//		new Points(2,3),
			//		new Points(3,4),
			//		new Points(4,5)
			//	};
			//Helper2<Points>.BubbleSort(points); // Points must implement Icomparable
			//foreach (Points point in points)
			//{
			//	Console.WriteLine(point);
			//}

			#endregion
		}

    }
}