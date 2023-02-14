using DesignPatterns.Prototype;

var bigObject = new BigObject("The Original Big Object");
Console.WriteLine(bigObject.Name);

var bigObjectClone = bigObject.Clone();
Console.WriteLine(bigObjectClone.Name);