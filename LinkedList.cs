using System;
using System.Collections.Generic;

namespace ArrayList
{

    public class Stud
    {
        public string Name { get; set; }
        public int  RollNo{ get; set; }
    }
     class Linklist
    {
        static void Main(string[] args)
        {
            List<int> list1 = new List<int>();
            list1.Add(10);
            list1.Add(20);
            // Insert, Remove, RemoveAt  - are same as ArrayList
            // Count property is for count the number of elements in the List
            list1.Insert(1, 15);
            foreach (int i in list1)
            {
                Console.WriteLine(i);
            }
            List<string> list2 = new List<string>();
            list2.Add("White");
            list2.Add("Black");
            list2.Insert(0, "Red");
            foreach (string s in list2)
            {
                Console.WriteLine(s);
            }

            List<Stud> list3 = new List<Stud>();

            Stud s1 = new Stud { RollNo = 1, Name = "stud1" };
            Stud s2 = new Stud { RollNo = 2, Name = "stud2" };
            Stud s3 = new Stud { RollNo = 3, Name = "stud3" };
            list3.Add(s1);
            list3.Add(s2);

            list3.Insert(1, s3);
            foreach (Stud s in list3)
            {
                Console.WriteLine($"{s.RollNo} {s.Name}");
            }

        }
    }
}
