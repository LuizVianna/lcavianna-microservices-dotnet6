using RestWithAspnetUdemy.Model;

namespace RestWithAspnetUdemy.Services.Implemetation
{
    public class PersonService : IPersonService
    {
        private volatile int count;


        public Person Create(Person person)
        {
            return person;
        }

        public void Delete(long id)
        {
            
        }

        public List<Person> FindAll()
        {
            List<Person> persons = new List<Person>();
            for (int i = 0; i < 8; i++)
            {
                Person person = MockPerson(i);
                persons.Add(person);
            }
            return persons;
        }

        public Person FindById(long id)
        {
            return new Person
            {
                Id = IncrementAndGet(),
                FirstName = "Luiz",
                LastName = "Vianna",
                Address = "Rio de Janeiro - Rio de Janeiro",
                Gender = "Male"
            };
        }

        public Person Upadate(Person person)
        {
            return person;
        }


        private Person MockPerson(int i)
        {
            return new Person
            {
                Id = IncrementAndGet(),
                FirstName = "Person Name" + i,
                LastName = "Person LastName" + i,
                Address = "Some Address" + i,
                Gender = "Male"
            };
        }

        private long IncrementAndGet()
        {
            return Interlocked.Increment(ref count);
        }
    }
}
