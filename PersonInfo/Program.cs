namespace PersonInfo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your name: ");
            string firstName = Console.ReadLine();
            Console.Write("Enter your lastname: ");
            string lastName = Console.ReadLine();
            Console.Write("Enter your age: ");
            int age = int.Parse(Console.ReadLine());
            Console.Write("Enter your town: ");
            string town = Console.ReadLine();
            Console.WriteLine("You are {0} {1}, a {2}-years old person from {3}", firstName, lastName, age, town);
        }
    }
}