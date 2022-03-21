using System;
using System.Collections.Generic;
using System.Text;

namespace CS.Sharp.Ders._29
{
    public class Bitkiler : Canlılar
    {
        protected void Fotosentez()
        {
            Console.WriteLine("Bitkiler fotosentez yapar.");
        }


    }
    public class TohumluBitkiler:Bitkiler
    {   
        public TohumluBitkiler()
        {
            base.Fotosentez();
            base.Beslenme();
            base.Boşaltım();
            base.Solunum();

        }
        public void TohumlaCogalma()
        {
            
            Console.WriteLine("Tohumlu bitkiler tozlaşma ile çoğalır");
        }
    }

    public class TohumsuzBitkiler:Bitkiler
    {
        public TohumsuzBitkiler()
        {
            base.Fotosentez();
            base.Beslenme();
            base.Boşaltım();
            base.Solunum();

        }
        public void SporlaCogalma()
        {
            Console.WriteLine("Tohumsuz bitkiler sporla ile çoğalır");
        }
    }
}
