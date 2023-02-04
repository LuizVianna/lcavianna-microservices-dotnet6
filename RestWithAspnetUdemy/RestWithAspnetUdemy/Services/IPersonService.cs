using RestWithAspnetUdemy.Model;

namespace RestWithAspnetUdemy.Services
{
    public interface IPersonService
    {
        Person Create(Person person);

        Person FindById(long id);

        List<Person> FindAll();

        Person Upadate(Person person);

        void Delete(long id);

    }
}
