using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AdventureWorks.Models;

namespace AdventureWorks.Services
{
    public interface IPersonsService
    {
        List<Person> Load();

        IList<PersonByFirstName> LoadByFirstName(string fName);

        Person LoadByID(int idPerson);

        int CountPersons();

        bool Insert(Person person);
        
        bool Update(Person person);
        
        bool Delete(Person person);
    }
}
