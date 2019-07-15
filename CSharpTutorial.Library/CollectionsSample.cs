using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTutorial.Library
{
    public class CollectionsSample
    {
        #region Non-Generic Collections

        #region ArrayList


        /*
         ArrayList is a non-generic type of collection in C#. It can contain elements 
         of any data types. It is similar to an array, except that it grows automatically
         as you add items in it. Unlike an array, you don't need to specify the size of
         ArrayList.
         */


        //ArrayList can store items(elements) of any datatype.
        //ArrayList resizes automatically as you add the elements.
        //ArrayList values must be cast to appropriate data types before using it.
        //ArrayList can contain multiple null and dulplicate items.
        //ArrayList can be accessed using foreach or for loop or indexer.
        //Use Add(), AddRange(), Remove(), RemoveRange(), Insert(), InsertRange(), Sort(), Reverse() methods.

        public void ArrayListCheck_AccessingElements()
        {

            ArrayList myArryList = new ArrayList();
            myArryList.Add(1);
            myArryList.Add("Two");
            myArryList.Add(3);
            myArryList.Add(4.5f);

            //Access individual item using indexer
            int firstElement = (int)myArryList[0]; //returns 1
            string secondElement = (string)myArryList[1]; //returns "Two"
            int thirdElement = (int)myArryList[2]; //returns 3
            float fourthElement = (float)myArryList[3]; //returns 4.5

            //use var keyword
            var firstElement1 = myArryList[0]; //returns 1

        }

        public void ArrayListCheck_Contains()
        {

            ArrayList myArryList = new ArrayList();
            myArryList.Add(100);
            myArryList.Add("Hello World");
            myArryList.Add(300);

            Console.WriteLine(myArryList.Contains(100)); // true
        }


        public void ArrayListCheck_Sorting()
        {
            ArrayList arryList1 = new ArrayList();
            arryList1.Add(300);
            arryList1.Add(200);
            arryList1.Add(100);
            arryList1.Add(500);
            arryList1.Add(400);

            Console.WriteLine("Original Order:");

            foreach (var item in arryList1)
                Console.WriteLine(item);

            arryList1.Reverse();
            Console.WriteLine("Reverse Order:");

            foreach (var item in arryList1)
                Console.WriteLine(item);

            arryList1.Sort();
            Console.WriteLine("Ascending Order:");

            foreach (var item in arryList1)
                Console.WriteLine(item);
        }



        #endregion


        #region SortedList

        /*
        The SortedList collection stores key-value pairs in the ascending order of
        key by default. SortedList class implements IDictionary & ICollection
        interfaces, so elements can be accessed both by key and index.
        */


        //C# has generic and non-generic SortedList.
        //SortedList stores the key-value pairs in ascending order of the key.Key must be unique and cannot be null whereas value can be null or duplicate.
        //Non-generic SortedList stores keys and values of any data types. So values needs to be cast to appropriate data type.
        //Key-value pair can be cast to DictionaryEntry.
        //Access individual value using indexer. SortedList indexer accepts key to return value associated with it.



        public void SortedList_AddKeyValuePairs()
        {
            SortedList sortedList1 = new SortedList();
            sortedList1.Add(3, "Three");
            sortedList1.Add(4, "Four");
            sortedList1.Add(1, "One");
            sortedList1.Add(5, "Five");
            sortedList1.Add(2, "Two");

            //Key of different datatypes throws exception
            //sortedList1.Add("Four", "Four"); // Throw exception: InvalidOperationException

            SortedList sortedList2 = new SortedList();
            sortedList2.Add("one", 1);
            sortedList2.Add("two", 2);
            sortedList2.Add("three", 3);
            sortedList2.Add("four", 4);

            SortedList sortedList3 = new SortedList();
            sortedList3.Add(1.5, 100);
            sortedList3.Add(3.5, 200);
            sortedList3.Add(2.4, 300);
            sortedList3.Add(2.3, "ok");
            sortedList3.Add(1.1, null);
        }


        public void SortedList_Access()
        {
            SortedList sortedList = new SortedList()
                            {
                                {"one", 1},
                                {"two", 2},
                                {"three", 3},
                                {"four", "Four"}
                            };

            int i = (int)sortedList["one"];
            int j = (int)sortedList["two"];
            string str = (string)sortedList["four"];

            Console.WriteLine(i);
            Console.WriteLine(j);
            Console.WriteLine(str);

            // Accessing Values using For Loop
            for (int x = 0; x < sortedList.Count; x++)
            {
                Console.WriteLine("key: {0}, value: {1}",
                    sortedList.GetKey(x), sortedList.GetByIndex(x));
            }


            //Access values using foreach

            foreach (DictionaryEntry kvp in sortedList)
                Console.WriteLine("key: {0}, value: {1}", kvp.Key, kvp.Value);


            //Remove elements in SortedList

            sortedList.Remove("one");//removes element whose key is 'one'
            sortedList.RemoveAt(0);//removes element at zero index i.e first element: four

            foreach (DictionaryEntry kvp in sortedList)
                Console.WriteLine("key: {0}, value: {1}", kvp.Key, kvp.Value);



        }


        public void SortedList_Contains()
        {
            SortedList sortedList = new SortedList()
            {
                { 3, "Three"},
                { 4, "Four"},
                { 1, "One"},
                { 8, "Eight"},
                { 2, "Two"}
            };
            sortedList.Contains(2); // returns true
            sortedList.Contains(4); // returns true
            sortedList.Contains(6); // returns false

            sortedList.ContainsKey(2); // returns true
            sortedList.ContainsKey(6); // returns false

            sortedList.ContainsValue("One"); // returns true
            sortedList.ContainsValue("Ten"); // returns false

            
        }

        #endregion

        #region Stack

        /*
         C# includes a special type of collection which stores elements in LIFO style
         (Last In First Out). C# includes a generic and non-generic Stack. Here,
         you are going to learn about the non-generic stack.

        Stack allows null value and also duplicate values.
        It provides a Push() method to add a value and Pop() or Peek() methods 
        to retrieve values.
         
         */

        //Stack stores the values in LIFO(Last in First out) style.The element which is added last will be the element to come out first.
        //Use the Push() method to add elements into Stack.
        //The Pop() method returns and removes elements from the top of the Stack. Calling the Pop() method on the empty Stack will throw an exception.
        //The Peek() method always returns top most element in the Stack.


        public void Stack_Check()
        {
            Stack myStack = new Stack();
            myStack.Push("Hello!!");
            myStack.Push(null);
            myStack.Push(1);
            myStack.Push(2);
            myStack.Push(3);
            myStack.Push(4);
            myStack.Push(5);

            foreach (var itm in myStack)
                Console.Write(itm);

            // Peek
            Console.WriteLine(myStack.Peek()); // 5
            Console.WriteLine(myStack.Peek()); // 5

            //Pop
            Console.Write("Number of elements in Stack: {0}", myStack.Count);

            while (myStack.Count > 0)
                Console.WriteLine(myStack.Pop());

            Console.Write("Number of elements in Stack: {0}", myStack.Count);

            //Contains
            myStack.Contains(2); // returns true
            myStack.Contains(10); // returns false

            //Clear
            myStack.Clear(); // removes all elements

            Console.Write("Number of elements in Stack: {0}", myStack.Count);



        }



        #endregion


        #region Queue

        /*
         C# includes a Queue collection class in the System.Collection namespace.
         Queue stores the elements in FIFO style (First In First Out), exactly opposite
         of the Stack collection. It contains the elements in the order they were added.

         Queue collection allows multiple null and duplicate values.
         Use the Enqueue() method to add values and the Dequeue() method to retrieve
         the values from the Queue.
         */

        public void Queue_Check()
        {
            //Add elements in Queue
            Queue queue = new Queue();
            queue.Enqueue(3);
            queue.Enqueue(2);
            queue.Enqueue(1);
            queue.Enqueue("Four");

            //Access Queue
            Console.WriteLine("Number of elements in the Queue: {0}", queue.Count); // 4

            while (queue.Count > 0)
                Console.WriteLine(queue.Dequeue()); // 3,2,1,"Four"

            Console.WriteLine("Number of elements in the Queue: {0}", queue.Count); //0


            //Peek()
            //The Peek() method always returns the first item
            //from a queue collection without removing it from the queue.

            Queue queue2 = new Queue();
            queue2.Enqueue(3);
            queue2.Enqueue(2);
            queue2.Enqueue(1);
            queue2.Enqueue("Four");

            Console.WriteLine("Number of elements in the Queue: {0}", queue2.Count); // 4

            Console.WriteLine(queue2.Peek()); //3
            Console.WriteLine(queue2.Peek()); //3
            Console.WriteLine(queue2.Peek()); //3

            Console.WriteLine("Number of elements in the Queue: {0}", queue2.Count); //4

            // Iterate Queue
            foreach (var i in queue.ToArray())
                Console.WriteLine(i);

            //Contains
            queue.Contains(2); // true
            queue.Contains(100); //false


            //Clear
            Console.WriteLine("Number of elements in the Queue: {0}", queue.Count); //4

            queue.Clear();

            Console.WriteLine("Number of elements in the Queue: {0}", queue.Count); //0

        }


        #endregion

        #region HashTable

        /*
         C# includes Hashtable collection in System.Collections namespace, 
         which is similar to generic Dictionary collection. The Hashtable collection 
         stores key-value pairs. It optimizes lookups by computing the hash code of 
         each key and stores it in a different bucket internally and then matches the 
         hash code of the specified key at the time of accessing values.
         */


        //Hashtable stores key-value pairs of any datatype where the Key must be unique.
        //The Hashtable key cannot be null whereas the value can be null.
        //Hashtable retrieves an item by comparing the hashcode of keys.So it is slower in performance than Dictionary collection.
        //Hashtable uses the default hashcode provider which is object.GetHashCode(). You can also use a custom hashcode provider.
        //Use DictionaryEntry with foreach statement to iterate Hashtable.


        public void Hashtable_Check()
        {
            // add
            Hashtable ht = new Hashtable();

            ht.Add(1, "One");
            ht.Add(2, "Two");
            ht.Add(3, "Three");
            ht.Add(4, "Four");
            ht.Add(5, null);
            ht.Add("Fv", "Five");
            ht.Add(8.5, 8.5);

            //Hashtable can include all the elements of Dictionary as shown below.
            Dictionary<int, string> dict = new Dictionary<int, string>();

            dict.Add(1, "one");
            dict.Add(2, "two");
            dict.Add(3, "three");

            Hashtable ht2 = new Hashtable(dict);


            string strValue1 = (string)ht[2];
            string strValue2 = (string)ht["Fv"];
            float fValue = (float)ht[8.5];

            Console.WriteLine(strValue1); // Two
            Console.WriteLine(strValue2); // Five
            Console.WriteLine(fValue); //8.5


            //Iterate Hashtable
            foreach (DictionaryEntry item in ht)
                Console.WriteLine("key:{0}, value:{1}", item.Key, item.Value);

            //Key: Fv, Value: Five
            //Key: 8.5, Value: 8.5
            //Key: 5, Value:
            //Key: 4, Value: Four
            //Key: 3, Value: Three
            //Key: 2, Value: Two
            //Key: 1, Value: One

            //Access Hashtable using Keys & Values

            foreach (var key in ht.Keys)
                Console.WriteLine("Key:{0}, Value:{1}", key, ht[key]);

            Console.WriteLine("***All Values***");

            foreach (var value in ht.Values)
                Console.WriteLine("Value:{0}", value);


            //Remove()
            ht.Remove("Fv"); // removes {"Fv", "Five"}

            //Contains(), ContainsKey() and ContainsValue()

            Hashtable ht3 = new Hashtable()
                {
                    { 1, "One" },
                    { 2, "Two" },
                    { 3, "Three" },
                    { 4, "Four" }
                };

            ht3.Contains(2);// returns true
            ht3.ContainsKey(2);// returns true
            ht3.Contains(5); //returns false
            ht3.ContainsValue("One"); // returns true


            //Clear()
            ht.Clear(); // removes all elements

            #endregion

            #region BitArray

            #endregion
        }

        #endregion


        #region Generic Collections

        #region List<T>

        /*
         You have already learned about ArrayList in the previous section.
         An ArrayList resizes automatically as it grows. The List<T> collection is 
         the same as an ArrayList except that List<T> is a generic collection whereas 
         ArrayList is a non-generic collection.
         */

        public void List_Check()
        {
            //Adding elements into List
            IList<int> intList = new List<int>();
            intList.Add(10);
            intList.Add(20);
            intList.Add(30);
            intList.Add(40);

            IList<string> strList = new List<string>();
            strList.Add("one");
            strList.Add("two");
            strList.Add("three");
            strList.Add("four");
            strList.Add("four");
            strList.Add(null);
            strList.Add(null);

            IList<Student> studentList = new List<Student>();
            studentList.Add(new Student());
            studentList.Add(new Student());
            studentList.Add(new Student());


            //Add elements using object initializer syntax
            IList<int> intList1 = new List<int>() { 10, 20, 30, 40 };

            //Or

            IList<Student> studentList1 = new List<Student>() {
                new Student(){ StudentID=1, StudentName="Bill"},
                new Student(){ StudentID=2, StudentName="Steve"},
                new Student(){ StudentID=3, StudentName="Ram"},
                new Student(){ StudentID=1, StudentName="Moin"}
            };

            //Accessing List
            List<int> intList2 = new List<int>() { 10, 20, 30 };
            intList2.ForEach(el => Console.WriteLine(el));

            foreach (var el in intList)
                Console.WriteLine(el);

            int elem = intList[1]; // returns 20

            //Access List elements
            Console.Write("Total elements: {0}", intList.Count);

        }

        #endregion


        #region Dictionary<TKey,TValue>

        /*
         the Dictionary in C# is a collection of Keys and Values,
         where key is like word and value is like definition.
         */


        //A Dictionary stores Key-Value pairs where the key must be unique.
        //Before adding a KeyValuePair into a dictionary, check that the key does not exist using the ContainsKey() method.
        //Use the TryGetValue() method to get the value of a key to avoid possible runtime exceptions.
        //Use a foreach or for loop to iterate a dictionary.
        //Use dictionary indexer to access individual item.
        //Use custom class that derives IEqualityComparer to compare object of custom class with Contains() method.
        public void Dictionary_Check()
        {
            //IDictionary<int, string> dict = new Dictionary<int, string>();

            //or

            Dictionary<int, string> dict2 = new Dictionary<int, string>();

            IDictionary<int, string> dict = new Dictionary<int, string>();
            dict.Add(1, "One");
            dict.Add(2, "Two");
            dict.Add(3, "Three");


            IDictionary<int, string> dict3 = new Dictionary<int, string>();

            dict3.Add(new KeyValuePair<int, string>(1, "One"));
            dict3.Add(new KeyValuePair<int, string>(2, "Two"));

            //The following is also valid
            dict3.Add(3, "Three");

            //Access elements using foreach
            foreach (KeyValuePair<int, string> item in dict)
            {
                Console.WriteLine("Key: {0}, Value: {1}", item.Key, item.Value);
            }

            //Access Elements using for Loop
            for (int i = 0; i < dict.Count; i++)
            {
                Console.WriteLine("Key: {0}, Value: {1}",
                                                        dict.Keys.ElementAt(i),
                                                        dict[dict.Keys.ElementAt(i)]);
            }


            //Access Individual Element
            Console.WriteLine(dict[1]); //returns One
            Console.WriteLine(dict[2]); // returns Two

            //TryGetValue()
            string result;

            if (dict.TryGetValue(4, out result))
            {
                Console.WriteLine(result);
            }
            else
            {
                Console.WriteLine("Could not find the specified key.");
            }

            //ContainsKey() & Contains()
            dict.ContainsKey(1); // returns true
            dict.ContainsKey(4); // returns false

            dict.Contains(new KeyValuePair<int, string>(1, "One")); // returns true


            //Remove elements from Dictionary
            dict.Remove(1); // removes the item which has 1 as a key

        }



        public void Dictionary_CustomCompare()
        {

            IDictionary<int, Student> studentDict = new Dictionary<int, Student>()
                    {
                        { 1, new Student(){ StudentID =1, StudentName = "Bill"}},
                        { 2, new Student(){ StudentID =2, StudentName = "Steve"}},
                        { 3, new Student(){ StudentID =3, StudentName = "Ram"}}
                    };

            Student std = new Student() { StudentID = 1, StudentName = "Bill" };

            KeyValuePair<int, Student> elementToFind = new KeyValuePair<int, Student>(1, std);

            bool result = studentDict.Contains(elementToFind, new StudentDictionaryComparer()); // returns true

            Console.WriteLine(result);


        }



        #endregion


        #region SortedList<TKey,TValue>

        public void GenericSortedList()
        {
            SortedList<int, string> sortedList1 = new SortedList<int, string>();
            sortedList1.Add(3, "Three");
            sortedList1.Add(4, "Four");
            sortedList1.Add(1, "One");
            sortedList1.Add(5, "Five");
            sortedList1.Add(2, "Two");

            SortedList<string, int> sortedList2 = new SortedList<string, int>();
            sortedList2.Add("one", 1);
            sortedList2.Add("two", 2);
            sortedList2.Add("three", 3);
            sortedList2.Add("four", 4);
            // Compile time error: cannot convert from <null> to <int>
            // sortedList2.Add("Five", null);

            SortedList<double, int?> sortedList3 = new SortedList<double, int?>();
            sortedList3.Add(1.5, 100);
            sortedList3.Add(3.5, 200);
            sortedList3.Add(2.4, 300);
            sortedList3.Add(2.3, null);
            sortedList3.Add(1.1, null);

            //Access SortedList<TKey, TValue> using indexer

            Console.WriteLine(sortedList2["one"]);
            Console.WriteLine(sortedList2["two"]);
            Console.WriteLine(sortedList2["three"]);

            //Following will throw runtime exception: KeyNotFoundException
            Console.WriteLine(sortedList2["ten"]);

            //Access Key and Value using indexer

            for (int i = 0; i < sortedList2.Count; i++)
            {
                Console.WriteLine("key: {0}, value: {1}", sortedList2.Keys[i], sortedList2.Values[i]);
            }

            //foreach statement to access generic SortedList:
            foreach (KeyValuePair<string, int> kvp in sortedList2)
                Console.WriteLine("key: {0}, value: {1}", kvp.Key, kvp.Value);


            //TryGetValue
            //use TryGetValue method to retrieve the value of specified key. 
            //If key doesn't exists than it will return false instead of throwing
            //exception.


            int val;

            if (sortedList2.TryGetValue("ten", out val))
                Console.WriteLine("value: {0}", val);
            else
                Console.WriteLine("Key is not valid.");

            if (sortedList2.TryGetValue("one", out val))
                Console.WriteLine("value: {0}", val);

        }


        #endregion


        #region Stack<T>

        #endregion


        #region Queue<T>

        #endregion


        #region Hashset<T>

        #endregion

        #endregion
    }

}
