﻿using System;
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
                dynamic cnSel = null;

                if (cnSelect == "Save pref. 1...")
                {
                    SelectDB = _context.CnItemsSelection1;
                    HttpContext.Session.SetString(cnSelecDict[cnSelect], cnSelecDict[cnSelect]);
                    cnSel = new CnItemsSelect1();
                }
                else if (cnSelect == "Save pref. 2...")
                {
                    SelectDB = _context.CnItemsSelection2;
                    HttpContext.Session.SetString(cnSelecDict[cnSelect], cnSelecDict[cnSelect]);
                    cnSel = new CnItemsSelect2();
                }
                else if (cnSelect == "Save pref. 3...")
                {
                    SelectDB = _context.CnItemsSelection3;
                    HttpContext.Session.SetString(cnSelecDict[cnSelect], cnSelecDict[cnSelect]);
                    cnSel = new CnItemsSelect3();

                }

                
                // Remove old data
                foreach (var item in SelectDB)
                {
                    // Check wheather the item is exists
                    //var cNSelItem = SelectDB.FirstOrDefault(model => model.CnItemId == c.CnItemId);
                    SelectDB.Remove(item);
                    
                }
                _context.SaveChanges();


                var MainDbList = _context.CnItemsMain.ToList();

               // foreach (var c in _context.CnItemsMain)
                for (int i = 0; i < MainDbList.Count(); i++)
                {
                    var c = MainDbList[i];
                    if (cnItemsSelected.Contains(c.CnItemId))
                    {
                        cnSel.CnItemId = c.CnItemId;
                        cnSel.CnItemDescription = c.CnItemDescription;
                        cnSel.A = c.A;
                        cnSel.B = c.B;
                        cnSel.C = c.C;
                        cnSel.D = c.D;
                        cnSel.AArea = c.AArea;
                        cnSel.BArea = c.BArea;
                        cnSel.CArea = c.CArea;
                        cnSel.DArea = c.DArea;
                        cnSel.IsChecked = c.IsChecked;

                        if (ModelState.IsValid)
                        {
                            // Adding to DB
                            SelectDB.Add(cnSel);
                            _context.SaveChanges();
                        }
                    }
                  
                }
                //_context.SaveChanges();
            }
            else
            {
                ViewBag.IsCnSelected = false;
                ViewBag.CnMessage = "Please select at leat one item!";
            }  
            return View(cnItems);
        }



        // To display CN selections to enter values
        [HttpPost]
        public IActionResult ViewEditCnSelection1(string showSelect)
        {
            ViewBag.CnSelection = showSelect;
            CnItemsCollections selCnItems = new CnItemsCollections();

            var selDbContext = _context.CnItemsSelection1;
            selCnItems.Sel1CnItemsList = selDbContext.ToList();
    
            return View(selCnItems);
            //return RedirectToAction("Index");
        }


        [HttpPost]
        public IActionResult ViewEditCnSelection2(string showSelect)
        {
            ViewBag.CnSelection = showSelect;
            CnItemsCollections selCnItems = new CnItemsCollections();

            var selDbContext = _context.CnItemsSelection2;
            selCnItems.Sel2CnItemsList = selDbContext.ToList();

            return View(selCnItems);
            //return RedirectToAction("Index");
        }


        [HttpPost]
        public IActionResult ViewEditCnSelection3(string showSelect)
        {
            ViewBag.CnSelection = showSelect;
            CnItemsCollections selCnItems = new CnItemsCollections();

            var selDbContext = _context.CnItemsSelection3;
            selCnItems.Sel3CnItemsList = selDbContext.ToList();

            return View(selCnItems);
            //return RedirectToAction("Index");
        }


        public IActionResult CnShowSelection()
        {
            ViewBag.CnSelection1 = HttpContext.Session.GetString("Selection 1");
            ViewBag.CnSelection2 = HttpContext.Session.GetString("Selection 2");
            ViewBag.CnSelection3 = HttpContext.Session.GetString("Selection 3");
            return View();
        }


    }
}