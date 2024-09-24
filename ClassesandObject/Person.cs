public class Person
{
     public Person(string name, int age, DateTime dob,char gender)
    {
        Name = name;
        Age = age;
        this.dob = dob;
        this.gender = gender;

    }
    public string Name = "";
    public int Age;
    public string resume = "";
    public DateTime dob;
    public char gender;

    public virtual void Display()
    {
        var message = $"{Name} \t {Age}  \t\t {dob.ToLongDateString()}";
        Console.Write(message); 
        
    }

    
}