using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayList
{
  

namespace ArrayList
    {

        public class Dept
        {
            public string Name { get; set; }
            public int ID { get; set; }

            public string Location { get; set; }    
        }
        class Linklist
        {
            static void Main(string[] args)
            {
              
             

                List<Dept> list1 = new List<Dept>();

                Dept d1 = new Dept {Name = "HR" ,ID=1,Location="Pune"};

                Dept d2 = new Dept { Name = "FINANCE", ID= 2, Location = "WAKAD" };

                Dept d3 = new Dept { Name = "TECH", ID= 3, Location = "HINJEWADI" };
                
                list1.Add(d1);
                list1.Add(d2);

                list1.Insert(1, d3);
                foreach (Dept d in list1)
                {
                    Console.WriteLine($"{d.Name} {d.ID}{d.Location}");
                }

            }
        }
    }

}

