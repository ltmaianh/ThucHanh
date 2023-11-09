using DemoMVC.Data;
using DemoMVC.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SQLitePCL;
using System.Net;
//Le Thi Mai Anh-2021050076
namespace DemoMVC.Controllers{
    public class PresonController: Controller{
        private readonly ApplicationDbContext _context;
        public PresonController(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult>Index(){
            var model = await _context.Preson.ToListAsync();
            return View(model);
        }
        

public IActionResult Create()
    {
       
        return View();
    }
[HttpPost]
[ValidateAntiForgeryToken]
public async Task<IActionResult>Create([Bind("PresonId,FullName,Address")] Preson preson){
    if (ModelState.IsValid){
        _context.Add(preson);
        await _context.SaveChangesAsync();
        return RedirectToAction(nameof(Index));
    }
    return View(preson);
}
public async Task<IActionResult> Edit(string id){
    if(id==null|| _context.Preson==null){
        return NotFound();
    }
    var preson = await _context.Preson.FindAsync(id);
    if(preson==null){
        return NotFound();
    }
    return View(preson);
}
[HttpPost]
[ValidateAntiForgeryToken]

    
             public async Task<IActionResult> Edit(string id, [Bind("PresonId,FullName,Age,Address")] Preson preson)
        {
            if (id != preson.PresonId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(preson);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PresonExists(preson.PresonId))
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
            return View(preson);
        }

        private bool PresonExists(string presonId)
        {
            throw new NotImplementedException();
        }

        public async Task<IActionResult> Delete(string id)
        {
            if (id == null || _context.Preson == null)
            {
                return NotFound();
            }

            var person = await _context.Preson
                .FirstOrDefaultAsync(m => m.PresonId == id);
            if (person == null)
            {
                return NotFound();
            }

            return View(person);
        }
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
public async Task<IActionResult> DeleteConfirmed(string id)
        {
            if (_context.Preson == null)
            {
                return Problem("Entity set 'ApplicationDbContext.Preson'  is null.");
            }
            var person = await _context.Preson.FindAsync(id);
            if (person != null)
            {
                _context.Preson.Remove(person);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PersonExists(string id)
        {
          return (_context.Preson?.Any(e => e.PresonId == id)).GetValueOrDefault();
        }

      
    }
}

