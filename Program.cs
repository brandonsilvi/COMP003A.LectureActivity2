internal class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter the first number: ");
        string input1 = Console.ReadLine();

        Console.Write("Enter the second number: ");
        string input2 = Console.ReadLine();

        double a = double.Parse(input1);
        double b = double.Parse(input2);

        double sum = a + b;
        double average = (a + b) / 2.0;
    }    
}