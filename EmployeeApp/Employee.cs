using System;
using System.Collections.Generic;

public class PInfoCompare : IComparer<Employee>
{
    public int Compare(Employee empl1, Employee empl2)
    {
        if (empl1.SurName == empl2.SurName)
            if (empl1.FirstName == empl2.FirstName)
                if (empl1.Patronymic == empl2.Patronymic)
                {
                    return 0;
                }
                else
                {
                    if (empl1.Patronymic.CompareTo(empl2.Patronymic) == -1)
                        return -1;
                    else
                        return 1;
                }
            else
            {
                if (empl1.FirstName.CompareTo(empl2.FirstName) == -1)
                    return -1;
                else
                    return 1;
            }
        else
        {
            if (empl1.SurName.CompareTo(empl2.SurName) == -1)
                return -1;
            else
                return 1;
        }
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
        {
            if (Salary == other.Salary)
                return 0;
            else if (Salary < other.Salary)
                return -1;
            else
                return 1;
        }
    }

    override public string ToString()
    {
        return string.Format("Surname: " + SurName + "\nFirstname: " + FirstName + "\nPatronymic:" + Patronymic + "\nBirthdate: " + Birthdate + "\nSalary: " + Salary);
    }
}
