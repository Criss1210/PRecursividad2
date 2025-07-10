namespace CapitalRecursivo
{
    class Program
    {
        static void Main()
        {
            Console.Write("Introduce el capital inicial (m): ");
            double capitalInicial = double.Parse(Console.ReadLine());

            Console.Write("Introduce la tasa de interes anual (%): ");
            double tasa = double.Parse(Console.ReadLine()) / 100;

            Console.Write("Introduce el numero de años (n): ");
            int años = int.Parse(Console.ReadLine());

            double capitalFinal = CalcularCapitalRecursivo(capitalInicial, tasa, años);

            Console.WriteLine($"\nCapital acumulado despues de {años} años: {capitalFinal:F2}");
        }

        // Funcion recursiva
        static double CalcularCapitalRecursivo(double capital, double tasa, int años)
        {
            if (años == 0)
                return capital;
            else
                return CalcularCapitalRecursivo(capital * (1 + tasa), tasa, años - 1);
        }
    }
}
