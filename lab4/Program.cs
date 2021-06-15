using System;
using System.Text;

namespace lab4
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.OutputEncoding=Encoding.UTF8;
            var student = new Student()
            {
                Name = "Đào Quang Huy",
                PhoneNumber = "0981977600",
                Email = "huy@gmail.com",
                Program = "Computer Science"
            };
            Console.WriteLine((student.ToString()));
            var staff = new Staff
            {
                Name = "Nguyễn Tiến Dũng",
                PhoneNumber = "0365053725",
                Email = "dung@gmail.com",
                Title = "Pawnbroker",
                Salary = 300000,
                Department = "Financial leasing",
                DateHired = 14
            };
            Console.WriteLine(staff.ToString());
            Console.WriteLine($"{staff.Name}'s bonus is: {staff.CalculateBonus()}");
            Console.WriteLine($"{staff.Name}'s number of weeks off is: {staff.CalculateVacation()}");
            var faculty = new Faculty()
            {
                Name = "Hồ Sỹ Quân",
                PhoneNumber = "0564579400",
                Email = "quanfb@gmail.com",
                OfficeHours = "24/24h",
                Salary = 0,
                DateHired = 1,
                Rank = 100,
                Department = "CEO of Facebook"
            };
            Console.WriteLine(faculty.ToString());
            Console.WriteLine($"{faculty.Name}'s bonus is: {faculty.CalculateBonus()}");
            Console.WriteLine($"{faculty.Name}'s number of weeks off is: {faculty.CalculateVacation()}");
        }
    }
}