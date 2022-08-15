namespace Strategy.Strategies
{
    internal class Strategy1 : IStrategy
    {
        void IStrategy.DoingSomething()
        {
            Console.WriteLine("Business logic in the first strategy");
        }
    }
}
