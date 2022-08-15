namespace Strategy.Strategies
{
    internal class Strategy2 : IStrategy
    {
        void IStrategy.DoingSomething()
        {
            Console.WriteLine("Business logic in the second strategy");
        }
    }
}
