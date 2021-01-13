using Microsoft.AspNetCore.Mvc;
using MongoDB.Driver;
using System;
using System.Collections.Generic;

namespace covid_project.Controllers
{
    public class HomeController : Controller
    {
        public List<Person> GetAllPersons()
        {
            return Persistance.FindAll();
        }

        public List<Person> GetAllSuspected()
        {
            return Persistance.FindSuspected();
        }

        public List<Person> GetAllAffected()
        {
            return Persistance.FindAffected();
        }
        public List<Person> GetAllNonAffected()
        {
            return Persistance.FindNonAffected();
        }

        [HttpPost]
        public void InsertPerson(Person p)
        {
            try
            {
                Persistance.InsertPerson(p);
            }catch(Exception e)
            {
                throw e;
            }
        }
    }
}
