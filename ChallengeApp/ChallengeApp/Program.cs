using ChallengeApp;

Employee employee1 = new Employee("Wojtek", "Glowa", "40");
Employee employee2 = new Employee("Kubuś", "Puchatek", "10");
Employee employee3 = new Employee("John", "Wick", "50");

employee1.AddScore(1);
employee1.AddScore(3);
employee1.AddScore(5);
employee1.AddScore(7);
employee1.AddScore(9);

employee2.AddScore(9);
employee2.AddScore(7);
employee2.AddScore(5);
employee2.AddScore(3);
employee2.AddScore(1);

employee3.AddScore(8);
employee3.AddScore(6);
employee3.AddScore(3);
employee3.AddScore(4);
employee3.AddScore(7);

List<Employee> employees = new List<Employee>()
{
    employee1 , employee2, employee3
};

int maxResult = -1;
Employee employeeWithMaxResult = null;


foreach (var employee in employees)
{
    if (employee1.Result > maxResult)
    {
        employeeWithMaxResult = employee1;
        maxResult = employee1.Result;
    }
    else if (employee2.Result > maxResult)
    {
        employeeWithMaxResult = employee2;
        maxResult = employee2.Result;
    }
    else if (employee3.Result > maxResult)
    {
        employeeWithMaxResult = employee3;
        maxResult = employee3.Result;
    }
}

Console.WriteLine("Employee with best score" + maxResult + employeeWithMaxResult.Name + employeeWithMaxResult.Surname); 



