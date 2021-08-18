using System;

namespace leeson6_17_08_2021
{
    class Programmer
    {
        public string Name;
        public string Gender;
        public string Level;
        public int Age;
        public string Language;

        public void WriteInfo()
        {
            Console.WriteLine($"Информация о программиста {Language}" );
            Console.WriteLine($"имя: {Name}, пол: {Gender}, уровень: {Level}, Возраст: {Age}");
        }

        public void CalculateYearOfBirth()
        { 
            var YearofBirth=  DateTime.Now.Year - Age;
            Console.WriteLine(YearofBirth);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Programmer go = new Programmer
            {
                Name = "Джонибек",
                Gender = "мужской",
                Level = "сеньор",
                Age = 31,
                Language = "golang"
            };
            go.WriteInfo();
            go.CalculateYearOfBirth();

            
            Programmer php = new Programmer
            {
                Name = "Эрадж",
                Gender = "мужской",
                Level = "миддл",
                Age = 27,
                Language = "php"
            };
            php.WriteInfo();
            php.CalculateYearOfBirth();

        }
    }
}