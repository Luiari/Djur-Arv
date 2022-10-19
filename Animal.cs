//Antonio Ariza Gomez .NET22

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


       public  Animal(string animal, string Name, string Eater, string Sound, bool Tame,int age) //Constructor
        {
            
            this.Name = Name;
            this.Eater = Eater;
            this.Sound = Sound;
            this.Tame= Tame;
            this.age = age;
            this.kg = kg;


        }
        
        public Animal()//Defaultvärden i basklassen
        {
            this.Name = "Inget Namn";
            this.age = 0;
            this.Tame = false;
            this.animal = "Oidentifierat";
            this.Sound = "Inget ljud";
            this.kg = 0;
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
