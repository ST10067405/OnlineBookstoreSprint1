using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using EpicBookstore.Data;
using EpicBookstore.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Authorization;

namespace EpicBookstore.Controllers
{
    //public class CartController : Controller
    //{
    //    private readonly ApplicationDbContext _context;

    //    public CartController(ApplicationDbContext context)
    //    {
    //        _context = context;
    //    }

    //    // GET: Cart
    //    public async Task<IActionResult> Index()
    //    {
    //        var applicationDbContext = _context.Cart.Include(c => c.ItemModel);
    //        return View(await applicationDbContext.ToListAsync());
    //    }

    //    // GET: Cart/Details/5
    //    public async Task<IActionResult> Details(int? id)
    //    {
    //        if (id == null)
    //        {
    //            return NotFound();
    //        }

    //        var cartModel = await _context.Cart
    //            .Include(c => c.ItemModel)
    //            .FirstOrDefaultAsync(m => m.CartId == id);
    //        if (cartModel == null)
    //        {
    //            return NotFound();
    //        }

    //        return View(cartModel);
    //    }

    //    // GET: Cart/Create
    //    public IActionResult Create()
    //    {
    //        ViewData["ItemId"] = new SelectList(_context.Item, "Id", "ISBN");
    //        return View();
    //    }

    //    // POST: Cart/Create
    //    // To protect from overposting attacks, enable the specific properties you want to bind to.
    //    // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
    //    [HttpPost]
    //    [ValidateAntiForgeryToken]
    //    public async Task<IActionResult> Create([Bind("CartId,TotalPrice,Quantity,ItemId,UserId")] CartModel cartModel)
    //    {
    //        if (ModelState.IsValid)
    //        {
    //            _context.Add(cartModel);
    //            await _context.SaveChangesAsync();
    //            return RedirectToAction(nameof(Index));
    //        }
    //        ViewData["ItemId"] = new SelectList(_context.Item, "Id", "ISBN", cartModel.ItemId);
    //        return View(cartModel);
    //    }

    //    // GET: Cart/Edit/5
    //    public async Task<IActionResult> Edit(int? id)
    //    {
    //        if (id == null)
    //        {
    //            return NotFound();
    //        }

    //        var cartModel = await _context.Cart.FindAsync(id);
    //        if (cartModel == null)
    //        {
    //            return NotFound();
    //        }
    //        ViewData["ItemId"] = new SelectList(_context.Item, "Id", "ISBN", cartModel.ItemId);
    //        return View(cartModel);
    //    }

    //    // POST: Cart/Edit/5
    //    // To protect from overposting attacks, enable the specific properties you want to bind to.
    //    // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
    //    [HttpPost]
    //    [ValidateAntiForgeryToken]
    //    public async Task<IActionResult> Edit(int id, [Bind("CartId,TotalPrice,Quantity,ItemId,UserId")] CartModel cartModel)
    //    {
    //        if (id != cartModel.CartId)
    //        {
    //            return NotFound();
    //        }

    //        if (ModelState.IsValid)
    //        {
    //            try
    //            {
    //                _context.Update(cartModel);
    //                await _context.SaveChangesAsync();
    //            }
    //            catch (DbUpdateConcurrencyException)
    //            {
    //                if (!CartModelExists(cartModel.CartId))
    //                {
    //                    return NotFound();
    //                }
    //                else
    //                {
    //                    throw;
    //                }
    //            }
    //            return RedirectToAction(nameof(Index));
    //        }
    //        ViewData["ItemId"] = new SelectList(_context.Item, "Id", "ISBN", cartModel.ItemId);
    //        return View(cartModel);
    //    }

    //    // GET: Cart/Delete/5
    //    public async Task<IActionResult> Delete(int? id)
    //    {
    //        if (id == null)
    //        {
    //            return NotFound();
    //        }

    //        var cartModel = await _context.Cart
    //            .Include(c => c.ItemModel)
    //            .FirstOrDefaultAsync(m => m.CartId == id);
    //        if (cartModel == null)
    //        {
    //            return NotFound();
    //        }

    //        return View(cartModel);
    //    }

    //    // POST: Cart/Delete/5
    //    [HttpPost, ActionName("Delete")]
    //    [ValidateAntiForgeryToken]
    //    public async Task<IActionResult> DeleteConfirmed(int id)
    //    {
    //        var cartModel = await _context.Cart.FindAsync(id);
    //        if (cartModel != null)
    //        {
    //            _context.Cart.Remove(cartModel);
    //        }

    //        await _context.SaveChangesAsync();
    //        return RedirectToAction(nameof(Index));
    //    }

    //    private bool CartModelExists(int id)
    //    {
    //        return _context.Cart.Any(e => e.CartId == id);
    //    }
    //}

    [Authorize]

    public class CartController : Controller
    {
        private readonly ApplicationDbContext _context;

        private readonly UserManager<IdentityUser> _userManager;

        public CartController(ApplicationDbContext context, UserManager<IdentityUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        public async Task<IActionResult> Index()
        {
            return View();
        }

        public async Task<IActionResult> Cart()
        {
            var user = await _userManager.GetUserAsync(User);

            var cartItems = _context.Cart
                .Include(c => c.ItemModel)
                .Where(c => c.UserId == user.Id)
                .ToListAsync();

            return View(cartItems);
        }

        [HttpPost]
        public IActionResult RemoveFromCart(int id)
        {
            var cartItem = _context.Cart.Find(id);

            if (cartItem != null)
            {
                _context.Cart.Remove(cartItem);
                _context.SaveChanges();
            }

            return RedirectToAction("Cart");
        }

        public IActionResult Checkout()
        {
            // Here you can implement the checkout logic
            // For example, you can create an OrderModel and OrderItemModel records

            return View();
        }
    }

}
