using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Team_1_E_commerce.Data;
using Team_1_E_commerce.Models;

namespace Team_1_E_commerce.Controllers
{
    [Authorize]
    public class ProductsController : Controller
    {
        private readonly Team_1_E_commerceContext _context;
        private readonly IWebHostEnvironment _hostEnvironment;

        public ProductsController(Team_1_E_commerceContext context, IWebHostEnvironment hostEnvironment)
        {
            _context = context;
            this._hostEnvironment = hostEnvironment;
        }

        // GET: Products
        [AllowAnonymous]
        public async Task<IActionResult> Index(string searchString)
        {
            var prod = from m in _context.Product
                         select m;

            if (!String.IsNullOrEmpty(searchString))
            {
                prod = prod.Where(s => s.ModelName.Contains(searchString));
            }

            return View(await prod.Include(c => c.Category).ToListAsync());
        }

        // GET: Products
        [AllowAnonymous]
        public async Task<IActionResult> IndexAd(string searchString)
        {
            var prod = from m in _context.Product
                       select m;

            if (!String.IsNullOrEmpty(searchString))
            {
                prod = prod.Where(s => s.ModelName.Contains(searchString));
            }

            return View(await prod.Include(c => c.Category).ToListAsync());
        }

        // GET: Products/ProductDetail/5
        [AllowAnonymous]
        public async Task<IActionResult> ProductDetail(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var eachproduct = await _context.Product
                .FirstOrDefaultAsync(m => m.Id == id);
            if (eachproduct == null)
            {
                return NotFound();
            }

            return View(eachproduct);
        }

        // GET: Products/Details/5
        [AllowAnonymous]
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var product = await _context.Product
                .FirstOrDefaultAsync(m => m.Id == id);
            if (product == null)
            {
                return NotFound();
            }

            return View(product);
        }

        // GET: Products/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Products/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,ModelName,Image,ImageFile,Price,ModelType,CategoryId,Category")] Product product)
        {
            if (product != null)
            {
                // save image to wwwroot/image
                string wwwRootPath = _hostEnvironment.WebRootPath;
                string fileName = Path.GetFileNameWithoutExtension(product.ImageFile.FileName);
                string fileExtension = Path.GetExtension(product.ImageFile.FileName);
                product.Image = fileName + DateTime.Now.ToString("yymmssfff") + fileExtension;
                string path = Path.Combine(wwwRootPath + "/image/" + product.Image);
                using (var fileStream = new FileStream(path, FileMode.Create))
                {
                    await product.ImageFile.CopyToAsync(fileStream);
                }

                _context.Add(product);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(product);
        }

        // GET: Products/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var product = await _context.Product.FindAsync(id);
            if (product == null)
            {
                return NotFound();
            }
            return View(product);
        }

        // POST: Products/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,ModelName,Image,ImageFile,Price,ModelType,CategoryId,Category")] Product product)
        {
            if (id != product.Id)
            {
                return NotFound();
            }

            if (product.ImageFile != null)//ModelState.IsValid)
            {
                try
                {
                    string wwwRootPath = _hostEnvironment.WebRootPath;
                    string fileName = Path.GetFileNameWithoutExtension(product.ImageFile.FileName);
                    string fileExtension = Path.GetExtension(product.ImageFile.FileName);
                    product.Image = fileName + DateTime.Now.ToString("yymmssfff") + fileExtension;
                    string path = Path.Combine(wwwRootPath + "/image/" + product.Image);
                    using (var fileStream = new FileStream(path, FileMode.Create))
                    {
                        await product.ImageFile.CopyToAsync(fileStream);
                    }

                    _context.Update(product);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProductExists(product.Id))
                    {
                        return NotFound();
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(product);
        }

        // GET: Products/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var product = await _context.Product
                .FirstOrDefaultAsync(m => m.Id == id);
            if (product == null)
            {
                return NotFound();
            }

            return View(product);
        }

        // POST: Products/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var product = await _context.Product.FindAsync(id);
            _context.Product.Remove(product);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ProductExists(int id)
        {
            return _context.Product.Any(e => e.Id == id);
        }

    }
}
