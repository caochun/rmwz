using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace DAL
{
    public class PersonDAO
    { 
        public void add(Person person) {
            using (var session = ConnectDB.createstore().OpenSession())
            {
                session.Store(person);
                session.SaveChanges();
            }
        }
        public void delete(string personID) {
            var session = ConnectDB.createstore().OpenSession();
            var p = session.Load<Person>(personID);
            session.Delete(p);
            session.SaveChanges();
        }
        public void update(string personID,string lastName,string firstName) {
            var session = ConnectDB.createstore().OpenSession();
            var p = session.Load<Person>(personID);
            p.LastName = lastName;
            p.FirstName = firstName;
            session.SaveChanges();
        }
        public Person getinfo(string personID) {
            var session = ConnectDB.createstore().OpenSession();
            Person p = session.Load<Person>(personID);
            return p;
        }
    }
}
