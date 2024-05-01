namespace ConsoleApp1.Classes
{
    internal class BankAccount
    {
        public double AccountNumber;
        public double Balance;

        public void AccBal()
        {
            Console.WriteLine("AccountNumber daxil edin: ");
            double accnum = Convert.ToDouble(Console.ReadLine());
            if (accnum == AccountNumber) {
                Console.WriteLine("Daxil etmek istediyiniz meblegi qeyd edin: ");
                double daxiledilennum = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine(Balance + daxiledilennum);
            }
            else { Console.WriteLine("AccountNumber daxil edin: "); }
        }
    }
}
