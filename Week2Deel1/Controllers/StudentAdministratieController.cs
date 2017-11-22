using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Week2Deel1.Models;

namespace Week2Deel1.Controllers
{
    public class StudentAdministratieController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet("StudentAdministratie/ZoekStudenten/{zoekterm}", Name = "ZoekStudenten")]
        public IActionResult ZoekStudenten(string zoekterm)
        {
            List<Student> Studenten = new List<Student>
            {
                new Student(){Voornaam = "Kees", Achternaam = "Arends"},
                new Student(){Voornaam = "Piet", Achternaam = "Arends"},
                new Student(){Voornaam = "Kees", Achternaam = "Barends"},
                new Student(){Voornaam = "Hein", Achternaam = "Barends"},
                new Student(){Voornaam = "Anna", Achternaam = "Corn"},
                new Student(){Voornaam = "berta", Achternaam = "Doren"},
                new Student(){Voornaam = "Kees", Achternaam = "Corn"},
                new Student(){Voornaam = "Henk", Achternaam = "Alblas"}
            };

            List<Student> Result = Studenten.Where(s => s.Achternaam.StartsWith(zoekterm)).ToList();
            ViewData["Zoekterm"] = zoekterm;

            return View(Result);
        }
    }
}