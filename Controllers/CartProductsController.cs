using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Team_1_E_commerce.Areas.Identity.Data;
using Team_1_E_commerce.Data;
using Team_1_E_commerce.Models;

namespace Team_1_E_commerce.Controllers
{
    [Authorize]
    public class CartProductsController : Controller
    {
        private readonly Team_1_E_commerceContext _context;
        private readonly UserManager<ApplicationUser> _userManager;

        public CartProductsController(Team_1_E_commerceContext context, UserManager<ApplicationUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }
        // GET: CartProducts
        public async Task<IActionResult> Index()
        {
            var cartProducts = from m in _context.CartProducts
                       select m;
            
            return View(await cartProducts.Include(c => c.Cart).Include(p => p.Product).ToListAsync());
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AddToCart(Product product)
        {
            CartProduct cartProduct = new CartProduct();
            Cart cart = new Cart();
            ApplicationUser applicationUser = await _userManager.GetUserAsync(User);
            var userid = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var userId = _userManager.GetUserId(User);
            
            cart.CartOwner = applicationUser.UserName;
            _context.Cart.Add(cart);
            _context.SaveChanges();

            cartProduct.CartId = cart.Id;                              
            cartProduct.ProductId = product.Id;
            _context.CartProducts.Add(cartProduct);
            _context.SaveChanges();

            return RedirectToAction("Index");
        }

        // POST: CartProducts/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Delete(int id)
        {
            var cartProduct = await _context.CartProducts.FindAsync(id);
            _context.CartProducts.Remove(cartProduct);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
    }
}
