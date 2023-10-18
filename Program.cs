using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;

namespace Labb6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //objekten skapas här
            Animal animal1 = new Animal("Alla djur gör ett ljud", "Alla djur tycker om mat", "Alla djur har flera släkten", 13, 500);
            Monkey monkey1 = new Monkey("Apor luktar illa", "Alla djur gör ett ljud", "Alla djur tycker om mat", "Alla djur har flera släkten", 13, 500);
            Tiger tiger1 = new Tiger("Apor luktar illa", "Alla djur gör ett ljud", "Alla djur tycker om mat", "Alla djur har flera släkten", 13, 500);
            Pinktiger pinktiger1 = new Pinktiger("Råsa tiger är väldigt sällsynt", "Alla rovdjur jagar andra djur som mat", "Alla djur gör ett ljud", "Alla djur tycker om mat", "Alla djur har flera släkten", 13, 500);
            Bluetiger bluetiger1 = new Bluetiger("blå tiger är väldigt sällsynt", "Alla rovdjur jagar andra djur som mat", "Alla djur gör ett ljud", "Alla djur tycker om mat", "Alla djur har flera släkten", 13, 500);
            Penguin penguin1 = new Penguin("Alla pingviner bor där det är som kallast", "Alla djur gör ett ljud", "Alla djur tycker om mat", "Alla djur har flera släkten", 13, 500);
            //Här skapas en lista för alla djuren
            List<Animal> enLista = new List<Animal>();
            enLista.Add(monkey1);
            enLista.Add(tiger1);
            enLista.Add(pinktiger1);
            enLista.Add(bluetiger1);
            enLista.Add(penguin1);
            //Här loopar den tills alla i listan är klar
            foreach (var animal in enLista)

            {
                animal.makeSound();
            }
        }
    }
    //klass Animal
    public class Animal
    {
        //variablar
        private string _Sound { get; set; }
        private string _Food { get; set; }
        private string _Type { get; set; }
        private int _Age { get; set; }
        private int _Population { get; set; }
        //Konstruktorn
        public Animal(string sound = "Alla djur gör ett ljud", string food = "Mat",string type = "Släkteskap",int age = 5,int population = 400)
        {
            _Sound = sound;
            _Food = food;
            _Type = type;
            _Age = age;
            _Population = population;
        }
        //Metod
        //Beskriver läten av djur
        public virtual void makeSound()
        {
            Console.WriteLine("Alla djur gör ett ljud");
        }
        //Beskriver population av djur
        public void population()
        {
            Console.WriteLine("Det finns många kvar innan utrotning av dessa djur");
        }
        //Beskriver ålder
        public void age()
        {
            Console.WriteLine("Alla djur har en ålder");
        }
    }
    //klass Monkey inuti Animal
    public class Monkey : Animal
    {
        //Variabel
        private string _Smell { get; set; }
        //Konstruktor
        public Monkey(string smell = "De luktar illa", string sound = "Alla djur gör ett ljud", string food = "Mat",string type = "Släkteskap",int age = 5,int population = 400) : base(sound, food, type, age, population)
        {
            _Smell = smell;
        }
        //Metoder
        //Beskriver hur en apa luktar
        public void smell()
        {
            Console.WriteLine(_Smell);
        }
        //Beskriver ljudet av en apa
        public override void makeSound()
        {
            Console.WriteLine("Woohaahaa");
        }
    }
    //Tiger klass inuti Animal
    public class Tiger : Animal
    {
        //Variablar
        private string _Predator { get; set; }
        //Konstruktor
        public Tiger(string predator = "De jagar andra djur", string sound = "Alla djur gör ett ljud", string food = "Mat", string type = "Släkteskap", int age = 5, int population = 400) : base(sound, food, type, age, population)
        {
            _Predator = predator;
        }
        //Metoder
        //Beskriver tigerns ras och metod för mat
        public void predator()
        {
            Console.WriteLine(_Predator);
        }
        //Beskriver ljudet av en tiger
        public override void makeSound()
        {
            Console.WriteLine("Raaaawr");
        }
    }
    //Rosatiger klass
    public class Pinktiger : Tiger
    {
        //Variablar
        private string _Pinktiger { get; set; }
        //Konstruktor
        public Pinktiger(string pinktiger = "Väldigt sällsynta", string predator = "De jagar andra djur", string sound = "Alla djur gör ett ljud", string food = "Mat", string type = "Släkteskap", int age = 5, int population = 400) : base(predator, sound, food, type, age, population)
        {
            _Pinktiger = pinktiger;
        }
        //Metod
        //Beskriver rosatigerns ras och hur den får tag i mat
        public void pinktiger()
        {
            Console.WriteLine(_Pinktiger);
        }
    }
    //Blåtiger klass
    public class Bluetiger : Tiger
    {
        //Variablar
        private string _Bluetiger { get; set; }
        //Konstruktor
        public Bluetiger(string bluetiger = "Väldigt sällsynta", string predator = "De jagar andra djur", string sound = "Alla djur gör ett ljud", string food = "Mat", string type = "Släkteskap", int age = 5, int population = 400) : base(predator, sound, food, type, age, population)
        {
            _Bluetiger = bluetiger;
        }
        //Metod
        //Beskriver blåtigerns ras och hur den får tag i mat
        public void bluetiger()
        {
            Console.WriteLine(_Bluetiger);
        }
    }
    //Klass för pingvin
    public class Penguin : Animal
    {
        //Variablar
        private string _Area { get; set; }
        //Konstruktor
        public Penguin(string area = "Det måste vara väldigt kallt område", string sound = "Alla djur gör ett ljud", string food = "Mat", string type = "Släkteskap", int age = 5, int population = 400) : base(sound, food, type, age, population)
        {
            _Area = area;
        }
        //Metoder
        //Skriver ut vad för livsområde en pingvin behöver
        public void area()
        {
            Console.WriteLine(_Area);
        }
        //Skriver ut ljud av en pingvin
        public override void makeSound()
        {
            Console.WriteLine("Pweep");
        }
    }
}