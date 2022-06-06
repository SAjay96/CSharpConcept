using System;
using System.Collections;


namespace ArrayList
{
    class hash
    {
        static void Main(String[] args)
        {
            Hashtable ht = new Hashtable();
            ht.Add("91", "india");
            ht.Add("63", "usa");
            ht.Add("1", "uk");


            foreach (DictionaryEntry d in ht)
            {
                Console.WriteLine($"{d.Key}-{d.Value}");
            }
        }
    }

}

