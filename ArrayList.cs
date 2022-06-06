using System;
using System.Collections;


ArrayList list = new ArrayList();

list.Add(10); // boxing , it done automatically
list.Add(20); // add to the end of list
list.Add(30);
int n1 = Convert.ToInt32(list[1]); // unboxing , needs to do explicitly

list.Insert(0, 5);// insert the data based on index specified in the 
                  // parameter
Console.WriteLine($"Total elment in the arraylist {list.Count}");
//list.Remove(30); // remove the element from the list
list.RemoveAt(1); // removeat removes the element specified in the paramter
Console.WriteLine($"Total elment in the arraylist {list.Count}");
foreach (var item in list)
{
    Console.WriteLine(item);
}


