using System.Collections.Generic;

namespace Session_3_Delegate
{

	// Step 0 : Delegate Decleration
	public delegate int StringFunctionDelegate(string str);
	/// New Class (Delegate), Any Reference From this Delegate Can Refer to Function or more 
	/// These Functions may be Static Function (Class Member Method) or NonStatic Function(Object Member Method)
	/// But These Functions must be with the same signature of The Delegate : return int, take one parameter (string)
	/// Regardless function name ,Regardless Access modifiers

	//public delegate bool ConditionFuncsDelegate<T1>(T1 n); // == Predicate delegate 

	//public delegate bool ConditionFuncsDelegate(int x);
	//public delegate bool ConditionFuncsDelegate<T>(T x);


	internal class Program
	{
		#region EX4

		#region more than function (not efficient)

		public static List<int> GetOddNumbers(List<int> list)
		{
			List<int> result = new List<int>();

			if (list != null)
				for (int i = 0; i < list.Count; i++)
					if (list[i] % 2 == 1)
						result.Add(list[i]);
			return result;
		}
		public static List<int> GeEvenNumbers(List<int> list)
		{
			List<int> result = new List<int>();

			if (list != null)
				for (int i = 0; i < list.Count; i++)
					if (list[i] % 2 == 0)
						result.Add(list[i]);
			return result;
		}
		public static List<int> GetNumbersDividedby7(List<int> list)
		{
			List<int> result = new List<int>();

			if (list != null)
				for (int i = 0; i < list.Count; i++)
					if (list[i] % 7 == 0)
						result.Add(list[i]);
			return result;
		}

		#endregion

		#region function take another function as a parameter (Delegate)

		//public static List<T> GetElementBasedOnPassedFunction<T>(List<T> list, ConditionFuncsDelegate<T> conditionFuncsDelegate)
		//{
		//    List<T> result = new List<T>();

		//    if (list != null && conditionFuncsDelegate != null)
		//        for (int i = 0; i < list.Count; i++)
		//            //if (list[i] % 2 == 1)
		//            if (conditionFuncsDelegate(list[i]) == true)
		//                result.Add(list[i]);
		//    return result;
		//}

		public static List<T> GetElementBasedOnPassedFunction<T>(List<T> list, /*ConditionFuncsDelegate<T>*/ Predicate<T> conditionFuncsDelegate)
		{
			List<T> result = new List<T>();

			if (list != null && conditionFuncsDelegate != null)
				for (int i = 0; i < list.Count; i++)
					//if (list[i] % 2 == 1)
					if (conditionFuncsDelegate(list[i]) == true)
						result.Add(list[i]);
			return result;
		}
		#endregion

		#endregion

		#region trikaya

		public static Action Test()
		{
			return () => { Console.WriteLine("Action"); };
		}

		#endregion

		static void Main(string[] args)
		{
			/// Delegate is a c# Language Feature
			/// Has 2 Usages:
			/// 1. Pointer To Function
			/// 2. Event-Driven Programming

			#region Ex1

			//// Step 1 : Declare Reference from Delegate
			//StringFunctionDelegate stringFunctionDelegate;

			//// Step 2 : Intialize The Reference (pointer to function)
			//stringFunctionDelegate = new StringFunctionDelegate(StringFunction.GetCountOfUpperChars);
			//stringFunctionDelegate = StringFunction.GetCountOfUpperChars; // Syntax Sugar
			//stringFunctionDelegate += StringFunction.GetCountOfLowerChars; // this Delegate Refer more than Function
			//stringFunctionDelegate -= StringFunction.GetCountOfLowerChars; // this Delegate had become refer to GetCountOfUpperChars Function only


			//// Step 3 : Use The Delegate Reference ( Call Method )
			//int Res = stringFunctionDelegate.Invoke("Ahmed Ali");
			//Console.WriteLine(Res);

			#endregion

			#region EX2

			//int[] numbers = { 5, 10, 8, 2, -1, 0, 1, 2, 3 };
			//SortingAlgorithm<int>.BubbleSort(numbers, CompareFunctions.CompareLess);
			//foreach (int i in numbers)
			//{
			//    Console.WriteLine(i);
			//}

			#endregion

			#region EX3

			//string[] Names = { "Ali", "Omar", "Mahmoud", "Kareem" };
			//SortingAlgorithm<string>.BubbleSort(Names, CompareFunctions.SortDesc);
			//foreach (string s in Names)
			//{
			//    Console.WriteLine(s);
			//}

			#endregion

			#region EX4

			#region No Delegate

			//List<int> list = Enumerable.Range(0, 100).ToList(); // from 0 to 99
			//List<int> OddNumbersList = GetOddNumbers(list);

			//foreach (int odd in OddNumbersList)
			//{
			//    Console.Write($"{odd} ");
			//}

			#endregion

			#region Delegate

			//List<int> list = Enumerable.Range(0, 100).ToList(); // from 0 to 99
			//ConditionFuncsDelegate conditionFuncsDelegate = ConditionFunctions.CheckOdd;
			//List<int> OddNumbersList = GetElementBasedOnPassedFunction(list, conditionFuncsDelegate);

			//foreach (int odd in OddNumbersList)
			//{
			//    Console.Write($"{odd} ");
			//}

			#endregion

			#endregion

			#region EX5

			//List<string> list = new List<string>() { "Ali", "Omar", "Mahmoud", "Kareem" };
			//List<string> NamesHaveLengthMoreThan4 = GetElementBasedOnPassedFunction/*<string>*/(list, ConditionFunctions.CheckLength);
			//foreach (string name in NamesHaveLengthMoreThan4)
			//{
			//    Console.WriteLine(name);
			//}

			#endregion

			#region Built-in Delegates → Predicate, Func, Action and Anonymous Method, Lambada Expression

			//// 1. Predicate

			//Predicate<int> predicate = StringFunction.Test;
			//Predicate<int> predicate = delegate (int X) { return X > 0; };    // Anonymous Method 
			//Predicate<int> predicate = (X) => X > 0;                            // Lambada Expression, => Goes To
			// var predicate = (int X) => X > 0;       // New feature, New Update for Delegate : C # 10.0 ( .Net 6 [2021] )
			// var is Syntax Sugar To Predicate<int>

			//predicate.Invoke(10);
			//predicate(10);



			////2.Func

			//Func<int, string> func = StringFunction.Cast;
			//Func<int, string> func = delegate (int x) { return x.ToString(); };   // Anonymous Method
			//Func<int, string> func = (x) => x.ToString();                           // Lambada Expression, => Goes To
			//var func = (int x) => x.ToString();         // New feature, New Update for Delegate : C # 10.0 ( .Net 6 [2021] )
			// var is Syntax Sugar To Func<int, string>

			//func.Invoke(10);
			//func(10);



			//3.Action

			//Action action = StringFunction.Print;
			//Action action = delegate { Console.WriteLine("print"); };          // Anonymous Method
			//Action action = () =>  Console.WriteLine("print");                   // Lambada Expression, => Goes To
			//var action = () => Console.WriteLine("print");   // New feature, New Update for Delegate : C # 10.0 ( .Net 6 [2021] )
			// var is Syntax Sugar To Action

			//action.Invoke();
			//action();


			#endregion

			#region Some List_Methods That Take Functions As Parameters

			//List<int> Numbers = Enumerable.Range(0, 100).ToList();
			//List<int> OddNumbers1 = Numbers.FindAll(number => number % 2 == 0);
			//int odd = Numbers.Find((N) => N % 2 == 1); Console.WriteLine(odd);

			//Numbers.ForEach(number => { Console.WriteLine(number + 10); });
			//Numbers.RemoveAll(number => number % 5 == 0);

			#endregion

			#region Summary

			//List<int> Numbers = Enumerable.Range(0, 100).ToList();

			//List<int> OddNumbers = GetElementBasedOnPassedFunction(Numbers, ConditionFunctions.CheckOdd);
			//          OddNumbers = GetElementBasedOnPassedFunction(Numbers, delegate (int x) { return x % 2 == 1; }); // Anonymous Method
			//          OddNumbers = GetElementBasedOnPassedFunction(Numbers, (Number) => Number == 1);  // Lambada Expression, => Goes To
			//          OddNumbers = Numbers.FindAll((Number) => Number == 1); // Biult-in Function

			//foreach (int odd in OddNumbers)
			//{
			//	Console.Write($"{odd}  ");
			//}

			#endregion

			#region trikaya

			//Test()();

			#endregion

		}
	}
	class StringFunction
	{
		public static bool Test(int X) { return X > 0; }
		public static string Cast(int x) { return x.ToString(); }
		public static void Print() { Console.WriteLine("print"); }

		public static int GetCountOfUpperChars(string Name)
		{
			int count = 0;
			if (Name != null)
				for (int i = 0; i < Name.Length; i++)
					if (Char.IsUpper(Name[i]))
						count++;
			return count;
		}

		public static int GetCountOfLowerChars(string Name)
		{
			int count = 0;
			if (Name != null)
				for (int i = 0; i < Name.Length; i++)
					if (Char.IsLower(Name[i]))
						count++;
			return count;
		}
	}

	class ConditionFunctions
	{
		public static bool CheckEven(int element) { return element % 2 == 0; }
		public static bool CheckOdd(int element) { return element % 2 == 1; }
		public static bool checkdivvidedBy7(int element) { return element % 7 == 0; }
		public static bool CheckLength(string Name) { return Name?.Length > 4; }

	}
}