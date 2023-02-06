namespace Demo_Abstract
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Cat cat1 = new Cat("Meow");
            cat1.Run();
            cat1.Eat();
            cat1.Climb();


            Cow cow1 = new Cow("Cow");
            cow1.Run();
            cow1.Eat();
           
        }
    }
}
