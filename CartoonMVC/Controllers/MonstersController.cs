#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using CartoonMVC.Data;
using CartoonMVC.Models;

namespace CartoonMVC.Controllers
{
    public class MonstersController : Controller
    {
        private readonly CartoonMVCContext _context;

        public MonstersController(CartoonMVCContext context)
        {
            _context = context;
        }

        // GET: Monsters
        public async Task<IActionResult> Index(string monsterElement, string searchString)
        {
           // var monsters = from m in _context.Monster select m;

            //if (!String.IsNullOrEmpty(searchString))
            //{
            //    monsters = monsters.Where(s => s.Name!.Contains(searchString));
            //}

            //return View(await monsters.ToListAsync());

            ////return View(await _context.Monster.ToListAsync());




            // Use LINQ to get list of genres.
            IQueryable<string> elementQuery = from m in _context.Monster
                orderby m.Element
                select m.Element;

            var monsters = from m in _context.Monster select m;

            if (!string.IsNullOrEmpty(searchString))
            {
                monsters = monsters.Where(s => s.Name!.Contains(searchString));
            }

            if (!string.IsNullOrEmpty(monsterElement))
            {
                monsters = monsters.Where(x => x.Element == monsterElement);
            }

            var monsterElementVM = new MonsterElementViewModel()
            {
                Elements = new SelectList(await elementQuery.Distinct().ToListAsync()),
                Monsters = await monsters.ToListAsync()
            };

            return View(monsterElementVM);
        }

        // GET: Monsters/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var monster = await _context.Monster
                .FirstOrDefaultAsync(m => m.Id == id);
            if (monster == null)
            {
                return NotFound();
            }

            return View(monster);
        }

        // GET: Monsters/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Monsters/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,Age,IQ,SeenLastTime,Element,Warning,Weaknesses,Strength,Speed,Naughtiness,DegreeOfDanger,Information,ImageUrl")] Monster monster)
        {
            if (ModelState.IsValid)
            {
                _context.Add(monster);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(monster);
        }

        // GET: Monsters/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var monster = await _context.Monster.FindAsync(id);
            if (monster == null)
            {
                return NotFound();
            }
            return View(monster);
        }

        // POST: Monsters/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,Age,IQ,SeenLastTime,Element,Warning,Weaknesses,Strength,Speed,Naughtiness,DegreeOfDanger,Information,ImageUrl")] Monster monster)
        {
            if (id != monster.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(monster);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MonsterExists(monster.Id))
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
            return View(monster);
        }

        // GET: Monsters/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var monster = await _context.Monster
                .FirstOrDefaultAsync(m => m.Id == id);
            if (monster == null)
            {
                return NotFound();
            }

            return View(monster);
        }

        // POST: Monsters/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var monster = await _context.Monster.FindAsync(id);
            _context.Monster.Remove(monster);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool MonsterExists(int id)
        {
            return _context.Monster.Any(e => e.Id == id);
        }
    }
}
