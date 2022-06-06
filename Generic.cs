using System;
using System.Collections;
using System.Collections.Generic;
namespace ConsoleAplication;

//public class MyGeneric<T>
//{
//    private T data;
//    public void Accept(T data)
//    {
//        this.data = data;
//    }
//    public T GetData()
//    {
//        return data;
//    }
//}
//public class Users
//{
//    public string Name { get; set; }
//    public string City { get; set; }
//    public override string ToString()
//    {
//        return $"{Name} {City}";
//    }
//}
//class program
//{
//    static void Swap<T>(T a, T b) { 

//             T c;
//         c =a;
//        a=b;
//        b=c;


//        Console.WriteLine($" Swap{a} {b}");
//        }


//   public static void Main(String[] args)
//    {
//        MyGeneric<int> obj1 = new MyGeneric<int>();
//        obj1.Accept(10);
//        Console.WriteLine(obj1.GetData());

//        MyGeneric<string> obj2 = new MyGeneric<string>();
//        obj2.Accept("Hi");
//        Console.WriteLine(obj2.GetData());

//        MyGeneric<Users> obj3 = new MyGeneric<Users>();
//        obj3.Accept(new Users { Name = "user1", City = "Pune" });
//        Console.WriteLine(obj3.GetData());
//    }
//}
public class Test :IComparer<Player>
{
    public int Compare(Player x,Player y)
    {
        if (x.Run > y.Run)
        {
            return 1;
        }
        else
        {
            return 0;  
        }
    }
}
 public class Player : IComparable
{
    IComparer<> 
    private string name;
    private double run;
    public Player(string name, double run)
    {
        this.name= name;
        this.run = run;
    }

    public int CompareTo(object obj) 
    {
        
        Player play2 = (Player)obj;  
                                        
        if (this.run> play2.run)
        {
            return 1;
        }
        else
        {
            return 0;
        }
    }
}
class program
{


    public static void Main(String[] args)
    {


        Player play1 = new Player("Virat", 12000);
        Player play2 = new Player("Sachin", 18000);

        Test t1 = new Test();
        int result=t1.Compare(play1,play2);

       // int result = play1.CompareTo(play2);
        if (result == 1)
        {
            Console.WriteLine("Virat have score more runs than Sachin");
        }
        else
        {
            Console.WriteLine("Sachin have score more runs than Virat");
        }
    }
}
