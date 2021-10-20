using Application.Dto;
using Application.Interfaces;
using AutoMapper;
using Domain.Entities;
using Domain.Interfaces;
using System.Collections.Generic;

namespace Application.Services
{
    public class PersonService : IPersonService
    {
        private readonly IPersonRepository _personRepository;
        private readonly IMapper _mapper;

        public PersonService(IPersonRepository personRepository, IMapper mapper)
        {
            _personRepository = personRepository;
            _mapper = mapper;
        }
        public PersonDto Create(PersonDto person)
        {
            throw new System.NotImplementedException();
        }

        public void Delete(PersonDto person)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<PersonDto> GetAll()
        {
            IEnumerable<Person> persons = _personRepository.GetAll();
            return _mapper.Map<IEnumerable<PersonDto>>(persons);
        }

        public PersonDto GetById(int id)
        {
            Person person = _personRepository.GetById(id);
            return _mapper.Map<PersonDto>(person);
        }

        public void Update(PersonDto person)
        {
            throw new System.NotImplementedException();
        }
    }
}
