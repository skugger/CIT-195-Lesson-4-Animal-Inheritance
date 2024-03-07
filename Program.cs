namespace CIT_195_Lesson_4_Animal_Inheritance
{
    // base Class 
    class Animal
    {
        private string name;        // only accessible within this class
        protected string type;      // accessible from derived classes
        public string color;        // accessible from any class

        public void setName(string name)
        {
            this.name = name;
        }
        public virtual string getName()
        {
            return this.name;
        }
        public void setType(string type)
        {
            this.type = type;
        }
        public virtual string getType()
        { 
            return this.type;
        }
    }
    class Orangutan : Animal
    {
        public string family;
        protected string genus;
        private string species;

        public override string getName()
        {
            return base.getName();
        }
        public override string getType()
        {
            return base.getType();
        }
        public void setGenus(string genus)
        {
            this.genus = genus;
        }
        public string getGenus()
        {
            return this.genus;
        }
        public void setSpecies(string species)
        {
            this.species = species;
        }
        public string getSpecies()
        {
            return this.species;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Animal moose = new Animal();
            moose.setName("Bullwinkle");
            moose.setType("moose");
            moose.color = "brown";

            Console.WriteLine();
            Console.WriteLine($"My name is {moose.getName()}");
            Console.WriteLine($"I am a {moose.getType()}");
            Console.WriteLine($"I am pretty much {moose.color}");

            Orangutan houdini = new Orangutan();
            houdini.setName("Ken Allen");
            houdini.setType("orangutan");
            houdini.color = ("orange");
            houdini.family = ("Hominidae");
            houdini.setGenus("Pongo");
            houdini.setSpecies("pygmaeus");

            Console.WriteLine();
            Console.WriteLine($"My name is {houdini.getName()}");
            Console.WriteLine($"I am a {houdini.getType()}");
            Console.WriteLine($"I am pretty much {houdini.color}");
            Console.WriteLine($"I belong to species {houdini.getSpecies()}");
            Console.WriteLine($"which is part of the genus {houdini.getGenus()}");
            Console.WriteLine($"within the family {houdini.family}");
        }
    }
}
