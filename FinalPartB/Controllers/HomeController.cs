using FinalPartB.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;

namespace FinalPartB.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";

            return View();
        }

        public ActionResult Planets()
        {
            List<Planet> planets = new List<Planet>();
            ViewBag.Title = "Planets";
            var client = new HttpClient();
            for (int i = 1; i < 61; i++)
            {
                
                var result = client.GetAsync($"https://swapi.co/api/planets/{i}").Result;
                var planet = result.Content.ReadAsAsync<Planet>().Result;
                planet.Id = i;
                planets.Add(planet);
               
            }

            return View(planets);
        }

        public ActionResult People()
        {
            ViewBag.Title = "People";
            List<Person> people = new List<Person>();
            ViewBag.Title = "Planets";
            var client = new HttpClient();
            for (int i = 1; i < 87; i++)
            {

                var result = client.GetAsync($"https://swapi.co/api/people/{i}").Result;
                var person = result.Content.ReadAsAsync<Person>().Result;
                person.Id = i;
                people.Add(person);

            }


            return View(people);
           
        }

        public ActionResult PlanetDetails(int id)
        {
            var client = new HttpClient();
            var result = client.GetAsync($"https://swapi.co/api/planets/{id}").Result;
            var planet = result.Content.ReadAsAsync<Planet>().Result;
            return View(planet);
        }

        public ActionResult PeopleDetails(int id)
        {
            var client = new HttpClient();
            var result = client.GetAsync($"https://swapi.co/api/people/{id}").Result;
            var person = result.Content.ReadAsAsync<Person>().Result;
            return View(person);
            
        }

    }
}
