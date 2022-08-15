namespace Strategy.Strategies
{
    internal class Strategy3 : IStrategy
    {
        void IStrategy.DoingSomething()
        {
            Console.WriteLine("Business logic in third strategy");
        }
    }
}
