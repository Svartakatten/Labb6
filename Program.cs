using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;

namespace Labb6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Animal animal1 = new Animal("Alla djur gör ett ljud", "Alla djur tycker om mat", "Alla djur har flera släkten", 13, 500);
            Monkey monkey1 = new Monkey("Apor luktar illa", "Alla djur gör ett ljud", "Alla djur tycker om mat", "Alla djur har flera släkten", 13, 500);
            Tiger tiger1 = new Tiger("Apor luktar illa", "Alla djur gör ett ljud", "Alla djur tycker om mat", "Alla djur har flera släkten", 13, 500);
            Pinktiger pinktiger1 = new Pinktiger("Råsa tiger är väldigt sällsynt", "Alla rovdjur jagar andra djur som mat", "Alla djur gör ett ljud", "Alla djur tycker om mat", "Alla djur har flera släkten", 13, 500);
            Bluetiger bluetiger1 = new Bluetiger("blå tiger är väldigt sällsynt", "Alla rovdjur jagar andra djur som mat", "Alla djur gör ett ljud", "Alla djur tycker om mat", "Alla djur har flera släkten", 13, 500);
            Penguin penguin1 = new Penguin("Alla pingviner bor där det är som kallast", "Alla djur gör ett ljud", "Alla djur tycker om mat", "Alla djur har flera släkten", 13, 500);
            List<Animal> enLista = new List<Animal>();
            enLista.Add(monkey1);
            enLista.Add(tiger1);
            enLista.Add(pinktiger1);
            enLista.Add(bluetiger1);
            enLista.Add(penguin1);
            foreach (var animal in enLista)

            {
                animal.makeSound();
            }
        }
    }
    public class Animal
    {
        private string _Sound { get; set; }
        private string _Food { get; set; }
        private string _Type { get; set; }
        private int _Age { get; set; }
        private int _Population { get; set; }
        public Animal(string sound = "Alla djur gör ett ljud", string food = "Mat",string type = "Släkteskap",int age = 5,int population = 400)
        {
            _Sound = sound;
            _Food = food;
            _Type = type;
            _Age = age;
            _Population = population;
        }
        public virtual void makeSound()
        {
            Console.WriteLine("Alla djur gör ett ljud");
        }
        public void population()
        {
            Console.WriteLine("Det finns många kvar innan utrotning av dessa djur");
        }
        public void age()
        {
            Console.WriteLine("Alla djur har en ålder");
        }
    }
    public class Monkey : Animal
    {
        private string _Smell { get; set; }

        public Monkey(string smell = "De luktar illa", string sound = "Alla djur gör ett ljud", string food = "Mat",string type = "Släkteskap",int age = 5,int population = 400) : base(sound, food, type, age, population)
        {
            _Smell = smell;
        }
        public void smell()
        {
            Console.WriteLine(_Smell);
        }
        public override void makeSound()
        {
            Console.WriteLine("Woohaahaa");
        }
    }
    public class Tiger : Animal
    {
        private string _Predator { get; set; }
        public Tiger(string predator = "De jagar andra djur", string sound = "Alla djur gör ett ljud", string food = "Mat", string type = "Släkteskap", int age = 5, int population = 400) : base(sound, food, type, age, population)
        {
            _Predator = predator;
        }
        public void predator()
        {
            Console.WriteLine(_Predator);
        }
        public override void makeSound()
        {
            Console.WriteLine("Raaaawr");
        }
    }
    public class Pinktiger : Tiger
    {
        private string _Pinktiger { get; set; }
        public Pinktiger(string pinktiger = "Väldigt sällsynta", string predator = "De jagar andra djur", string sound = "Alla djur gör ett ljud", string food = "Mat", string type = "Släkteskap", int age = 5, int population = 400) : base(predator, sound, food, type, age, population)
        {
            _Pinktiger = pinktiger;
        }
        public void pinktiger()
        {
            Console.WriteLine(_Pinktiger);
        }
    }
    public class Bluetiger : Tiger
    {
        private string _Bluetiger { get; set; }
        public Bluetiger(string bluetiger = "Väldigt sällsynta", string predator = "De jagar andra djur", string sound = "Alla djur gör ett ljud", string food = "Mat", string type = "Släkteskap", int age = 5, int population = 400) : base(predator, sound, food, type, age, population)
        {
            _Bluetiger = bluetiger;
        }
        public void bluetiger()
        {
            Console.WriteLine(_Bluetiger);
        }
    }
    public class Penguin : Animal
    {
        private string _Area { get; set; }
        public Penguin(string area = "Det måste vara väldigt kallt område", string sound = "Alla djur gör ett ljud", string food = "Mat", string type = "Släkteskap", int age = 5, int population = 400) : base(sound, food, type, age, population)
        {
            _Area = area;
        }
        public void area()
        {
            Console.WriteLine(_Area);
        }
        public override void makeSound()
        {
            Console.WriteLine("Pweep");
        }
    }
}