using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using InventoryAPI.Data;
using InventoryAPI.Models;

namespace InventoryAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ItemsController : ControllerBase
    {
        private readonly AppDbContext _context;

        // Inject the Entity Framework Core database context
        public ItemsController(AppDbContext context)
        {
            _context = context;
        }

        // GET: api/items
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Item>>> GetItems()
        {
            // Pulls live records directly from the database table
            return await _context.Items.ToListAsync();
        }

        // POST: api/items
        [HttpPost]
        public async Task<ActionResult> AddItem(Item item)
        {
            _context.Items.Add(item);
            await _context.SaveChangesAsync();
            return Ok("Item Added Successfully");
        }

        // PUT: api/items/5
        [HttpPut("{id}")]
        public async Task<ActionResult> UpdateItem(int id, Item updatedItem)
        {
            // Find the record using its unique database identity primary key
            var item = await _context.Items.FindAsync(id);

            if (item == null)
            {
                return NotFound("Item not found in database.");
            }

            // Apply all modified properties
            item.Name = updatedItem.Name;
            item.Code = updatedItem.Code; // Users can now change the textual item code too!
            item.Brand = updatedItem.Brand;
            item.UnitPrice = updatedItem.UnitPrice;
            item.StockQuantity = updatedItem.StockQuantity;
            item.LowStockThreshold = updatedItem.LowStockThreshold;

            await _context.SaveChangesAsync();
            return Ok("Item Updated Successfully");
        }

        // DELETE: api/items/5
        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteItem(int id)
        {
            // Find the record using its unique database identity primary key
            var item = await _context.Items.FindAsync(id);

            if (item == null)
            {
                return NotFound("Item not found in database.");
            }

            _context.Items.Remove(item);
            await _context.SaveChangesAsync();

            return Ok("Item Deleted Successfully");
        }
    }
}
