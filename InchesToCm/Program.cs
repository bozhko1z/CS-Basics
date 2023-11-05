namespace InchesToCm
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("inches = ");
            double inches = double.Parse(Console.ReadLine());
            double centimetres = inches * 2.54;
            Console.Write("centimetres = ");
            Console.WriteLine(centimetres);
        }
    }
}