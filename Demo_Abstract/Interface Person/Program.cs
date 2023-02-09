namespace Interface_Person
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Citizen citizen = new Citizen("Khoa", 20);

            Console.WriteLine("Name: " + citizen.Name);
            Console.WriteLine("Age: " + citizen.Age);


        }
    }
}