using DataAccessLibrary.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DataAccessLibrary
{
    public interface IPeopleData
    {
        Task<List<PersonModel>> GetPeople();
        Task InserPerson(PersonModel person);
    }
}