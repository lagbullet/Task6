using System;
using System.Collections.Generic;

public class PInfoCompare : IComparer<Employee>
{

    public int Compare(Employee empl1, Employee empl2)
    {
        int result = empl1.SurName.CompareTo(empl2.SurName);
        if (result == 0)
            result = empl1.FirstName.CompareTo(empl2.FirstName);
        if (result == 0)
            result = empl1.Patronymic.CompareTo(empl2.Patronymic);
        return result;
    }
}

public class Employee : IComparable<Employee>
{
    public String surName;
    public String firstName;
    public String patronymic;
    public String birthdate;
    public float salary;

    public String SurName { get; set; }
    public String FirstName { get; set; }
    public String Patronymic { get; set; }
    public String Birthdate { get; set; }
    public float Salary { get; set; }

    public Employee(String Sname, String Fname, String patronymic, String Bdate, float salary)
	{
        SurName = Sname;
        FirstName = Fname;
        Patronymic = patronymic;
        Birthdate = Bdate;
        Salary = salary;
	}

    public int CompareTo(Employee other)
    { 
        return Salary.CompareTo(other.Salary);
    }

    override public string ToString()
    {
        return string.Format("Surname: " + SurName + "\nFirstname: " + FirstName + "\nPatronymic:" + Patronymic + "\nBirthdate: " + Birthdate + "\nSalary: " + Salary);
    }
}
