namespace arayuzler_ornek
{
    public class Corolla : IOtomobil
    {
        public Marka HangiMarkanınAraci()
        {
            return Marka.Toyota;
        }

        public int KacTekerlektenOlusur()
        {
            return 4;
        }

        public Renk StandartRengiNe()
        {
            return Renk.Beyaz;
        }
    }
}
