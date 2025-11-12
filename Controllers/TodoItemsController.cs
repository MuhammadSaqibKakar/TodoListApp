using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TodoApp.Data;
using TodoApp.Models;
using System.Linq;


namespace TodoApp.Controllers
{
    public class TodoItemsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public TodoItemsController(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var items = await _context.TodoItems
                .OrderByDescending(t => t.CreatedAt) // newest first
                .ToListAsync();
            return View(items);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(TodoItem item)
        {
            if (ModelState.IsValid)
            {
                item.CreatedAt = DateTime.Now;  // ensure timestamp is set
                _context.TodoItems.Add(item);
                await _context.SaveChangesAsync();
            }
            // Redirect to Index to prevent duplicate post
            return RedirectToAction(nameof(Index));
        }

        [HttpPost]
        public async Task<IActionResult> ToggleComplete(int id)
        {
            var item = await _context.TodoItems.FindAsync(id);
            if (item != null)
            {
                item.IsCompleted = !item.IsCompleted;
                await _context.SaveChangesAsync();
            }
            return RedirectToAction(nameof(Index));
        }

        [HttpPost]
        public async Task<IActionResult> Delete(int id)
        {
            var item = await _context.TodoItems.FindAsync(id);
            if (item != null)
            {
                _context.TodoItems.Remove(item);
                await _context.SaveChangesAsync();
            }
            return RedirectToAction(nameof(Index));
        }
        [HttpPost]
      [HttpPost]
[ValidateAntiForgeryToken]
public async Task<IActionResult> ClearCompleted()
{
    var completedTasks = _context.TodoItems
        .Where(t => t.IsCompleted)
        .ToList();
    _context.TodoItems.RemoveRange(completedTasks);
    await _context.SaveChangesAsync();
    return RedirectToAction(nameof(Index));
}



    }
}
