using System;
using System.Collections.Generic;
using System.Text;

namespace Djur_Arv
{
    class Panda:Animal
    {
        string animal;
        string Name;
        string Eater;
        string Sound;
        bool Tame;
        int Age;
        public Panda(string animal, string Name, string Eater, string Sound, bool Tame,int Age)
        {
            this.animal = animal;
            this.Name = Name;
            this.Eater = Eater;
            this.Sound = Sound;
            this.Tame = Tame;
            this.Age = Age;
        }
        public Panda()
        {
            this.Age = Age;
            this.Name = Name;
               
        }

        public void Humanyears()
        {
           Console.WriteLine("Pandan är "+Age* 4 +" i människoår");
        }
        public override void MakeSound()
        {
            Console.WriteLine(Name + " låter " + Sound);
        }
        public void Pat()
        {
            Console.WriteLine("Du borde inte klappa! " + Name+" är inte tam.");
        }

    }

}
