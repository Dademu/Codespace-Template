using DesignPatterns.Observer;


var Subject = new Subject<string>();
var upperCaseObserver = new UpperCaseObserver();
var lowerCaseObserver = new LowerCaseObserver();

Subject.Subscribe(upperCaseObserver);
Subject.Subscribe(lowerCaseObserver);

Subject.Value = Console.ReadLine() ?? "";

Console.ReadLine();