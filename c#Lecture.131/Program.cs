using System;

namespace arayuzler_ornek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Focus focus = new Focus();
            Console.WriteLine(focus.HangiMarkanınAraci().ToString());
            Console.WriteLine(focus.KacTekerlektenOlusur().ToString());
            Console.WriteLine(focus.StandartRengiNe().ToString());
            Console.WriteLine("**********INTERFACE*********");
            Focus civic = new Focus();
            Console.WriteLine(civic.HangiMarkanınAraci().ToString());
            Console.WriteLine(civic.KacTekerlektenOlusur().ToString());
            Console.WriteLine(civic.StandartRengiNe().ToString());
            Console.WriteLine("**********ABSTRACT*********");
            Focus focus1 = new NewFocus();
            Console.WriteLine(focus1.HangiMarkanınAraci().ToString());
            Console.WriteLine(focus1.KacTekerlektenOlusur().ToString());
            Console.WriteLine(focus1.StandartRengiNe().ToString());
            Console.WriteLine("*******************");
            Focus civic1 = new NewCivic();
            Console.WriteLine(civic1.HangiMarkanınAraci().ToString());
            Console.WriteLine(civic1.KacTekerlektenOlusur().ToString());
            Console.WriteLine(civic1.StandartRengiNe().ToString());
        }
    }
}
