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
using MS4App.Extensions;

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
            // Using LINQ
            // To get all values
            // Quarry Method 1
            //var applicationDbContext = _context.CnItems;

        
            // Quarry Method 2
            var applicationDbContext = from CnItem in _context.CnItemsMain select CnItem;
   
           var a = applicationDbContext.ToList();
            
            CnItemsCollections cnItems = new CnItemsCollections();


            cnItems.CnItemsList = a;
            return View(cnItems);

        }


        [Authorize]
        [HttpPost]
        public IActionResult CnComputationViewEdit(string[] cnItemsSelected, string cnSelect)
        {
            var applicationDbContext = _context.CnItemsMain;
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
                HttpContext.Session.SetInt32(cnSelecDict[cnSelect], 0);

                ViewBag.IsCnSelected = true;
                ViewBag.CnMessage = String.Format("{0} is saved.", cnSelecDict[cnSelect]);

                //TempData["Selection"] = cnItemsSelected;

                //var SelectDB = _context.CnItemsSelection1;

                dynamic SelectDB = null; 

                if (cnSelect == "Save pref. 1...")
                {
                    SelectDB = _context.CnItemsSelection1;
                }
                else if (cnSelect == "Save pref. 2...")
                {
                    SelectDB = _context.CnItemsSelection2;
                }
                else if (cnSelect == "Save pref. 3...")
                {
                    SelectDB = _context.CnItemsSelection3;
                }


                // Remove old data
                foreach (var item in SelectDB)
                {
                    // Check wheather the item is exists
                    //var cNSelItem = SelectDB.FirstOrDefault(model => model.CnItemId == c.CnItemId);
                    SelectDB.Remove(item);
                }



                foreach (var c in _context.CnItemsMain)
                {
                    if (cnItemsSelected.Contains(c.CnItemId))
                    {
                        CnItemsSelect1 cnSel = new CnItemsSelect1()
                        {
                            CnItemId = c.CnItemId,
                            CnItemDescription = c.CnItemDescription,
                            A = c.A,
                            B = c.B,
                            C = c.C,
                            D = c.D,
                            AArea = c.AArea,
                            BArea = c.BArea,
                            CArea = c.CArea,
                            DArea = c.DArea,
                            IsChecked = c.IsChecked
                        };
                        // Adding to DB
                        SelectDB.Add(cnSel);
                    }
                  
                }
                _context.SaveChanges();
            }
            else
            {
                ViewBag.IsCnSelected = false;
                ViewBag.CnMessage = "Please select at leat one item!";
            }  
            return View(cnItems);
        }

        private ApplicationDbContext GetContext()
        {
            return _context;
        }

        public IActionResult ViewEditCnSelection()
        {
            var sel1Dbcontext = _context.CnItemsSelection1;
            var sel1 = sel1Dbcontext.ToList();

            CnItemsCollections sel1CnItems = new CnItemsCollections()
            {
                Sel1CnItemsList = sel1
            };           

            return View(sel1CnItems);
            
        }

    }
}