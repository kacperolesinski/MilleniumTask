using Domain.Entities;
using System.Collections.Generic;

namespace Domain.Interfaces
{
    public interface IPersonRepository
    {
        IEnumerable<Person> GetAll();

        Person GetById(int id);

        Person Create(Person person);

        void Update(Person person);
        void Delete(Person person);

    }
}
