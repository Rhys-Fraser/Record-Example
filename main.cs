using System;

class Program {
  public static void Main (string[] args) 
  {
    struct Student 
    {
      public int StudentID; public string Surname; public string Forename; public int Age;
      public bool Enrolled;
    };

    Student mystudent;

    mystudent.StudentID = 2001;
    mystudent.Surname = "Brush";
    mystudent.Forename = "Basil";
    mystudent.Age = 21;
    mystudent.Enrolled = true;

    Console.WriteLine("ID          : {0}", mystudent.StudentID);
    Console.WriteLine("Surname     : {0}", mystudent.Surname);
    Console.WriteLine("Firstname   : {0}", mystudent.Forename);
  }
}