using DesignPatterns.Proxy;

var repository = new SlowRepository();
repository.GetItems();
repository.GetItems();

var proxy = new SlowRepositoryProxy();
proxy.Token = "a7UkF20ATM9sqOT4_6";
proxy.GetItems();
proxy.GetItems();