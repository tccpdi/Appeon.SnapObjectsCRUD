using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AdventureWorks.Models;


namespace AdventureWorks.Services.Impl
{
    public class PersonsService : IPersonsService
    {
        private readonly AWDataContext _context;
        
        public PersonsService(AWDataContext Context)
        {
            _context = Context;
        }
        
        public bool Delete(Person person)
        {
            throw new NotImplementedException();
        }

        public bool Insert(Person person)
        {
            throw new NotImplementedException();
        }

        public List<Person> Load()
        {
            return _context.SqlModelMapper.Load<Person>().ToList();
        }

        public IList<PersonByFirstName> LoadByFirstName(string fName)
        {
            return _context.SqlModelMapper.Load<PersonByFirstName>(fName).ToList();
        }

        public Person LoadByID(int idPerson)
        {
            return _context.SqlModelMapper.LoadByKey<Person>(idPerson).FirstOrDefault();
        }
        
        public int CountPersons()
        {
            return _context.SqlModelMapper.Count<Person>();
        }

        public bool Update(Person person)
        {
            throw new NotImplementedException();
        }
    }
}
