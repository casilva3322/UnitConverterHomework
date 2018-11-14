using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using UnitConverterMVS11142018.Models;

 public class ConversionController : Controller
    {
       public IActionResult Index()
        {   string message = "this is the msg";
            ViewData["Message"] = message;
            return View();
        }
        public IActionResult Converter()
        {   
            return View();
        }
        public IActionResult DoConversion()
        {   string message = "this is the msg";
            ViewData["Message"] = message;
            return View();
        }
    }