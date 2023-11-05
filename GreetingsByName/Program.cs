namespace GreetingsByName
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("enter your name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Hello {0}", name); //1st way
            Console.WriteLine($"Hello {name}"); //2nd way
        }
    }
}