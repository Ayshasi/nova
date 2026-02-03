// See https://aka.ms/new-console-template for more information
using System.Collections;

Console.WriteLine("Hello, World!");


ArrayList AB = new ArrayList();
AB.Add(1);
AB.Add("Hello");
AB.Add(3.14);
AB.Add(true);
AB.Add(DateTime.Now);
AB.Add('A');
AB.Add(100);

foreach (object item in AB)
{
    Console.WriteLine(item);
}



Hashtable HT = new Hashtable();
HT.Add(1, "One");   
HT.Add(2, "Two");
HT.Add(3, "Three");
HT.Add(4, "Four");
HT.Add(5, "Five");

foreach (DictionaryEntry item in HT)
    {
    Console.WriteLine(item);
}



SortedList SL = new SortedList();
SL.Add(5, "Five");      
SL.Add(3, "Three");
SL.Add(1, "One");
SL.Add(4, "Four");
SL.Add(2, "Two");
foreach (DictionaryEntry item in SL)
{
    Console.WriteLine(item);
}



Stack s = new Stack();
s.Push(1);  
s.Push(2);
s.Push(3); 

foreach (object item in s)
{
    Console.WriteLine(item);
}



Queue q = new Queue();
q.Enqueue(1);
q.Enqueue(2);
q.Enqueue(3);
foreach (object item in q)
{
    Console.WriteLine(item);
}


List<int> list = new List<int>();
list.Add(1);
list.Add(2);

foreach (var item in list)
{
    Console.WriteLine(item);
}


Dictionary<int, string> dct = new Dictionary<int, string>();
dct.Add(1, "cs.net");
dct.Add(2, "vb.net");
dct.Add(3, "vb.net");
dct.Add(4, "vb.net");

foreach (var item in dct)
{
    Console.WriteLine(item);
}

SortedDictionary<int, string> sd = new SortedDictionary<int, string>();
sd.Add(1, "One");
sd.Add(2, "Two");
sd.Add(3, "Three");

foreach (var item in sd)
{
    Console.WriteLine(item);
}


Stack<int> st = new Stack<int>();
st.Push(1);
st.Push(2);
st.Push(3);

foreach (var item in st)
{
    Console.WriteLine(item);
}


Queue<int> qt = new Queue<int>();
qt.Enqueue(1);
qt.Enqueue(2);
qt.Enqueue(3);
qt.Enqueue(4);
qt.Enqueue(5);

foreach (var item in qt)
{
    Console.WriteLine(item);
}
    