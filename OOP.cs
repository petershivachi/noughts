using System;

namespace Campus
{
  class School
  {
    private string faculty, course;
    private int number_of_units;
    private double fees_paid, balance, fees = 10000;

    public Campus(int units, double fee, double bal){
      number_of_units = units;
      fees_paid = fee;
      balance = bal;
    }

    public Campus(int units, double fee, double bal){
      units = 5;
      fee = 0;
      bal = 9000;
    }

    public void datain()
    {
      Console.WriteLine("Please enter your faculty :> ");
      faculty = Console.ReadLine();
      Console.WriteLine("Please enter the course you are taking :> ");
      course = Console.ReadLine();
      Console.WriteLine("Please enter the number of units you are taking");
      number_of_units = Convert.ToInt32(Console.ReadLine());
      Console.WriteLine("Please enter the fees you have paid");
      fees_paid = Convert.ToInt32(Console.ReadLine());
    }

    public void compute()
    {
      balance = fees - fees_paid;
    }

    public void output()
    {
      Console.WriteLine("Faculty = {0}", faculty);
      Console.WriteLine("Course = {0}", course);
      Console.WriteLine("Number of units = {0}", number_of_units);
      Console.WriteLine("Fees paid = {0}");
    }

     ~Campus(){
       Console.WriteLine("The destructor has been called");
    }
  }

  class FullTimeStudent : School
  {
    private string campus, employer_name, number_of_kids;

    public void getDetails()
    {
      datain();
      Console.WriteLine("Please enter your campus :> ");
      campus = Console.ReadLine();
      Console.WriteLine("Please enter your employee's :> ");
      employer_name = Console.ReadLine();
      Console.WriteLine("Please enter the number of your kids :> ");
      number_of_kids = Console.ReadLine();
    }

    public void calculateFee(){
      compute();
    }

    public void displayDetails()
    {
      output();
      Console.WriteLine("Campus = {0}", campus);
      Console.WriteLine("Employer's Name = {0}", employer_name);
      Console.WriteLine("Number of kids = {0}", number_of_kids);
    }
  }

  class PartTimeStudent : School
  {
    private string guardian_name, guardian_tel;

    public override void dataIntake()
    {
      base.datain();
      Console.WriteLine("Please enter your guardians name :> ");
      guardian_name = Console.ReadLine();
      Console.WriteLine("Please enter your guardians phone :> ");
      guardian_tel = Console.ReadLine();
    }

    public void computeFee(){
      compute();
    }

    public void dataDisplay(){
      output();
      Console.WriteLine("Guardians Name = {0}", guardian_name);
      Console.WriteLine("Guardians Telephone = {0}", guardian_tel);
    }
  }

  class CampusProgram {
    public static void Main(string[] args){
      FullTimeStudent full1 = new FullTimeStudent();

      PartTimeStudent part1 = new PartTimeStudent();

      Console.WriteLine("Data entry for the first student...");
      Console.WriteLine("------------------------------------");
      full1.datain();

      Console.LargestWindowHeight("Data Analysis for the first Student...");
      Console.WriteLine("------------------------------------");
      full1.calculateFee();
      full1.displayDetails();

      Console.WriteLine("Data entry for the first student...");
      Console.WriteLine("------------------------------------");
      part1.dataIntake();

      Console.LargestWindowHeight("Data Analysis for the first Student...");
      Console.WriteLine("------------------------------------");
      part1.compute();
      part1.dataDisplay();
    }
  }
}