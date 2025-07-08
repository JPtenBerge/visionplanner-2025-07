
namespace DemoProject
{
    public class Human
    {
        // testing
        // mocking
        public static int HumanCounter { get; set; }

        public string Name { get; set; }


        public Human() // constructor  new()
        {
            HumanCounter++;
            Console.WriteLine($"new human! counter is nu {HumanCounter}");
        }

        private int _age;
        public int Age
        {
            get
            {
                return _age;
            }
            set
            {
                if (value > 150 || value < 0)
                {
                    throw new ArgumentException("No way die leeftijd");
                }

                Console.WriteLine("Netjes ingevuld ouwe!");
                _age = value;
            }
        }

        public void Speak()
        {
            Console.WriteLine($"Hoi ik ben {Name}");
        }
    }

    public enum Haarkleur
    {
        Blond,
        Bruin,
        Zwart,
        Rood
    }

}

