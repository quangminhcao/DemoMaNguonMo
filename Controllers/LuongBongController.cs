using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using NetCoreDemo.Data;
using NetCoreDemo.Models;

namespace NetCoreDemo.Controllers
{
    public class LuongBongController : Controller
    {
        private readonly NetCoreDbContext _context;

        public LuongBongController(NetCoreDbContext context)
        {
            _context = context;
        }

        // GET: LuongBong
        public async Task<IActionResult> Index()
        {
            var netCoreDbContext = _context.LuongBong.Include(l => l.NhanViens);
            return View(await netCoreDbContext.ToListAsync());
        }

        // GET: LuongBong/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var luongBong = await _context.LuongBong
                .Include(l => l.NhanViens)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (luongBong == null)
            {
                return NotFound();
            }

            return View(luongBong);
        }

        // GET: LuongBong/Create
        public IActionResult Create()
        {
            ViewData["NhanVienId"] = new SelectList(_context.NhanVien, "NhanVienId", "NhanVienId");
            return View();
        }

        // POST: LuongBong/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,NhanVienId")] LuongBong luongBong)
        {
            if (ModelState.IsValid)
            {
                _context.Add(luongBong);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["NhanVienId"] = new SelectList(_context.NhanVien, "NhanVienId", "NhanVienId", luongBong.NhanVienId);
            return View(luongBong);
        }

        // GET: LuongBong/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var luongBong = await _context.LuongBong.FindAsync(id);
            if (luongBong == null)
            {
                return NotFound();
            }
            ViewData["NhanVienId"] = new SelectList(_context.NhanVien, "NhanVienId", "NhanVienId", luongBong.NhanVienId);
            return View(luongBong);
        }

        // POST: LuongBong/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,NhanVienId")] LuongBong luongBong)
        {
            if (id != luongBong.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(luongBong);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!LuongBongExists(luongBong.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["NhanVienId"] = new SelectList(_context.NhanVien, "NhanVienId", "NhanVienId", luongBong.NhanVienId);
            return View(luongBong);
        }

        // GET: LuongBong/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var luongBong = await _context.LuongBong
                .Include(l => l.NhanViens)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (luongBong == null)
            {
                return NotFound();
            }

            return View(luongBong);
        }

        // POST: LuongBong/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var luongBong = await _context.LuongBong.FindAsync(id);
            _context.LuongBong.Remove(luongBong);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool LuongBongExists(int id)
        {
            return _context.LuongBong.Any(e => e.Id == id);
        }
    }
}
