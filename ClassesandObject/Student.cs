class Student : Person
{
   
    public int rollnumber;
    string resume = "";
    public Student(string name, int age, int rollnumber, DateTime dob,char gender) : base(name, age,dob,gender)
    {
        
        this.rollnumber = rollnumber;

    }
    
   
    

    public override void Display()
    {
        base.Display();
        Console.WriteLine($"\t {rollnumber}");
    }

    public static void PrintHeader()
    {
        Console.WriteLine();
        Console.WriteLine("Name \t Age \t\t DOB \t\t\t Rollnumber");
    }   

    
}


