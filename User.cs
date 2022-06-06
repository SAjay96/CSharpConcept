using System;

    //public class User
    //{
    // C# Program to show use of
// multiple try catch bl
class Program
{

	static void Main(string[] args)
	{
		int[] arr = { 19, 0, 75, 52 };

		try
		{

			
			for (int i = 0; i < arr.Length; i++)
			{
				Console.WriteLine(arr[i] / arr[i + 1]);
			}
		}

		catch (IndexOutOfRangeException exc)
		{

			Console.WriteLine("An Exception : " ,exc);
		}

        finally
        { 
		
			
				Console.Write(" {0}", arr[i]);
		}
		
	}

    //    private int uid;
    //    private string city, name;
    //    //isUser=true  called default value
    //    public User(string city, string name, int uid, bool isUser = true, bool isAdmin = false)
    //    {
    //        this.city = city;
    //        this.name = name;
    //        this.uid = uid;
    //    }

    //    public void Display()
    //{
    //    Console.WriteLine($"city={city} name ={name} uid={uid}  ");
    //}

    //    public static void Main()
    //    {
    //        User user1 = new User("Pune", "Ajay", 1);
    //        // named argument
    //        User user2 = new User(uid: 2, name: "Suraj", city: "mumbai");
    //        // optional paramter
    //        User user4 = new User("Pune", "Rohan", 3);
    //        User user3 = new User("Pune", "Rohan", 3, false);

    //    user1.Display();
    //    }

   }
