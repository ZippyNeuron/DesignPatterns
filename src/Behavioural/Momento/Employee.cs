namespace DesignPatterns.Momento;

public class Employee
{
    public Employee(string name, decimal salary)
    {
        Name = name;
        Salary = salary;
    }
    
    public string? Name { get; private set; }
    public decimal Salary { get; private set; }

    public IMomento State()
    {
        return new EmployeeMomento()
        {
            Name = Name,
            Salary = Salary
        };
    }

    public void State(IMomento momento)
    {
        if (momento is not EmployeeMomento state)
        {
            return;
        }

        Name = state.Name;
        Salary = state.Salary;
    }
}