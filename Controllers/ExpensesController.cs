using Microsoft.AspNetCore.Mvc;
using ExpenseTrackerAPI.Data;
using ExpenseTrackerAPI.Models;

namespace ExpenseTrackerAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ExpensesController : ControllerBase
    {
        private readonly AppDbContext _context;
        public ExpensesController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult GetAll() =>
            Ok(_context.Expenses.ToList());

        [HttpPost]
        public IActionResult Create(Expense expense)
        {
            _context.Expenses.Add(expense);
            _context.SaveChanges();
            return Ok(expense);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var exp = _context.Expenses.Find(id);
            if (exp == null) return NotFound();
            _context.Expenses.Remove(exp);
            _context.SaveChanges();
            return NoContent();
        }
    }
}