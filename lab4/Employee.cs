using System;

namespace lab4
{
    public abstract class Employee: Person
    {
        public string Department { get; set; }
        public double Salary { get; set; }
        public int DateHired { get; set; }
        public abstract int CalculateVacation();
        public abstract double CalculateBonus();
    }
}