using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using MS4App.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Http;
using MS4App.Models.CalculationViewModels;

namespace MS4App.Controllers
{
    public class CnComputationController : Controller
    {
        // Gettng info from database
        private readonly ApplicationDbContext _context;

        // Constructor
        public CnComputationController(ApplicationDbContext context)
        {
            _context = context;
        }

        
        [Authorize]
        public IActionResult CnComputationLanding()
        {
            return View();
        }


        [Authorize]
        public IActionResult CnComputationViewEdit()
        {
            var applicationDbContext = _context.CnItems;
            var a = applicationDbContext.ToList();
            
            CnItemsCollections cnItems = new CnItemsCollections();

            cnItems.CnItemsList = a;
            return View(cnItems);

        }


        [Authorize]
        [HttpPost]
        public IActionResult CnComputationViewEdit(string[] cnItemsSelected, string cnSelect)
        {
            var applicationDbContext = _context.CnItems;
            var a = applicationDbContext.ToList();

            CnItemsCollections cnItems = new CnItemsCollections
            {
                CnItemsList = a
            };

            Dictionary<string, string> cnSelecDict = new Dictionary<string, string>
            {
                { "Save pref. 1...", "Selection 1" },
                { "Save pref. 2...", "Selection 2" },
                { "Save pref. 3...", "Selection 3" }
            };
            if (cnItemsSelected.Length > 0)
            {
                ViewBag.IsCnSelected = true;
                ViewBag.CnMessage = String.Format("{0} is saved.", cnSelecDict[cnSelect]);

                //// Get selected items to Session
                //Dictionary<>
                //foreach (string cnItem in cnItemsSelected)
                //{

                //}
                HttpContext.Session.SetString("itemsAll", cnItems.ToString());
                HttpContext.Session.SetString  ("cnItemsSelected", cnItemsSelected.ToString());
            }
            else
            {
                ViewBag.IsCnSelected = false;
                ViewBag.CnMessage = "Please select at leat one item!";
            }
             
            

            return View(cnItems);
        }

        public IActionResult ViewEditCnSelection()
        {
            return View();
        }
    }
}