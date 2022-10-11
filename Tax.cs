using System;
using System.Collections.Generic;
using System.Text;

namespace Djur_Arv
{
    class Tax : Dog
    {
        string animal;
        string Name;
        string Eater;
        string Sound;
        bool Tame;
        string Race;
        int puppies;

        public Tax(string animal, string Name, string Eater, string Sound, bool Tame,int puppies)
           
        {
            this.animal = animal;
            this.Name = Name;
            this.Eater = Eater;
            this.Sound = Sound;
            this.Tame = Tame;
            this.puppies = puppies;
            
       

        }
        public Tax()
        {

        }
        public void numberofpuppies()
        {
            Console.WriteLine("Taxen har "+puppies+ " valpar" );
        }
    }
}
