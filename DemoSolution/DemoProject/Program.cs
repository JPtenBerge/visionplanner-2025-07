namespace DemoProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");

            //float f1 = 0.3f;
            //float f2 = 0.2f;
            //Console.WriteLine(f1 - f2);

            //var jp = new Human();
            //jp.Name = "Jan Peter";
            //jp.Age = 38;

            var jp = new Human
            {
                Name = "Jan Peter",
                Age = 38
            };
            jp.Speak();

            var elon = new Human
            {
                Name = "Elon Musk",
                Age = 59
            };
            elon.Speak();

            Console.WriteLine($"{jp.Name} is {jp.Age} years old.");



            // lijstjes:
            // arrays

            Animal[] animals = new Animal[10];

            List<Animal> meerAnimals = new List<Animal>();
            meerAnimals.Add(new Dog { Vachtkleur = "bruin" });
            meerAnimals.Add(new Parrot());
            meerAnimals.Add(new Parrot());
            meerAnimals.Add(new Dog { Vachtkleur = "blond" });

            foreach (var dier in meerAnimals)
            {
                dier.MakeNoise();
                //if (dier is Dog)
                //{
                //    var echteDog = (Dog)dier;
                //    Console.WriteLine($"-- en vachtkleur: {echteDog.Vachtkleur}");
                //}
            }


            Console.WriteLine(new Dog().ToString()); ;




        }
    }
}
