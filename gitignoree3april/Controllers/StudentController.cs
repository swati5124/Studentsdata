using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using gitignoree3april.Models;
using Microsoft.AspNetCore.Mvc;

namespace gitignoree3april.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            List<Student> obj = new List<Student>() {
           new Student  { SId = 101, Name = "Sam" },


            new Student  { SId = 102, Name = "Abha" }
        };
             return View(obj);

        }
           
        }
    }
