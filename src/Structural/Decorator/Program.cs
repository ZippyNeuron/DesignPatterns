using DesignPatterns.Decorator;

var cupOTea = new CupOTea();

var cupOTeaWithMilk = new CupOTeaWithMilk(cupOTea);

var cupOTeaWithSugar = new CupOTeaWithSugar(cupOTeaWithMilk);

cupOTeaWithSugar.Make();