using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Team_1_E_commerce.Data;
using Team_1_E_commerce.Models;

namespace Team_1_E_commerce.Controllers
{
    [Authorize]
    public class CategoryController : Controller
    {
        private readonly Team_1_E_commerceContext _context;
        public CategoryController(Team_1_E_commerceContext context)
        {
            _context = context;

        }
        public IActionResult Index()
        {
            IEnumerable<Category> objList = _context.Category;
            return View(objList);
        }

        //GET - CREATE
        public IActionResult Create()
        {
            return View();
        }

        //POST - CREATE
        [HttpPost]
        [ValidateAntiForgeryToken] 
        public IActionResult Create(Category obj)
        {
            if (ModelState.IsValid)
            {
                _context.Category.Add(obj);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(obj);
        }

        //GET - EDIT
        public IActionResult Edit(int? id)
        {
            if(id == null || id == 0)
            {
                return NotFound();
            }
            var obj = _context.Category.Find(id);
            if(obj == null)
            {
                return NotFound();
            }
            return View(obj);
        }
        //POST - EDIT
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Category obj)
        {
            if (ModelState.IsValid)
            {
                _context.Category.Update(obj);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(obj);
        }

        //GET - DELETE
        public IActionResult Delete(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            var obj = _context.Category.Find(id);
            if (obj == null)
            {
                return NotFound();
            }
            return View(obj);
        }
        //POST - DELETE
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int? id)
        {
            var categoryType = _context.Category.Find(id);
            if(categoryType == null)
            {
                return NotFound();
            }
                _context.Category.Remove(categoryType);
                _context.SaveChanges();
                return RedirectToAction("Index");
        }
    }
}
