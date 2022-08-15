using Strategy;
using Strategy.Strategies;

Context client = new("Fisrst client");

client.ContextLogic();

client.SetStrategy(new Strategy1());

client.ContextLogic();

client.SetStrategy(new Strategy2());

client.ContextLogic();

Console.ReadLine();