using DesignPatterns.Momento;

var store = new MomentoStore();

var employee = new Employee("Mark Twain", 85000m);
var momento = employee.State();
store.Store(momento);

employee = new Employee("Charles Babbage", 125000m);
momento = employee.State();
store.Store(momento);

employee = new Employee("Alan Turing", 12000m);
momento = employee.State();
store.Store(momento);

momento = store.Fetch();
employee.State(momento);
Console.WriteLine($"{employee.Name}'s salary is {employee.Salary:N0}");

momento = store.Fetch();
employee.State(momento);
Console.WriteLine($"{employee.Name}'s salary is {employee.Salary:N0}");

momento = store.Fetch();
employee.State(momento);
Console.WriteLine($"{employee.Name}'s salary is {employee.Salary:N0}");
