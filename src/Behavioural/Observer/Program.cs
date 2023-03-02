using DesignPatterns.Observer;

var controller = new TrackController();

var train1 = new Train("Eurostar");
var train2 = new Train("Hogwarts Express");
var train3 = new Train("Orient Express");

controller.AddTrain(train1);
controller.AddTrain(train2);
controller.AddTrain(train3);

controller.Go(train1);
Thread.Sleep(1000);
controller.Go(train2);
Thread.Sleep(1000);
controller.Go(train3);