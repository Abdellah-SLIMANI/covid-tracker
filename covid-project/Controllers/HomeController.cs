using Microsoft.AspNetCore.Mvc;
using MongoDB.Driver;
using System.Collections.Generic;

namespace covid_project.Controllers
{
    public class HomeController : Controller
    {
        public List<Person> GetAllPersons()
        {
            return Persistance.FindAll();
        }
    }
}
