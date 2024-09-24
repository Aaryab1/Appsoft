class Admin : Person
{
    public string department = "";
    public Admin(string name, int age, string department, DateTime dob,char gender) : base(name, age,dob,gender)
    {
        this.department = department;
    }
    public override void Display()
    {
        base.Display();
        Console.WriteLine($"\t {department}");
    }
    public static void PrintHeader()
    {
        Console.WriteLine();
        Console.WriteLine("Name \t Age \t\t DOB  \t\t\t Department");
    }
}