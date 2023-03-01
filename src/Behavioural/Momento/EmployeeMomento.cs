namespace DesignPatterns.Momento;

public class EmployeeMomento : IMomento
{
    internal string? Name;
    internal decimal Salary;

    public DateTime CopyDate => DateTime.Now;
}