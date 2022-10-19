using System;
using System.Collections.Generic;
using System.Text;

namespace Djur_Arv
{
    class Dog:Animal
    {
        string animal;
        string Name;
        string Eater;
        string Sound;
        bool Tame;
        int Age;
        string tricks;
        int kg;
        int puppies;

        public Dog(string animal, string Name, string Eater, string Sound, bool Tame, int age,string tricks)
           
        {
            this.animal = animal;
            this.Name = Name;
            this.Eater = Eater;
            this.Sound = Sound;
            this.Tame = Tame;
            this.tricks = tricks;
           
               
        }
       ///
        public Dog() 
        {
            this.Name = Name;
            this.Eater = Eater;
            
        }
        ///
        public void Tricks()
        {

            Console.WriteLine("Hunden kan "+ tricks);
        }
        public override void MakeSound()
        {
            Console.WriteLine(Name + " låter " + Sound);
        }
    }
}
