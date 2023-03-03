using DesignPatterns.State;

var person = new Person();

person.SmokeAndDrink();
person.Clubbing();
person.Sleeping();

person.State = new StateMiddleAged();
person.SmokeAndDrink();
person.Clubbing();
person.Sleeping();

person.State = new StateOld();
person.SmokeAndDrink();
person.Clubbing();
person.Sleeping();