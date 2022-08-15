using Strategy.Strategies;

namespace Strategy
{
    internal class Context
    {
        private readonly string name;
        private IStrategy? strategy;

        public Context(string name)
        {
            this.name = name;
        }

        public void SetStrategy(IStrategy strategy)
        {
            this.strategy = strategy;
        }

        public void ContextLogic()
        {
            Console.WriteLine(">>>");

            if (strategy is null)
            {
                Console.WriteLine($"{name} can't doing. Set a strategy.");
                return;
            }

            Console.WriteLine($"{name} Doing something before calling method from strategy");

            Console.Write($"{name} ");

            strategy.DoingSomething();

            Console.WriteLine($"{name} Doing something after calling method from strategy");
        }
    }
}
