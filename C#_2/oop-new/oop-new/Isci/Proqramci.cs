namespace oop_new.Isci
{
    internal class Proqramci: Isci
    {
        public int IsSaati { get; }
        public int SaatliqMaas { get; }

        public Proqramci(int issaati, int saatliqmaas)
        {
            IsSaati = issaati;  
            SaatliqMaas = saatliqmaas; 
        }

        public override double CalculateSalary()
        {
            return IsSaati * SaatliqMaas;
        }
    }
}
