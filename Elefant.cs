using System;
using System.Collections.Generic;
using System.Text;

namespace Djur_Arv
{
    class Elefant : Animal
    {
        string animal;
        string Name;
        string Eater;
        string Sound;
        bool Tame;
        int kg;

        public Elefant(string animal, string Name, string Eater, string Sound, bool Tame,int kg)

        {
            this.animal = animal;
            this.Name = Name;
            this.Eater = Eater;
            this.Sound = Sound;
            this.Tame = Tame;
            this.kg = kg;
        }
        public Elefant() 
        {
            this.animal = animal;
            this.Name = Name;
            this.Eater = Eater;
        }


            public void kilogram()
            {
                Console.WriteLine("Elefanten väger " + kg, " kilogram.");
            }
        public override void MakeSound()
        {
            Console.WriteLine(Name + " låter " + Sound);
        }
    }
    }
