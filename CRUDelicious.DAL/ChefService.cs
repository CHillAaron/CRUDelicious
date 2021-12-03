using CRUDelicious.CORE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace CRUDelicious.DAL
{
    public class ChefService
    {
        CrudeliciousDbContext _context { get; }

        public ChefService(CrudeliciousDbContext context)
        {
            _context = context;
        }
        public List<Chef> GetAll()
        {
            return _context.Chefs.Include(thisItem => thisItem.AllDishes).ToList<Chef>();
        }
        public Chef GetItem(int id)
        {
            return _context.Chefs.Where(thisItem => thisItem.ChefId == id).Include(thisItem=> thisItem.AllDishes).FirstOrDefault();
        }
        public void AddItem(Chef newItem)
        {
            _context.Chefs.Add(newItem);
            _context.SaveChanges();
        }
        public void UpdateItem(Chef updateItem)
        {
            _context.Chefs.Update(updateItem);
            _context.SaveChanges();
        }
        public void DeleteTodoItem(int id)
        {
            _context.Chefs.Remove(GetItem(id));
            _context.SaveChanges();
        }
    }
}
