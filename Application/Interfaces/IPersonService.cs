using Application.Dto;
using System.Collections.Generic;

namespace Application.Interfaces
{
    public interface IPersonService
    {
        IEnumerable<PersonDto> GetAll();

        PersonDto GetById(int id);

        PersonDto Create(PersonDto person);

        void Update(PersonDto person);
        void Delete(PersonDto person);
    }
}
