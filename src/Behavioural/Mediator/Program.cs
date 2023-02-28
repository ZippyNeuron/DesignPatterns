using DesignPatterns.Mediator;

var controller = new Controller();

var aircraft = new List<Aircraft>()
{
    new("Cessna", controller),
    new("Arrow", controller),
    new("Cirrus", controller)
};

var tasks = aircraft
    .Select(a => a.TakeOffAsync());

await Task.WhenAll(tasks);