class Teacher : Person
{
    

    public string qualification = "";
     public Teacher(string name,string qualification, int age, DateTime dob,char gender) : base(name, age,dob,gender)
    {
        
        this.qualification = qualification;

    }
    public override void Display()
    {
        base.Display();
        Console.WriteLine($"\t {qualification}");
    }

    public static void PrintHeader()
    {
        Console.WriteLine();
        Console.WriteLine("Name \t Age \t\t DOB  \t\t\t Qualification");
    }   

}