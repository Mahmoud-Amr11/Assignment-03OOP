using System.Globalization;

namespace Assignment_03OOP
{
    internal class Program
    {
        #region 1-Design and implement a Class for the employees in a company:
        [Flags]
        public enum SecurityLevel
        {
            Guest = 1,
            Developer = 2,
            Secretary = 4,
            DBA = 8,
        }
        public enum Gender
        {
            M,
            F
        }
        public class Employee
        {
            public int ID { get; set; }
            public string Name { get; set; }
            public decimal Salary { get; set; }
            public Gender Gender { get; set; }
            public HireDate HireDate { get; set; }
            public SecurityLevel SecurityLevel { get; set; }

            public Employee(int id, string name, SecurityLevel sec, decimal salary, HireDate hireDate, Gender gender)
            {
                ID = id;
                Name = name;
                SecurityLevel = sec;
                Salary = salary;
                HireDate = hireDate;
                Gender = gender;
            }
            public override string ToString()
            {
                return string.Format($"ID: {ID}, Name: {Name}, Gender: {Gender}, Security: {SecurityLevel}, Salary:  {Salary}, Hire Date: {HireDate}");
            }


        };
        #endregion

        #region 2-Develop a Class to represent the Hiring Date Data
        public class HireDate
        {
            public int Day { get; set; }
            public int Month { get; set; }
            public int Year { get; set; }

            public HireDate(int day, int month, int year)
            {
                Day = day;
                Month = month;
                Year = year;
            }
            public override string ToString()
            {
                return $"{Day.ToString("D2")}/{Month.ToString("D2")}/{Year}";
            }

        }

        #endregion




        static bool Compare(HireDate d1, HireDate d2)
        {
            if (d1.Year > d2.Year) return true;
            if (d1.Year == d2.Year && d1.Month > d2.Month) return true;
            if (d1.Year == d2.Year && d1.Month == d2.Month && d1.Day > d2.Day) return true;
            return false;
        }
        static void Main(string[] args)
        {
            #region 3.Create an array of Employees with size three a DBA, Guest and the third one is security officer who have full permissions. (Employee [] EmpArr;)
            //Employee[] EmpArr = new Employee[3];
            //EmpArr[0] = new Employee(1, "Ali", SecurityLevel.DBA, 15000, new HireDate(5, 3, 2020), Gender.M);
            //EmpArr[1] = new Employee(2, "Sara", SecurityLevel.Guest, 8000, new HireDate(15, 6, 2021), Gender.F);
            //EmpArr[2] = new Employee(3, "Mona", SecurityLevel.DBA | SecurityLevel.Guest | SecurityLevel.Developer | SecurityLevel.Secretary, 20000, new HireDate(10, 1, 2019), Gender.F);

            #region 4.Sort the employees based on their hire date then Print the sorted array.

            //for (int i = 0; i < EmpArr.Length - 1; i++)
            //{
            //    for (int j = 0; j < EmpArr.Length - i - 1; j++)
            //    {
            //        if (Compare(EmpArr[j].HireDate, EmpArr[j + 1].HireDate))
            //        {
            //            Employee temp = EmpArr[j];
            //            EmpArr[j] = EmpArr[j + 1];
            //            EmpArr[j + 1] = temp;
            //        }
            //    }
            //}
            #endregion




            //foreach (Employee emp in EmpArr)
            //{
            //    Console.WriteLine(emp);
            //}
            #endregion

            #region 5-Design a program for a library management system where:

            List<Book> library = new List<Book>();

            library.Add(new EBook("Digital Fortress", "Dan Brown", "123", 2.5));
            library.Add(new PrintedBook("The Hobbit", "john", "456", 310));

            

            foreach (Book book in library)
            {
                book.DisplayInfo(); 
            }
            #endregion
        }

        #region Book is a base class with properties like Title, Author, and ISBN.
        public class Book
        {
            public string Title { get; set; }
            public string Author { get; set; }
            public string ISBN { get; set; }

            public Book(string title, string author, string isbn)
            {
                Title = title;
                Author = author;
                ISBN = isbn;
            }


            public virtual void DisplayInfo()
            {
                Console.WriteLine($"Title: {Title}, Author: {Author}, ISBN: {ISBN}");
            }
        }
        #endregion

        #region EBook and PrintedBook are derived classes with additional properties like FileSize for EBook and PageCount for PrintedBook. Demonstrate how inheritance simplifies the design.
        public class EBook : Book
        {
            public double FileSize { get; set; }

            public EBook(string title, string author, string isbn, double fileSize)
                : base(title, author, isbn)
            {
                FileSize = fileSize;
            }

            public override void DisplayInfo()
            {
                base.DisplayInfo();
                Console.WriteLine($"File Size: {FileSize} MB\n");
            }
        }

        public class PrintedBook : Book
        {
            public int PageCount { get; set; }

            public PrintedBook(string title, string author, string isbn, int pageCount)
                : base(title, author, isbn)
            {
                PageCount = pageCount;
            }

            public override void DisplayInfo()
            {
                base.DisplayInfo();
                Console.WriteLine($"Page Count: {PageCount} pages\n");
            }
        }


        #endregion

    }
}

