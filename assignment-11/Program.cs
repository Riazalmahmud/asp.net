using System;

class Student
{
    private string _name;
    private DateTime _dateOfBirth;
    private string _rollNumber;


    public string Name
    {
        get;
        private set;

    }
    public string DateOfBirth
    {
        get { return _dateOfBirth.ToString("yyyy-MM-dd"); }
        set
        {
            if (DateTime.TryParse(value, out DateTime parsedDate))
            {
                if (parsedDate > DateTime.Now)
                {
                    throw new ArgumentException("Date of birth cannot be in the future.");
                }
                _dateOfBirth = parsedDate;
            }
            else
            {
                throw new ArgumentException("Invalid date format. Please use 'yyyy-MM-dd'.");
            }
        }

    }

    public string RollNumber
    {
        get;
        private set;

    }

    public Student(string name, string dateOfBirth, string rollNumber)
    {
        Name = name;
        DateOfBirth = dateOfBirth;
        RollNumber = rollNumber;
    }


private int AgeCalculation()
    {
        return DateTime.Now.Year - _dateOfBirth.Year - (DateTime.Now.DayOfYear < _dateOfBirth.DayOfYear ? 1 : 0);
    }

public int Age
    {
        get { return AgeCalculation(); }
    }
    public void StudentData()
    {
        Console.WriteLine($"Name: {Name}, Date of Birth: {DateOfBirth}, Roll Number: {RollNumber}, Age: {Age}");
    }

}

class MyClass
{
    static void Main(string[] args)
    {
        try
        {
            var student1 = new Student("Riaz", "2000-01-01", "12345");
        
            var student2 = new Student("Aisha", "2022-12-31", "67890");
         
            student1.StudentData();
            student2.StudentData();
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occurred: {ex.Message}");
        }
    }
}
