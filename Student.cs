class Studentt
{
    public int Chem { get; set; }
    public int Phys { get; set; }
    public int Maths { get; set; }
    public int SocialStudy { get; set; }
    public int Science { get; set; }
    private double Sum, Percentage;

    public void CalMarks()
    {
        Sum = Chem + Phys + Maths + Science + SocialStudy;
        Percentage = Sum / 5;
        {
            if (Percentage >= 75)
            {
                Console.WriteLine("First class with distinction");
            }
            else if (Percentage >= 60)
            {
                Console.WriteLine("A");
            }
            else if (Percentage >= 40)
            {
                Console.WriteLine("B");
            }
            else
            {
                Console.WriteLine("Fail");
            }

        }




        static void Main(string[] args)
        {
            Studentt s1 = new Studentt();
            s1.Chem = 45;
            s1.Phys = 50;
            s1.Maths = 47;
            s1.Science = 48;
            s1.SocialStudy = 50;
            s1.CalMarks();
            Console.WriteLine(s1);

        }
    }
}
    


