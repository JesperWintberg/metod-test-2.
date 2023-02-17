namespace namn
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1. Omvandla Celsius till Fahrenheit");
            Console.WriteLine("2. Omvandla Fahrenheit till Celsius");
            Console.Write("Vad vill du göra: ");
            string val = Console.ReadLine();

            if (val == "1")
            {
                Console.Write("Skriv in ditt tal i Celsius");
                int celsius = Convert.ToInt32(Console.ReadLine());
                double Fahremheit = celsiustofahrenheit(celsius);

                Console.WriteLine($"Dtt celsius tal blir {Fahremheit} grader i farenheit");
            }

            else if(val == "2")
            {
                Console.WriteLine("Skriv in ditt tal i Fahrenheit");
                int fahremheit2 = Convert.ToInt32(Console.ReadLine());
                double celsius = fahrenheittocelsius(fahremheit2);

                Console.WriteLine($"Ditt Fhrenheit tal blir {celsius} grader celsius");
            }
        }

        static double celsiustofahrenheit(int c)
        {
            double f = ((c*1.8)+32);
            return f;
        }

        static double fahrenheittocelsius(int d)
        {
            double k = ((d-32)/1.8);
            return k;
        }
    }
}
