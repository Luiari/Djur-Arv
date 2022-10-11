using System;

namespace Djur_Arv
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Dog dog = new Dog ("Hund","Milo","Foder", "woff", true,10,"Spin");
            Elefant elefant = new Elefant("Elefant", "Leno", "Frukt", "Praaaw",false,6000);
            Panda panda = new Panda("Panda","Emil", "Bambu", "Raaawr", false,5);
            Tax tax = new Tax("Hund", "Sigge", "Foder", "Woff", true,4);

            dog.MakeSound();
            elefant.MakeSound();
            panda.MakeSound();
            tax.numberofpuppies();
            panda.Pat();

            Console.ReadKey();
            
        }
    }
}
