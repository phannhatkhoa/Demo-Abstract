namespace Shapes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please input radius: ");
            var radius = int.Parse(Console.ReadLine());
            IDrawable circle = new Circle(radius);
            Console.WriteLine("Please input width: ");
            var width = int.Parse(Console.ReadLine());
            Console.WriteLine("Please input height: ");
            var height = int.Parse(Console.ReadLine());
            IDrawable rect = new Rectangle(width, height);
            circle.Draw();
            rect.Draw();
        }
    }
}