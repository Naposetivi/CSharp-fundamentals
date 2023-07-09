namespace BethanysPieShopHRM
{
    internal class Employee
    {
        public string firstName;
        public string lastName;
        public string email;

        public int numberOfHoursWorked;
        public double wage;
        public double hourlyRate;

        public DateTime birthDay;

        const int minimalHoursWorkedUnit = 1;

        public EmployeeType EmployeeType;

        public Employee(string first, string last, string em, DateTime b, double rate, EmployeeType empType)
        {
            this.firstName = first;
            this.lastName = last;
            this.email = em;
            this.hourlyRate = rate;
            this.birthDay = b;
            this.EmployeeType = empType;
        }

        public void PerformWork() {
            PerformWork(minimalHoursWorkedUnit);
        }

        public void PerformWork(int numberOfHours) {
            numberOfHoursWorked += numberOfHours;
            Console.WriteLine($"{firstName} {lastName} has worked for {numberOfHours} hour(s).");
        }

        public double ReceiveWage(bool resetHours = true) {
            if(EmployeeType == EmployeeType.Manager)
            {
                Console.WriteLine($"An exstra was added to the wage since {firstName} is a manager!");
                wage = numberOfHoursWorked * hourlyRate * 1.25;
            }
            else
            {
                wage = numberOfHoursWorked * hourlyRate;
            }

            Console.WriteLine($"{firstName} {lastName} has received a wage of {wage} for {numberOfHoursWorked} hour(s) of work.");

            if(resetHours)
            {
                numberOfHoursWorked = 0;
            }

            return wage;
        }

        public void DisplayEmployeeDetails() {
            Console.WriteLine($"\nFirst name: \t{firstName}\nLast name: \t{lastName}\nEmail: \t{email}\nBirthday: {birthDay.ToShortDateString()}\n");
        }
    }
}
