namespace arayuzler_ornek
{
    public class Civic : IOtomobil
    {
        public Marka HangiMarkanınAraci()
        {
            return Marka.Honda;
        }

        public int KacTekerlektenOlusur()
        {
            return 4;
        }

        public Renk StandartRengiNe()
        {
            return Renk.Gri;
        }
    }
}
