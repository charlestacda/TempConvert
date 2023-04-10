class Test
{
    static void Main(string[] args)
    {
        Console.WriteLine("Convert temperature in Celsius to Fahrenheit");
        Console.Write("Enter temperature in Celsius: ");
        double cel, frh;

        Converter convert = new Converter();
        cel = Convert.ToDouble(Console.ReadLine());
        frh = convert.convertTemp(cel);
        Console.WriteLine("The temperature in Fahrenheit: {0}", frh);
        Console.WriteLine("\nPress any key to exit...");
        Console.ReadLine();

    }
}
