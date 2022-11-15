using Ohce;

var greeter = new Greeter(new Return_Oclock());
var greetings = greeter.Greet();
Console.WriteLine(greetings);
var ui = new UI(new Interactor());
ui.MainLoop();
