using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Web;
using System.Web.Mvc;
using jan31practice.Models;

namespace jan31practice.Controllers
{
    public class CourseController : Controller
    {
        // GET: Course
        static List<Class1> class1 = new List<Class1>()
        {
           
            new Class1{  CId=1,CName="Venu",CFee=35000,Technology="Java",CStartDate=new DateTime(day:01,month:01,year:2024),CEndDate=new DateTime(day:24,month:02,year:2024)},
            new Class1{ CId=2,CName="Raj",CFee=35000,Technology="C++",CStartDate=new DateTime(day:01,month:02,year:2024),CEndDate=new DateTime(day:24,month:03,year:2024)},
            new Class1{  CId = 3, CName = "Hari", CFee = 35000, Technology = "Python", CStartDate = new DateTime(day: 01, month: 03, year: 2024), CEndDate = new DateTime(day: 24, month: 04, year: 2024)},
            new Class1{ CId=4,CName="Vadde",CFee=35000,Technology="Cloud",CStartDate=new DateTime(day:01, month:05, year:2024),CEndDate=new DateTime(day:24, month:06, year:2024)},
            new Class1{CId = 5,CName = "Srennu",CFee = 35000,Technology = "SAP",CStartDate = new DateTime(day: 01, month: 07, year: 2024),CEndDate = new DateTime(day: 24, month: 08, year: 2024)}

          
        };
public ActionResult Index()
{
    return View(class1);
        }
        [HttpGet]
        public ActionResult Create()
        {
            return View(new Class1());
        }
        [HttpPost]
        public ActionResult Create(Class1 cls) { 

            if (ModelState.IsValid)
            {
                class1.Add(cls);
                return RedirectToAction("Index");
            }
            return View(cls);   
        }
       
        
    }
}