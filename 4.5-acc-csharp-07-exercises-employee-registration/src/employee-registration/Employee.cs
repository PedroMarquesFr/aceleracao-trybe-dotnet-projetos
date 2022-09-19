namespace employee_registration;

public class Employee
{
    protected class Account
    {
        public string _account;
        public string _digit;

        public Account(string account, string digit)
        {
            _account = account;
            _digit = digit;
        }
    };

    public string Name;
    private double _salary;

    protected Account? _employeeAccount;

    public Employee(string name, double salary)
    {
        Name = name;
        _salary = salary;
    }

    public void setAccount(string account, string digit)
    {
        _employeeAccount = new Account(account, digit);
    }

    public void Print()
    {
        Console.WriteLine($"Olá meu nome é {Name}");
    }

    public void Pay()
    {
        Console.WriteLine($"{Name} foi pago em {_salary}");
    }
}
