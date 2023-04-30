
namespace AdapterPattern
{
    internal static class Program
    {
        private static void Main()
        {
            var turkey = new WildTurkey();
            var duck = new MallardDuck();
            var adapter = new TurkeyAdapter(turkey);
            Console.WriteLine("turkey");
            Tester(adapter);
            Console.WriteLine("duck");
            Tester(duck);
        }

        private static void Tester(IDuck duck)
        {
            duck.Fly();
            duck.Quack();
        }
    }
}
