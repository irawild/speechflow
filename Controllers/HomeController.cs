﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Threading.Tasks;
using System.Web.Mvc.Ajax;

namespace speechflow.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            //var mvcName = typeof(Controller).Assembly.GetName();
            //var isMono = Type.GetType("Mono.Runtime") != null;

            //ViewData["Version"] = mvcName.Version.Major + "." + mvcName.Version.Minor;
            //ViewData["Runtime"] = isMono ? "Mono" : ".NET";

            var listaExpenses = BusinessRules.BRExpense.getExpenses().Result;

            return View(listaExpenses);
        }
    }
}
