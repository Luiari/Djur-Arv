using System;
using System.Collections.Generic;
using System.Text;

namespace Djur_Arv
{
    internal class Animal
    {

        string animal;
        string Name;
        string Eater;
        string Sound;
        bool Tame;
        int age;
        int kg;


       public  Animal(string animal, string Name, string Eater, string Sound, bool Tame,int age)
        {
            this.animal = animal;
            this.Name = Name;
            this.Eater = Eater;
            this.Sound = Sound;
            this.Tame= Tame;
            this.age = age;
            this.kg = kg;


        }
        
        public Animal()//Defaultvärden
        {
            this.Name = "A big animal";
            this.age = 75;
            this.Tame = false;
        }
       //////////////////////////////
        public void Hungry()
        {
            Console.WriteLine(Name + " Är hungrig! " + "Mata med " + Eater); //Metod som skriver ut om djuret är hungrig
        }
        public virtual void MakeSound()
        {
            Console.WriteLine(Name +  " Låter " + Sound);
        }
        public void Pat() // Metoden går att defineras om med override. Override använder jag om djuret inte är tam.
        {
            if (Tame==true)
            {
              Console.WriteLine(" Du kan klappa!" + " " + Name + " är tam.");
            }
            
            else
            {
                Console.WriteLine("Du borde inte klappa!", " " + Name, " är inte tam.");
            }
        }

    }
}
