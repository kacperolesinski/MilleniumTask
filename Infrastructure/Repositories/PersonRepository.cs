using Domain.Entities;
using Domain.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace Infrastructure.Repositories
{
    public class PersonRepository : IPersonRepository
    {
        private static readonly ISet<Person> _persons = new HashSet<Person>()
        {
            new Person
            {
                Id =1,
                Name = "Name1",
                City = "City1",
                PostalCode = "Code1",
                Street = "Street1",
                Number = "Number1"
            },
            new Person
            {
                Id =2,
                Name = "Name2",
                City = "City2",
                PostalCode = "Code2",
                Street = "Street2",
                Number = "Number2"
            }
            ,
            new Person
            {
                Id =3,
                Name = "Name3",
                City = "City3",
                PostalCode = "Code3",
                Street = "Street3",
                Number = "Number3"
            }
        };
        public Person Create(Person person)
        {
            person.Id = _persons.Count() + 1;
            _persons.Add(person);
            return person;
        }

        public void Delete(Person person)
        {
            _persons.Remove(person);
        }

        public IEnumerable<Person> GetAll()
        {
            return _persons;
        }

        public Person GetById(int id)
        {
            return _persons.SingleOrDefault(p => p.Id.Equals(id));
        }

        public void Update(Person person)
        {
            person.Modify = true;
        }
    }
}
