using static System.Console;

namespace Exercise.Factory
{
    public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public override string ToString()
        {
            return $"Id: {Id}, Name: {Name}";
        }
    }

    public class PersonFactory
    {
        private int nextId = 0;

        public Person CreatePerson(string name)
        {
            return new Person { Id = nextId++, Name = name };
        }
    }


    class Program
    {
        static void Main()
        {
            var pf = new PersonFactory();
            WriteLine(pf.CreatePerson("Fulano"));
            WriteLine(pf.CreatePerson("Ciclano"));
            ReadKey();
        }
    }
}
