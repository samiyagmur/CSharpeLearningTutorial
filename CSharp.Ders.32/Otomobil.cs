namespace arayuz_ornek
{
    public abstract class Otomobil
    {
        public int KactekerlektenOlusur()
        {
            return 4;
        }

        public virtual Renk StandarRengine()
        {
            return Renk.Beyaz;
        }
        public abstract Marka HangiMarkanınAraci()
        {

        }
    }
}