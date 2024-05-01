namespace Enum.Classes
{
    internal class Operations
    {
        public static double Toplama(double x, double y)
        {
            return x + y;
        }

        public static double Cixma(double x, double y)
        {
            return x - y;
        }

        public static double Vurma(double x, double y)
        {
            return x * y;
        }

        public static double Bolme(double x, double y)
        {
            if (y == 0)
            {
                Console.WriteLine("0-a bolme olmadigi ucun ikinci teref 0 ola bilmez.");
            }
            return x / y;
        }
    }
}
