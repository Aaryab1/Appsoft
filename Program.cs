// // See https://aka.ms/new-console-template for more information
Student.PrintHeader();

var student1  = new Student("John", 20, 101, new DateTime(2000, 1, 1),'M');
student1.Display();

var student2  = new Student("Jane", 21, 102, new DateTime(1999, 1, 1),'F');
student2.Display();

var student3  = new Student("Jack", 22, 103, new DateTime(1998, 1, 1),'M');
student3.Display();

Teacher.PrintHeader();
var teacher1 = new Teacher("Smith", "PhD", 45, new DateTime(1975, 1, 1),'M');
teacher1.Display();
var teacher2 = new Teacher("Mary", "Masters", 40, new DateTime(1980, 1, 1),'F');
teacher2.Display();


Admin.PrintHeader();
var admin1 = new Admin("Tom", 35, "HR", new DateTime(1985, 1, 1),'M');
admin1.Display();
var admin2 = new Admin("Sue", 30, "Finance", new DateTime(1990, 1, 1),'F');
admin2.Display();
// Methods m = new();
// m.Sayhello();
// m.Sayhello("John"); 
