namespace Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Part 1


            //struct Point
            //        {
            //            public double X { get; set; }
            //            public double Y { get; set; }

            //            public Point(double x, double y)
            //            {
            //                X = x;
            //                Y = y;
            //            }

            //            public double DistanceTo(Point other)
            //            {
            //                return Math.Sqrt(Math.Pow(X - other.X, 2) + Math.Pow(Y - other.Y, 2));
            //            }
            //        }

            //        static void Part1()
            //        {
            //            Console.WriteLine("Enter the coordinates of the first point (X Y):");
            //            string[] input1 = Console.ReadLine().Split();
            //            Point p1 = new Point(double.Parse(input1[0]), double.Parse(input1[1]));

            //            Console.WriteLine("Enter the coordinates of the second point (X Y):");
            //            string[] input2 = Console.ReadLine().Split();
            //            Point p2 = new Point(double.Parse(input2[0]), double.Parse(input2[1]));

            //            double distance = p1.DistanceTo(p2);
            //            Console.WriteLine($"The distance between the two points is: {distance:F2}");
            //        }




            //        struct Person
            //        {
            //            public string Name { get; set; }
            //            public int Age { get; set; }

            //            public Person(string name, int age)
            //            {
            //                Name = name;
            //                Age = age;
            //            }
            //        }

            //        static void Part1_OldestPerson()
            //        {
            //            Person[] persons = new Person[3];

            //            for (int i = 0; i < 3; i++)
            //            {
            //                Console.WriteLine($"Enter the name of person {i + 1}:");
            //                string name = Console.ReadLine();

            //                Console.WriteLine($"Enter the age of person {i + 1}:");
            //                int age = int.Parse(Console.ReadLine());

            //                persons[i] = new Person(name, age);
            //            }

            //            Person oldest = persons[0];
            //            for (int i = 1; i < persons.Length; i++)
            //            {
            //                if (persons[i].Age > oldest.Age)
            //                {
            //                    oldest = persons[i];
            //                }
            //            }

            //            Console.WriteLine($"The oldest person is {oldest.Name} with age {oldest.Age}.");
            //        }


            #endregion


            #region Part 2
            //    enum SecurityLevel
            //{
            //    Guest,
            //    Developer,
            //    Secretary,
            //    DBA
            //}

            //class HiringDate
            //{
            //    public int Day { get; set; }
            //    public int Month { get; set; }
            //    public int Year { get; set; }

            //    public HiringDate(int day, int month, int year)
            //    {
            //        Day = day;
            //        Month = month;
            //        Year = year;
            //    }

            //    public override string ToString()
            //    {
            //        return $"{Day:D2}/{Month:D2}/{Year}";
            //    }
            //}

            //class Employee
            //{
            //    public int ID { get; set; }
            //    public string Name { get; set; }
            //    public SecurityLevel SecurityLevel { get; set; }
            //    public decimal Salary { get; set; }
            //    public HiringDate HireDate { get; set; }
            //    public char Gender { get; set; }

            //    public Employee(int id, string name, SecurityLevel securityLevel, decimal salary, HiringDate hireDate, char gender)
            //    {
            //        ID = id;
            //        Name = name;
            //        SecurityLevel = securityLevel;
            //        Salary = salary;
            //        HireDate = hireDate;
            //        Gender = gender;

            //        if (Gender != 'M' && Gender != 'F')
            //        {
            //            throw new ArgumentException("Gender must be either 'M' or 'F'.");
            //        }
            //    }

            //    public override string ToString()
            //    {
            //        return $"ID: {ID}, Name: {Name}, Security Level: {SecurityLevel}, Salary: {String.Format("{0:C}", Salary)}, Hire Date: {HireDate}, Gender: {Gender}";
            //    }
            //}

            //static void Part2()
            //{
            //    Employee[] EmpArr = new Employee[3];

            //    EmpArr[0] = new Employee(1, "John Doe", SecurityLevel.DBA, 75000m, new HiringDate(15, 8, 2010), 'M');
            //    EmpArr[1] = new Employee(2, "Jane Smith", SecurityLevel.Guest, 45000m, new HiringDate(10, 5, 2015), 'F');
            //    EmpArr[2] = new Employee(3, "Alice Johnson", SecurityLevel.Developer, 60000m, new HiringDate(20, 3, 2012), 'F');

            //    Array.Sort(EmpArr, (x, y) => x.HireDate.Year.CompareTo(y.HireDate.Year) != 0 ? x.HireDate.Year.CompareTo(y.HireDate.Year) :
            //                                  x.HireDate.Month.CompareTo(y.HireDate.Month) != 0 ? x.HireDate.Month.CompareTo(y.HireDate.Month) :
            //                                  x.HireDate.Day.CompareTo(y.HireDate.Day));

            //    Console.WriteLine("Sorted Employees by Hire Date:");
            //    foreach (var emp in EmpArr)
            //    {
            //        Console.WriteLine(emp);
            //    }
            //}
            #endregion

        }
    }
}
