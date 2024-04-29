using System.Collections;         // this namespace contaioin Non Generic Collection
using System.Collections.Generic; // this namespace contaioin  Generic Collection

namespace Session_2
{
    internal class Program
    {
        #region Non Generic Collections - ArrayList

        public static int SumArray(ArrayList arrayList)
        {
            int sum = 0;
            if (arrayList != null)
            {
                for (int i = 0; i < arrayList.Count; i++)
                {
                    sum += (int)arrayList[i]; // Casting from Object [ReferenceType] To int [ValueType] → UnBoxing
                                              // UnSafe Casting
                }
            }
            return sum;
        }

        #endregion

        #region Generic Collections - Listing (List)

        public static int SumList(List<int> list)
        {
            int sum = 0;
            if (list != null)
            {
                for (int i = 0; i < list.Count; i++)
                {
                    sum += list[i];
                }
            }
            return sum;
        }

        #endregion

        static void Main(string[] args)
        {
            #region Non Generic Collections - ArrayList

            //ArrayList arrayList = new ArrayList();

            //Console.WriteLine($"Count = {arrayList.Count}, Capacity = {arrayList.Capacity}"); // Count = 0, Capacity = 0

            //arrayList.Add(1);
            //arrayList.Add(2);

            //Console.WriteLine($"Count = {arrayList.Count}, Capacity = {arrayList.Capacity}"); // Count = 2, Capacity = 4

            //arrayList.Add(3);
            //arrayList.Add(4);

            //Console.WriteLine($"Count = {arrayList.Count}, Capacity = {arrayList.Capacity}"); // Count = 4, Capacity = 4

            //arrayList.AddRange(new[] { 5, 6 });

            //Console.WriteLine($"Count = {arrayList.Count}, Capacity = {arrayList.Capacity}"); // Count = 6, Capacity = 8

            //arrayList.TrimToSize(); // Deallocate | Free | Delete UnusedBytes

            //Console.WriteLine($"Count = {arrayList.Count}, Capacity = {arrayList.Capacity}"); // Count = 6, Capacity = 6

            //arrayList.Add(10); // Casting from int [ValueType] To Object [ReferenceType] → Boxing 

            //arrayList.Add("Hamada"); // Compiler can't Enforce Type Safety at Compilation Time

            //int sum = SumArray(arrayList); // Exception 

            //// Boxing And UnBoxing is very costly for memory and processor and may occure unsafe casting

            #endregion

            #region Generic Collections - Listing (List)

            //List<int> list = new List<int>();

            //Console.WriteLine($"Count = {list.Count}, Capacity = {list.Capacity}"); // Count = 0, Capacity = 0

            //list.Add(1);
            //list.Add(2);

            //Console.WriteLine($"Count = {list.Count}, Capacity = {list.Capacity}"); // Count = 2, Capacity = 4

            //list.AddRange(new[] { 1, 2 });

            //Console.WriteLine($"Count = {list.Count}, Capacity = {list.Capacity}"); // Count = 4, Capacity = 4

            //list.Add(5);

            //Console.WriteLine($"Count = {list.Count}, Capacity = {list.Capacity}"); // Count = 5, Capacity = 8

            //list.TrimExcess(); // Deallocate | Free | Delete UnusedBytes |Release     // capacity had become 5

            //Console.WriteLine($"Count = {list.Count}, Capacity = {list.Capacity}"); // Count = 5, Capacity = 5

            //list[0] = 100;              // use Indexer as Setter
            //Console.WriteLine(list[0]); // use Indexer as Getter

            //// list[5] = 1000;  // U can't Use Indexer for Adding

            //int sum = SumList(list);
            //Console.WriteLine(sum);

            #endregion

            #region List Methods



            #endregion

            #region Generic Collections - Other Lists

            //LinkedList<int> list = new LinkedList<int>();

            //Stack<int> stack = new Stack<int>();  // last-in first-out

            //stack.Push(1);
            //stack.Push(2);
            //Console.WriteLine(stack.Pop()); //2

            //Queue<int> queue = new Queue<int>();  // first-in first-out

            //queue.Enqueue(1);
            //queue.Enqueue(2);
            //Console.WriteLine(queue.Dequeue()); // 1

            //// look at presentation

            #endregion

            #region Generic Collections - HashTables (Dictionary)

            //Dictionary<string, long> Phonebook = new Dictionary<string, long>();

            //Phonebook.Add("ahmed", 100);
            //Phonebook.Add("omar", 200);
            //Phonebook.Add("ali", 300);

            //// Phonebook.Add("ahmed", 400); // InValid , Key Must Be Uniqe

            //foreach (KeyValuePair<string, long> person in Phonebook)
            //{
            //    Console.WriteLine($"{person.Key} ::: {person.Value}");
            //}

            //Phonebook["ahmed"] = 500;               // Use Indexer AS Setter 
            //Console.WriteLine(Phonebook["ahmed"]);  // Use Indexer AS Getter 

            //Phonebook["mona"] = 600;               // Use Indexer as Adding 


            //foreach (KeyValuePair<string, long> person in Phonebook)
            //{
            //    Console.WriteLine($"{person.Key} ::: {person.Value}");
            //}

            //// If U want to add key but U don't Know is it exists or not

            //// Phonebook.Add("ahmed", 500); // unsafe code

            //// Way 1
            //if (!Phonebook.ContainsKey("ahmed"))
            //{
            //    Phonebook.Add("ahmed", 500);
            //} // Safe code

            //// way 2
            //Phonebook.TryAdd("ahmed", 500); // Safe code

            //// If U want to update vlaue but U don't Know is it exists or not

            //// Way 1
            //if (!Phonebook.ContainsKey("ahmed"))
            //{
            //    Phonebook.Add("ahmed", 500);
            //}
            //else
            //    Phonebook["ahmed"] = 500; // update

            //// Way 2
            //if (!Phonebook.TryAdd("ahmed", 500))
            //{
            //    Phonebook["ahmed"] = 500;
            //};

            //// Console.WriteLine(Phonebook["yasser"]); // UnSafe code

            //// way 1
            //Phonebook.TryGetValue("yasser", out long Number);
            //Console.WriteLine(Number);

            //// Way 2 and the best
            //Console.WriteLine(Phonebook.TryGetValue("yasser", out long number));
            //Console.WriteLine(number);

            //Console.WriteLine(Phonebook.TryGetValue("ali", out long numb));
            //Console.WriteLine(numb);

            #endregion

            #region Generic Collections - Other HashTables 

            //HashSet<int> set = new HashSet<int>();
            //set.Add(1);
            //set.Add(2);
            //set.Add(3);
            //set.Add(1);  // set remove duplicate keys
            //foreach (int i in set)
            //{
            //    Console.WriteLine(i);
            //}

            #endregion


        }
    }
}