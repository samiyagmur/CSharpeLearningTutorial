namespace arayuzler_ornek
{
    public class Focus : IOtomobil
    {
        public Marka HangiMarkanınAraci()
        {
            return Marka.Ford;
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
