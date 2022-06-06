using System;
using System.Text;

class program
{
    static void Calculation(int a, int b, out int sum, out int sub, out int multi, out int div)
    {
        sum = a + b ;
        sub = a - b;
        multi = a* b;
    div = a / b;

    }
static void Main(string[] args)
{
    int a = 10;int b = 5, sum, 
        sub, multi, div;
    Calculation(a, b, out sum, out sub, out multi, out div);
        
        Console.WriteLine($"add={sum} sub={sub} multi={multi} div={div}");
} 

}
    




    //    public struct Dimension
    //{
    //    int x, y;
    //    public Dimension(int x, int y)
    //    {
    //        // when we have same name of data member & parameter
    //        // this keyword ref the data member name
    //        this.x = x;
    //        this.y = y;
    //    }
    //    public void Display()
    //    {
    //        Console.WriteLine($"{x} {y}");
    //    }
    //}

    //static void Main(string[] args)
    //{
    //    Dimension d1 = new Dimension(10, 12);
    //    d1.Display();

    //    Dimension d2 = d1;


        //StringBuilder strsb = new StringBuilder("I am Ajay");
        //Console.WriteLine(strsb);

        //strsb.Append("Designation is developer");

        //float salary = 28000.00f;
        //strsb.AppendFormat("my salary is {0:c}", salary);

        //strsb.Insert(10, "Thanks");
        //Console.WriteLine(strsb);

        //strsb.Remove(10,5);
        //Console.WriteLine(strsb);

        //strsb.Replace("developer", "manager");
        //Console.WriteLine(strsb);


        //string str = "Hello World";
        //string newstr = "india";

        //Console.WriteLine(  str);



        //Console.WriteLine(str.Length);
        //Console.WriteLine(str.ToUpper());
        //Console.WriteLine(str.ToLower());


        //Console.WriteLine(str.IndexOf("W"));
        //string str3 = str.Substring(6);
        //Console.WriteLine(str);

        //string str2 = str.Substring(0, 5);
        //Console.WriteLine(str2.ToUpper());



    
